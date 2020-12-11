using System;
using TechTalk.SpecFlow;
using Automation_Practice.Pages;
using Automation_Practice.Common;
using NUnit.Framework;

namespace Automation_Practice.StepDefinitions
{
    [Binding]
    public class SelectSomeItemsToAddToCartSteps
    {
        readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");

        [When(@"I select a item from the Dresss collection to add to cart")]
        public void WhenISelectAItemFromTheDresssCollectionToAddToCart()
        {
            AutomationPracticeHomePage obj = new AutomationPracticeHomePage(browser);
            obj.SelectADress();
            obj.AddToCart();
        }
        
        [When(@"I select a item from the TShirt collection to add to cart")]
        public void WhenISelectAItemFromTheTShirtCollectionToAddToCart()
        {
            AutomationPracticeHomePage obj = new AutomationPracticeHomePage(browser);
            obj.ClickTShirtButton();
            obj.AddToCart();
        }
        
        [Then(@"I see the item added in the Cart")]
        public void ThenISeeTheItemAddedInTheCart()
        {
            AutomationPracticeHomePage obj = new AutomationPracticeHomePage(browser);
            Assert.AreEqual(obj.NumberItemsInCart(), 1);
        }
    }
}
