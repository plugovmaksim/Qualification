using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using Reqnroll;

namespace ExampleProject.Framework.Hooks
{
    [Binding]
    internal class Hooks
    {
        private readonly Browser browser = AqualityServices.Browser;
        private static readonly JsonSettingsFile settings = new("config.json");
        private readonly string url = "https://the-internet.herokuapp.com/";

        [BeforeScenario]
        public void Setup()
        {
            browser.Maximize();
            browser.GoTo(url);
        }

        [AfterScenario]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}