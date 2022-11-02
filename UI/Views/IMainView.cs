using System;
using System.Windows.Forms;

namespace UI.Views
{
    public interface IMainView
    {
        event EventHandler AboutMenuClickEventRaised;
        event EventHandler AgenciesMenuClickEventRaised;
        event EventHandler ExitMenuClickEventRaised;
        event EventHandler ExportAgenciesСsvMenuClickEventRaised;
        event EventHandler ExportLocalitiesСsvMenuClickEventRaised;
        event EventHandler LocalitiesMenuClickEventRaised;
        event EventHandler MainViewLoadedEventRaised;
        event EventHandler NewFileMenuClickEventRaised;
        event EventHandler OpenFileMenuClickEventRaised;
        event EventHandler SettingsMenuClickEventRaised;

        Panel GetMainPanel();

        Panel GetDetailsPanel();
    }
}
