using Services.SettingsService;
using System.Configuration;
using System.Windows.Forms;
using UI.Views.UserControls;

namespace UI.Presenters
{
    public class SettingsPresenter : ISettingsPresenter
    {
        readonly ISettingsUC _settingsUC;

        public SettingsPresenter(ISettingsUC settingsUC)
        {
            _settingsUC = settingsUC;
            SubscribeToEvents();
        }

        public ISettingsUC GetSettingsUC()
        {
            var settingsDto = new SettingsDto
            {
                BaseUrl = ConfigurationManager.AppSettings["baseUrl"],
                ButtonsGetInTouchSelector = ConfigurationManager.AppSettings["buttonsGetInTouchSelector"],
                PropertiesForRentSelector = ConfigurationManager.AppSettings["propertiesForRentSelector"],
                PropertiesSoldSelector = ConfigurationManager.AppSettings["propertiesSoldSelector"],
                ThreadsNumber = int.Parse(ConfigurationManager.AppSettings["numberOfParallellyParsersToPerform"])
            };

            _settingsUC.SetUpControls(settingsDto);

            return _settingsUC;
        }

        private void OnSaveSettingsButtonClicked(SettingsDto settingsDto)
        {
            var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("baseUrl");
            config.AppSettings.Settings.Remove("buttonsGetInTouchSelector");
            config.AppSettings.Settings.Remove("propertiesForRentSelector");
            config.AppSettings.Settings.Remove("propertiesSoldSelector");
            config.AppSettings.Settings.Remove("numberOfParallellyParsersToPerform");

            config.AppSettings.Settings.Add("baseUrl", settingsDto.BaseUrl);
            config.AppSettings.Settings.Add("buttonsGetInTouchSelector", settingsDto.ButtonsGetInTouchSelector);
            config.AppSettings.Settings.Add("propertiesForRentSelector", settingsDto.PropertiesForRentSelector);
            config.AppSettings.Settings.Add("propertiesSoldSelector", settingsDto.PropertiesSoldSelector);
            config.AppSettings.Settings.Add("numberOfParallellyParsersToPerform", settingsDto.ThreadsNumber.ToString());

            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void SubscribeToEvents() => _settingsUC.SaveSettingsButtonClicked += (sender, e) => OnSaveSettingsButtonClicked(e);
    }
}
