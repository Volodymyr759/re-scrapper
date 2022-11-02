using System;
using System.Windows.Forms;
using UI.Views;

namespace UI
{
    public partial class MainView : Form, IMainView
    {
        #region Members

        public event EventHandler AboutMenuClickEventRaised;
        public event EventHandler AgenciesMenuClickEventRaised;
        public event EventHandler ExitMenuClickEventRaised;
        public event EventHandler ExportAgenciesСsvMenuClickEventRaised;
        public event EventHandler ExportLocalitiesСsvMenuClickEventRaised;
        public event EventHandler LocalitiesMenuClickEventRaised;
        public event EventHandler MainViewLoadedEventRaised;
        public event EventHandler NewFileMenuClickEventRaised;
        public event EventHandler OpenFileMenuClickEventRaised;
        public event EventHandler SettingsMenuClickEventRaised;


        #endregion

        #region Ctor

        public MainView()
        {
            InitializeComponent();
        }

        #endregion

        #region Helpers

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => AboutMenuClickEventRaised(sender, e);

        private void AgencyReportToolStripMenuItem_Click(object sender, EventArgs e) => ExportAgenciesСsvMenuClickEventRaised(sender, e);

        private void AgenciesToolStripMenuItem_Click(object sender, EventArgs e) => AgenciesMenuClickEventRaised(sender, e);

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => ExitMenuClickEventRaised(this, e);

        public Panel GetDetailsPanel() => rightPanel;

        public Panel GetMainPanel() => mainPanel;

        private void LocalitiesToolStripMenuItem_Click(object sender, EventArgs e) => LocalitiesMenuClickEventRaised(sender, e);

        private void LocalityReportToolStripMenuItem_Click(object sender, EventArgs e) => ExportLocalitiesСsvMenuClickEventRaised(sender, e);

        private void MainView_Load(object sender, EventArgs e) => MainViewLoadedEventRaised(this, e);

        private void NewfileToolStripMenuItem_Click(object sender, EventArgs e) => NewFileMenuClickEventRaised(this, e);

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) => OpenFileMenuClickEventRaised(this, e);

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e) => SettingsMenuClickEventRaised(sender, e);

        #endregion
    }
}
