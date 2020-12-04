using TechTalk.SpecFlow;
using Automation_Practice.Pages;
using Automation_Practice.Common;

namespace Automation_Practice.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps
    {
        readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");

        [Given(@"I navigate to the Google page")]
        public void GivenINavigateToTheGooglePage()
        {
            GoogleSearchPage obj = new GoogleSearchPage(browser);
            string GoogleURL = Configuration.Instance.GoogleWebsite;
            browser.Navigate(GoogleURL);
            Sleep.Wait(1);            
        }        
        [Given(@"I see the page loaded")]
        public void GivenISeeThePageLoaded()
        {
            //Assert.IsTrue(IsGooglePage());
        }        
        [When(@"I enter keyword search ""(.*)"" in the Search Text box")]
        public void WhenIEnterKeywordSearchInTheSearchTextBox(string keyword)
        {
            GoogleSearchPage obj = new GoogleSearchPage(browser);
            obj.SetSearchValue(keyword);
        }        
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            //SearchButtonClick();
        }        
        [Then(@"Search shows the items related to SpecFlow")]
        public void ThenSearchShowsTheItemsRelatedToSpecFlow()
        {
            //CloseBrowser();
        }
    }
}
