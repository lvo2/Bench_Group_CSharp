using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Automation_Practice.Common;

namespace Automation_Practice.Hooks
{
    [Binding]
    public class MainHook
    {
        // View Hook feature http://go.specflow.org/doc-hooks
        public IWebDriver browser;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            // refer to https://www.toolsqa.com/specflow/scenariocontext-current-in-specflow/
            Browser browser = BrowserFactory.Instance.InitBrowser(Configuration.Instance.Browser);
            ScenarioContext.Current.Add("key_browser", browser);
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser browser;
            ScenarioContext.Current.TryGetValue<Browser>("key_browser", out browser);
            if (browser != null)
            {
                browser.Close();
            }
        }
    }
}
