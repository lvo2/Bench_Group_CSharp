using System;
using TechTalk.SpecFlow;
using Automation_Practice.Pages;
using Automation_Practice.Common;
using NUnit.Framework;

namespace Automation_Practice.StepDefinitions
{
    [Binding]
    public class SelectADressSteps
    {
        readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");

        [Given(@"I am logged in to the practice automation page as a customer")]
        public void GivenIAmLoggedInToThePracticeAutomationPageAsACustomer()
        {
            LoginPage obj = new LoginPage(browser);
            Sleep.Wait(1);
            string homepage = Configuration.Instance.PracticeWebsite;
            browser.Navigate(homepage);
            obj.SetEmailandPassword();
            obj.ClickSubmitSignIn();
        }

        [When(@"I select a item from the Women collection to add to cart")]
        public void WhenISelectAItemFromTheWomenCollectionToAddToCart()
        {
            AutomationPracticeHomePage obj = new AutomationPracticeHomePage(browser);
            obj.SelectADress();
            obj.AddToCart();
        }
                     
        [Then(@"I see the dress added in the Cart")]
        public void ThenISeeTheDressAddedInTheCart()
        {
            AutomationPracticeHomePage obj = new AutomationPracticeHomePage(browser);
            Assert.AreEqual(obj.NumberItemsInCart(),1);
        }
    }
}
