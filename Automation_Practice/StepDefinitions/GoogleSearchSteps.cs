using System;
using TechTalk.SpecFlow;
using Automation_Practice.Pages;
using NUnit.Framework;
using System.Threading;

namespace Automation_Practice.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps: GoogleSearchPage
    {
        [Given(@"I navigate to the Google page")]
        public void GivenINavigateToTheGooglePage()
        {
            GoToGooglePage("https://www.google.com");            
        }        
        [Given(@"I see the page loaded")]
        public void GivenISeeThePageLoaded()
        {
            Assert.IsTrue(IsGooglePage());
        }        
        [When(@"I enter keyword search ""(.*)"" in the Search Text box")]
        public void WhenIEnterKeywordSearchInTheSearchTextBox(string keyword)
        {
            FillTxtSearch(keyword);
            //GoogleLogoImageClick();
        }        
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            SearchButtonClick();
        }        
        [Then(@"Search shows the items related to SpecFlow")]
        public void ThenSearchShowsTheItemsRelatedToSpecFlow()
        {
            Thread.Sleep(2000);
            CloseBrowser();
        }
    }
}
