using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace Automation_Practice.StepMethods
{
    [Binding]
    public class SearchGoogleSteps
    {
        IWebDriver driver;
        [Given(@"I navigate to the Google page")]
        public void GivenINavigateToTheGooglePage()
        {
            //ScenarioContext.Current.Pending();
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

        }

        [Given(@"I see the page loaded")]
        public void GivenISeeThePageLoaded()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter keyword search ""(.*)"" in the Search Text box")]
        public void WhenIEnterKeywordSearchInTheSearchTextBox(string sKeyword)
        {
            //ScenarioContext.Current.Pending();
            driver.FindElement(By.Name("q")).SendKeys(sKeyword);
            driver.FindElement(By.Id("hplogo")).Click();
        }
        
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            driver.FindElements(By.Name("btnK"))[1].Click();
        }
        
        [Then(@"Search items shows the items related to SpecFlow")]
        public void ThenSearchItemsShowsTheItemsRelatedToSpecFlow()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
