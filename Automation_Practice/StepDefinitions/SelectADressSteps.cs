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

        [When(@"I select a dress from the Women collection")]
        public void WhenISelectADressFromTheWomenCollection()
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
