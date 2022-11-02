using Services.LocalityService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Views.UserControls;

namespace UI.Presenters
{
    public class LocalityPresenter : ILocalityPresenter
    {
        #region Members

        IErrorMessageView _errorMessageView;
        readonly ILocalityService _localityService;
        readonly ILocalitiesUC _localitiesUC;
        readonly ILocalityDetailsUC _localityDetailsUC;
        IDeleteConfirmView _deleteConfirmView;

        #endregion

        #region Ctor

        public LocalityPresenter(
            IErrorMessageView errorMessageView,
            ILocalityService localityService,
            ILocalitiesUC localitiesUC,
            ILocalityDetailsUC localityDetailsUC,
            IDeleteConfirmView deleteConfirmView)
        {
            _errorMessageView = errorMessageView;
            _localityService = localityService;
            _localitiesUC = localitiesUC;
            _localityDetailsUC = localityDetailsUC;
            _deleteConfirmView = deleteConfirmView;

            SubscribeToEvents();
        }

        #endregion

        public ILocalitiesUC GetLocalitiesUC()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                _localitiesUC.SetUpControls(_localityService.GetAllLocalities());

            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Localities service", ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return _localitiesUC;
        }

        public ILocalityDetailsUC GetLocalityDetailsUC(LocalityDto localityDto = null)
        {
            if (localityDto != null) _localityDetailsUC.SetUpControls(localityDto);

            return _localityDetailsUC;
        }

        #region Helpers

        private async void OnDeleteConfirmViewOKEventRaisedAsync(int id)
        {
            await Task.Run(() => _localityService.DeleteLocalityAsync(id));
            GetLocalitiesUC();
        }

        private async void OnDeleteLocalityEventRaisedAsync(int id)
        {
            var locality = await _localityService.GetLocalityByIdAsync(id);
            if (locality != null)
            {
                _deleteConfirmView.ShowDeleteConfirmMessageView("Delete Locality",
                    $"Please сonfirm the removal of the: {locality.Suburb}.", id);
            }
        }

        private async void OnSaveLocalityEventRaisedAsync(LocalityDto localityFromForm)
        {
            var errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(localityFromForm, new ValidationContext(localityFromForm, null, null), errors, true))
            {
                var sb = new StringBuilder("There are validation errors:" + Environment.NewLine);
                foreach (ValidationResult result in errors)
                    sb.AppendLine(result.ErrorMessage);
                _errorMessageView.ShowErrorMessageView("Localities view", sb.ToString());
                return;
            }
            try
            {
                var localityDto = await _localityService.UpdateLocalityAsync(localityFromForm);
                _localitiesUC.UpdateControls(localityDto);
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Localities service", ex.Message);
            }
        }

        private void SubscribeToEvents()
        {
            _localityDetailsUC.DeleteLocalityEventRaised += (sender, id) => OnDeleteLocalityEventRaisedAsync(id);
            _localityDetailsUC.SaveLocalityEventRaised += (sender, localityFromForm) => OnSaveLocalityEventRaisedAsync(localityFromForm);

            _deleteConfirmView.DeleteConfirmViewOKEventRaised += (sender, id) => OnDeleteConfirmViewOKEventRaisedAsync(id);
        }

        #endregion
    }
}
