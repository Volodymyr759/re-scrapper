using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Services.AgencyService;
using Services.LocalityService;
using Services.SettingsService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.AgencyParseService
{
    public class SeleniumAgencyParser : IAgencyParser
    {
        #region Members

        IWebDriver _driver;
        readonly SettingsDto _settingsDto;
        WebDriverWait _wait;

        #endregion

        #region Ctor

        public SeleniumAgencyParser(SettingsDto settingsDto)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
            chromeOptions.AddExcludedArgument("enable-automation");
            chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            chromeOptions.AddArguments("--disable-infobars");
            _driver = new ChromeDriver("C:\\Users\\user\\source\\repos\\REScraper\\UI\\bin\\Debug", chromeOptions);
            _settingsDto = settingsDto;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));
        }

        #endregion

        public IEnumerable<ParseAgencyDto> ParseAgenciesFromRE(IEnumerable<LocalityDto> localities)
        {
            var agenciesFromScraper = new List<ParseAgencyDto>();

            foreach (var locality in localities) agenciesFromScraper.AddRange(SearchAgenciesByLocality(locality));

            _driver.Quit();

            return agenciesFromScraper.Distinct().ToList();
        }

        #region Helpers

        private List<ParseAgencyDto> SearchAgenciesByLocality(LocalityDto locality)
        {
            var results = new List<ParseAgencyDto>();
            int page = 1;
            int parseOutput;
            string region = locality.Suburb.Replace(" ", "-").ToLower() + "-" +
                    locality.State.ToLower() + "-" +
                    locality.Postcode;
            List<IWebElement> buttonsGetInTouch;
            List<IWebElement> propertiesSoldElements;
            List<IWebElement> propertiesForRentElements;
            try
            {
                while (true)
                {
                    var regionUrl = string.Format("{0}{1}", _settingsDto.BaseUrl, region);

                    if (page > 1) regionUrl = string.Format("{0}/?page={1}", regionUrl, page);

                    _driver.Navigate().GoToUrl(regionUrl);

                    _driver.Manage().Cookies.DeleteCookieNamed("Country");

                    _driver.Manage().Cookies.AddCookie(new Cookie("Country", "US"));

                    if (IsElementExists("body>div>div.card"))
                    {
                        try
                        {
                            var challengeString = _driver.FindElement(By.Id("challengeQuestion")).Text;
                            var answerField = _driver.FindElement(By.Id("challengeAnswer"));
                            answerField.SendKeys(challengeString);
                            _driver.FindElement(By.ClassName("button")).Click();
                        }
                        catch
                        {
                        }
                    }

                    buttonsGetInTouch = _driver.FindElements(By.CssSelector(_settingsDto.ButtonsGetInTouchSelector)).ToList();

                    if (buttonsGetInTouch.Count > 0)
                    {
                        for (int i = 0; i < buttonsGetInTouch.Count; i++)
                        {
                            buttonsGetInTouch = _driver.FindElements(By.CssSelector(_settingsDto.ButtonsGetInTouchSelector)).ToList();

                            var agency = new ParseAgencyDto { LocalityId = locality.Id, LastUpdatedOn = DateTime.Now };

                            propertiesSoldElements = _driver.FindElements(By.CssSelector(_settingsDto.PropertiesSoldSelector)).ToList();

                            if (int.TryParse(propertiesSoldElements[i].Text, out parseOutput)) agency.PropertiesSold = parseOutput;

                            propertiesForRentElements = _driver.FindElements(By.CssSelector(_settingsDto.PropertiesForRentSelector)).ToList();

                            if (int.TryParse(propertiesForRentElements[i].Text, out parseOutput)) agency.PropertiesForRent = parseOutput;

                            agency = GetAgencyFromPage(agency, buttonsGetInTouch[i]);

                            if (!string.IsNullOrEmpty(agency.Name)) results.Add(agency);

                            _driver.Navigate().Back();
                        }

                        page++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch
            { }

            return results;
        }

        private ParseAgencyDto GetAgencyFromPage(ParseAgencyDto agency, IWebElement button)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            button.Click();
            _wait.Until(webDriver => webDriver.FindElement(By.CssSelector("#app>section>header>div>section>div>h1")).Displayed);

            agency.LogoBackgroundColor = (string)js.ExecuteScript("return document.querySelector('.agency-logo--header').style.backgroundColor");
            agency.Logo = _driver.FindElement(By.ClassName("agency-logo__image")).GetAttribute("src");
            agency.Name = IsElementExists("#app>section>header>div>section>div>h1") ?
                    _driver.FindElement(By.CssSelector("#app>section>header>div>section>div>h1")).Text : null;
            agency.FullAddress = IsElementExists("#app>section>header>div>section>div>address") ? _driver.FindElement(By.CssSelector("#app>section>header>div>section>div>address")).Text : null;
            agency.WebSite = IsElementExists("#app>section>header>div>section>div>div.agency-profile-header__social-links>a") ? _driver.FindElement(By.CssSelector("#app>section>header>div>section>div>div.agency-profile-header__social-links>a")).GetAttribute("href").ToString() : null;
            agency.FacebookPage = IsElementExists("a.agency-profile-header__social-link") ? _driver.FindElement(By.CssSelector("a.agency-profile-header__social-link")).GetAttribute("href").ToString() : null;

            var element = _driver.FindElement(By.CssSelector("#app>section>header>div>section>div>div.agency-profile-header__ctas>a:nth-child(1)"));
            element.Click();
            agency.Phone = "Tel: " + element.Text;

            return agency;
        }

        private bool IsElementExists(string selector)
        {
            try
            {
                return _driver.FindElement(By.CssSelector(selector)) != null;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
