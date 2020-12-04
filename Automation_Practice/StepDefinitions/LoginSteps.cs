using System;
using TechTalk.SpecFlow;
using Automation_Practice.Pages;
using Automation_Practice.Common;
using NUnit.Framework;

namespace Automation_Practice.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");

        [Given(@"I navigate to the automation practice page")]
        public void GivenINavigateToTheAutomationPracticePage()
        {
            LoginPage obj = new LoginPage(browser);
            Sleep.Wait(1);
            string homepage = Configuration.Instance.PracticeWebsite;
            browser.Navigate(homepage);
        }
        
        [Given(@"I see the automation practice sign in page is loaded")]
        public void GivenISeeTheAutomationPracticeSignInPageIsLoaded()
        {
            LoginPage obj = new LoginPage(browser);
            obj.IsSignInButton();
            obj.ClickSignInButton();
        }
        
        [When(@"I sign in the automation practice page by end user")]
        public void WhenISignInTheAutomationPracticePageByEndUser()
        {
            LoginPage obj = new LoginPage(browser);
            obj.SetEmailValue();
            obj.SetPasswordValue();
            obj.ClickSubmitSignIn();
        }
        
        [Then(@"I see the user name is displayed in the home page")]
        public void ThenISeeTheUserNameIsDisplayedInTheHomePage()
        {
            LoginPage obj = new LoginPage(browser);
            Assert.IsTrue(obj.IsSignOut());
        }
    }
}
