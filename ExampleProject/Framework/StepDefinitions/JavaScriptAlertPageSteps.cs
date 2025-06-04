using ExampleProject.Framework.Pages;
using NUnit.Framework;
using Reqnroll;

namespace ExampleProject.Framework.StepDefinitions
{
    [Binding]
    internal class JavaScriptAlertPageSteps
    {
        private JavaScriptAlertPage jsAlertPage = new();

        [When(@"I generate JS alert on the JavaScript Alert Page")]
        public void GenerateJSAlertOnTheJavascriptAlertPage()
        {
            jsAlertPage.ClickJSAlertBtn();
        }

        [Then(@"Success message is displayed on JavaScript Alert Page")]
        public void CheckThatSuccessMessageIsDisplayOnJavaScriptAlertPage()
        {
            Assert.That(jsAlertPage.IsSuccessMessageDisplayed(), Is.True, "Success message is not displayed");
        }
    }
}