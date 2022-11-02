using Services.ReportService;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using UI.Views;

namespace UI.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        #region Members

        readonly IMainView _mainView;
        readonly IAgencyPresenter _agencyPresenter;
        IErrorMessageView _errorMessageView;
        readonly ILocalityPresenter _localityPresenter;
        readonly ISettingsPresenter _settingsPresenter;

        Panel mainPanel;
        Panel rightPanel;

        #endregion

        #region Ctor

        public MainPresenter(
            IMainView mainView,
            IAgencyPresenter agencyPresenter,
            IErrorMessageView errorMessageView,
            ILocalityPresenter localityPresenter,
            ISettingsPresenter settingsPresenter)
        {
            _mainView = mainView;
            _agencyPresenter = agencyPresenter;
            _errorMessageView = errorMessageView;
            _localityPresenter = localityPresenter;
            _settingsPresenter = settingsPresenter;

            mainPanel = mainView.GetMainPanel();
            rightPanel = mainView.GetDetailsPanel();

            SubscribeToEventsSetup();
        }

        #endregion

        public IMainView GetMainView() => _mainView;

        #region Helpers

        private void OnAboutMenuClickEventRaised(object sender, EventArgs e)
        {
            Form aboutForm = new About();
            aboutForm.Show();
        }

        private void OnExitMenuClickEventRaised(object sender, EventArgs e) => Application.Exit();

        private void OnExportAgenciesСsvMenuClickEventRaised(object sender, EventArgs e)
        {
            var saver = ReportBuilderFactory.GetCsvReportBuilder();
            StringBuilder sb = null;

            try
            {
                sb = saver.BuildAgenciesCsvReport();
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Agencies service", ex.Message);
            }

            var sfd = new SaveFileDialog() { Filter = "CSV (.csv)|*.csv", ValidateNames = true };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8);
                sw.WriteLine(sb);
                sw.Close();
                sw.Dispose();
                MessageBox.Show("Export of agencies completed.");
            }
        }

        private void OnExportLocalitiesСsvMenuClickEventRaised(object sender, EventArgs e)
        {
            var saver = ReportBuilderFactory.GetCsvReportBuilder();
            StringBuilder sb = null;

            try
            {
                sb = saver.BuildLocalitiesCsvReport();
            }
            catch (Exception ex)
            {
                _errorMessageView.ShowErrorMessageView("Localities service", ex.Message);
            }

            var sfd = new SaveFileDialog() { Filter = "CSV (.csv)|*.csv", ValidateNames = true };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8);
                sw.WriteLine(sb);
                sw.Close();
                sw.Dispose();
                MessageBox.Show("Export of localities completed.");
            }
        }

        private void SetUpMainView(UserControl mainUC, UserControl rightUC = null)
        {
            mainPanel = _mainView.GetMainPanel();
            mainPanel.Controls.Clear();
            rightPanel = _mainView.GetDetailsPanel();
            rightPanel.Controls.Clear();

            mainUC.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(mainUC);

            if (rightUC != null) rightPanel.Controls.Add(rightUC);
        }

        private void SubscribeToEventsSetup()
        {
            /*Main View*/
            _mainView.AboutMenuClickEventRaised += OnAboutMenuClickEventRaised;
            _mainView.AgenciesMenuClickEventRaised += (sender, e) => SetUpMainView(
                (UserControl)_agencyPresenter.GetAgenciesUC(), (UserControl)_agencyPresenter.GetAgencyDetailsUC());
            _mainView.ExitMenuClickEventRaised += OnExitMenuClickEventRaised;
            _mainView.ExportAgenciesСsvMenuClickEventRaised += OnExportAgenciesСsvMenuClickEventRaised;
            _mainView.ExportLocalitiesСsvMenuClickEventRaised += OnExportLocalitiesСsvMenuClickEventRaised;
            _mainView.LocalitiesMenuClickEventRaised += (sender, e) => SetUpMainView(
                (UserControl)_localityPresenter.GetLocalitiesUC(), (UserControl)_localityPresenter.GetLocalityDetailsUC());
            _mainView.MainViewLoadedEventRaised += (sender, e) => SetUpMainView((UserControl)_settingsPresenter.GetSettingsUC(), null);
            _mainView.NewFileMenuClickEventRaised += OnNewFileMenuClickEventRaised;
            _mainView.OpenFileMenuClickEventRaised += OnOpenFileMenuClickEventRaised;
            _mainView.SettingsMenuClickEventRaised += (sender, e) => SetUpMainView((UserControl)_settingsPresenter.GetSettingsUC(), null);
            /*Agencies UC*/
            _agencyPresenter.GetAgenciesUC().AgencyRowChanged += (sender, e) => UpdateRightPanel((UserControl)_agencyPresenter.GetAgencyDetailsUC(e));
            /*Localities UC*/
            _localityPresenter.GetLocalitiesUC().LocalityRowChanged += (sender, e) => UpdateRightPanel((UserControl)_localityPresenter.GetLocalityDetailsUC(e));
        }

        private void OnNewFileMenuClickEventRaised(object sender, EventArgs e) => Process.Start("notepad.exe");

        private void OnOpenFileMenuClickEventRaised(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { InitialDirectory = "c:\\", FilterIndex = 2, RestoreDirectory = true };

            if (openFileDialog.ShowDialog() == DialogResult.OK) Process.Start(openFileDialog.FileName);
        }

        private void UpdateRightPanel(UserControl rightUC)
        {
            rightPanel = _mainView.GetDetailsPanel();
            rightPanel.Controls.Clear();
            rightPanel.Controls.Add(rightUC);
        }

        #endregion   
    }
}
