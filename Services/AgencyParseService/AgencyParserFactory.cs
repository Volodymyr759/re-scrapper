using Services.SettingsService;

namespace Services.AgencyParseService
{
    public class AgencyParserFactory
    {
        public static IAgencyParser GetSeleniumAgencyParser(SettingsDto settingsDto)
        {
            return new SeleniumAgencyParser(settingsDto);
        }
    }
}
