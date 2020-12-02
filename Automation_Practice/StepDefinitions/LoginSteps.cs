using System;
using TechTalk.SpecFlow;
using Automation_Practice.Pages;
using NUnit.Framework;
using System.Threading;

namespace Automation_Practice.StepDefinitions
{
    [Binding]
    public class LoginSteps : LoginPage
    {
        [Given(@"I navigate to the automation practice page")]
        public void GivenINavigateToTheAutomationPracticePage()
        {
            AssessToTheAutomationPracticePage("http://automationpractice.com/");
        }
        
        [Given(@"I see the automation practice sign in page is loaded")]
        public void GivenISeeTheAutomationPracticeSignInPageIsLoaded()
        {
            Assert.IsTrue(IsSignInButton());
        }
        
        [When(@"I sign in the automation practice page by end user")]
        public void WhenISignInTheAutomationPracticePageByEndUser()
        {
            Thread.Sleep(2000);
            ClickSignInButton();
            SetEmailValue();
            SetPasswordValue();
            ClickSignIn();
        }
        
        [Then(@"I see the user name is displayed in the home page")]
        public void ThenISeeTheUserNameIsDisplayedInTheHomePage()
        {
            Assert.IsTrue(IsSignOut());
            Thread.Sleep(2000);
            CloseBrowser();
        }
    }
}
