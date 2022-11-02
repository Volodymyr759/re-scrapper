using Services.SettingsService;
using System;

namespace UI.Views.UserControls
{
    public interface ISettingsUC
    {
        event EventHandler<SettingsDto> SaveSettingsButtonClicked;

        void SetUpControls(SettingsDto settingsDto);
    }
}
