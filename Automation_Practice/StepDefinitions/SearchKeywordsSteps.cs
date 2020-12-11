using System;
using TechTalk.SpecFlow;
using Automation_Practice.Pages;
using Automation_Practice.Common;
using NUnit.Framework;

namespace Automation_Practice.StepDefinitions
{
    [Binding]
    public class SearchKeywordsSteps
    {
        readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");
        [When(@"I select ""(.*)"" below")]
        public void WhenISelectBelow(string keyword)
        {
            AutomationPracticeHomePage obj = new AutomationPracticeHomePage(browser);
            obj.SearchKeyword(keyword);
        }
        
        [Then(@"I see the ""(.*)"" dislayed")]
        public void ThenISeeTheDislayed(string keyword)
        {
            AutomationPracticeHomePage obj = new AutomationPracticeHomePage(browser);
            string eSearch = obj.GetSearchValue();
            string aSearch = "SEARCH" + "\"" + keyword.ToUpper() + "\"";
            Assert.AreEqual(eSearch, aSearch);           
        }
    }
}
