using Services;
using Services.AgencyParseService;
using Services.AgencyService;
using Services.LocalityService;
using Services.SettingsService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Views.UserControls;

namespace UI.Presenters
{
    public class AgencyPresenter : IAgencyPresenter
    {
        #region Members

        readonly IAgencyService _agencyService;
        readonly ILocalityService _localityService;
        readonly IAgenciesUC _agenciesUC;
        readonly IAgencyDetailsUC _agencyDetailsUC;
        IErrorMessageView _errorMessageView;
        IDeleteConfirmView _deleteConfirmView;
        List<ParseAgencyDto> parsedAgencies = new List<ParseAgencyDto>();
        SettingsDto _settingsDto;

        #endregion

        #region Ctor

        public AgencyPresenter(
            IAgencyService agencyService,
            ILocalityService localityService,
            IAgenciesUC agenciesUC,
            IAgencyDetailsUC agencyDetailsUC,
            IErrorMessageView errorMessageView,
            IDeleteConfirmView deleteConfirmView)
        {
            _agencyService = agencyService;
            _localityService = localityService;
            _agenciesUC = agenciesUC;
            _agencyDetailsUC = agencyDetailsUC;
            _errorMessageView = errorMessageView;
            _deleteConfirmView = deleteConfirmView;

            _settingsDto = new SettingsDto
            {
                BaseUrl = ConfigurationManager.AppSettings["baseUrl"],
                ButtonsGetInTouchSelector = ConfigurationManager.AppSettings["buttonsGetInTouchSelector"],
                PropertiesForRentSelector = ConfigurationManager.AppSettings["propertiesForRentSelector"],
                PropertiesSoldSelector = ConfigurationManager.AppSettings["propertiesSoldSelector"],
                ThreadsNumber = int.Parse(ConfigurationManager.AppSettings["numberOfParallellyParsersToPerform"])
            };

            SubscribeToEvents();
        }

        #endregion

        public IAgenciesUC GetAgenciesUC()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                _agenciesUC.SetUpControls(_agencyService.GetAllAgencies());
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Agencies service", ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return _agenciesUC;
        }

        public IAgencyDetailsUC GetAgencyDetailsUC(AgencyDto agencyDto = null)
        {
            if (agencyDto != null) _agencyDetailsUC.SetUpControls(agencyDto);
            return _agencyDetailsUC;
        }

        #region Helpers

        private async void OnDeleteAgencyEventRaisedAsync(int id)
        {
            var agency = await _agencyService.GetAgencyByIdAsync(id);
            if (agency != null)
            {
                _deleteConfirmView.ShowDeleteConfirmMessageView("Delete Agency",
                    $"Please сonfirm the removal of the: {agency.Name}.", id);
            }
        }
        private async void OnDeleteConfirmViewOKEventRaisedAsync(int id)
        {
            await Task.Run(() => _agencyService.DeleteAgencyAsync(id));
            GetAgenciesUC();
        }

        private async void OnParseAgenciesOptionClickedAsync(string state)
        {
            parsedAgencies.Clear();
            var tasks = new List<Task>();
            IProgress<string> progress = new Progress<string>(UpdateStatus);
            IEnumerable<LocalityDto> localities = null;

            try
            {
                localities = (state == "All") ? _localityService.GetAllLocalities() : _localityService.GetAllLocalities().Where(l => l.State == state);
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Localities service", ex.Message);
            }

            int localitiesCountPerThread = localities.Count() / _settingsDto.ThreadsNumber + 1;

            try
            {
                for (int i = 1; i <= _settingsDto.ThreadsNumber; i++)
                {
                    IEnumerable<LocalityDto> localityDtos = localities.Skip((i - 1) * localitiesCountPerThread).Take(localitiesCountPerThread);
                    tasks.Add(Task.Run(() =>
                    {
                        var agenciesParser = AgencyParserFactory.GetSeleniumAgencyParser(_settingsDto);
                        parsedAgencies.AddRange(agenciesParser.ParseAgenciesFromRE(localityDtos));
                    }));
                }
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Parser service", ex.Message);
            }

            progress.Report($"Parsing agencies for {state} in {_settingsDto.ThreadsNumber} streams.");
            await Task.WhenAll(tasks);

            try
            {
                SaveParsedAgencies();
                _agenciesUC.SetUpControls(_agencyService.GetAllAgencies());
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Agencies servise", ex.Message);
            }
        }

        private async void OnSaveAgencyEventRaisedAsync(AgencyDto agencyFromForm)
        {
            var errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(agencyFromForm, new ValidationContext(agencyFromForm, null, null), errors, true))
            {
                var sb = new StringBuilder("There are validation errors:" + Environment.NewLine);
                foreach (ValidationResult result in errors)
                    sb.AppendLine(result.ErrorMessage);
                _errorMessageView.ShowErrorMessageView("Agencies view", sb.ToString());
                return;
            }
            try
            {
                var agencyDto = await _agencyService.UpdateAgencyAsync(agencyFromForm);
                _agenciesUC.UpdateControls(agencyDto);
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Agencies service", ex.Message);
            }
        }

        private void OnShowFacebookPageOptionClicked(string linkToFacebookPage) => Process.Start(linkToFacebookPage);

        private void OnShowWebSiteOptionClicked(string linkToWebSite) => Process.Start(linkToWebSite);

        private void SaveParsedAgencies()
        {
            if (parsedAgencies.Count > 0)
            {
                foreach (var agency in parsedAgencies)
                {
                    if (Validator.TryValidateObject(agency, new ValidationContext(agency, null, null), new List<ValidationResult>()))
                        _agencyService.CreateAgency(agency);
                }
            }
        }

        private void SubscribeToEvents()
        {
            _agencyDetailsUC.DeleteAgencyEventRaised += (sender, id) => OnDeleteAgencyEventRaisedAsync(id);
            _agencyDetailsUC.SaveAgencyEventRaised += (sender, agencyFromForm) => OnSaveAgencyEventRaisedAsync(agencyFromForm);

            _agenciesUC.ParseAgenciesOptionClicked += (sender, state) => OnParseAgenciesOptionClickedAsync(state);
            _agenciesUC.ShowFacebookPageOptionClicked += (sender, linkToFacebookPage) => OnShowFacebookPageOptionClicked(linkToFacebookPage);
            _agenciesUC.ShowWebSiteOptionClicked += (sender, linkToWebSite) => OnShowWebSiteOptionClicked(linkToWebSite);

            _deleteConfirmView.DeleteConfirmViewOKEventRaised += (sender, id) => OnDeleteConfirmViewOKEventRaisedAsync(id);
        }

        private string TimeToRemain(DateTime startTime, int currentCounter, int totalCount)
        {
            if (currentCounter == 0) currentCounter++;

            var minutesToRemain = (DateTime.Now - startTime).TotalSeconds * (totalCount - currentCounter) / currentCounter / 60;

            return minutesToRemain.ToString("F1", new CultureInfo("en-us"));
        }

        private void UpdateStatus(string currentStatus) => _agenciesUC.UpdateStatus(currentStatus);

        #endregion
    }
}
