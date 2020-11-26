using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Automation_Practice.Hooks
{
    [Binding]
    public class MainHook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public IWebDriver browser;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            //if (browser == null)
            //{
            //    browser = new ChromeDriver();
            //}
            //else { throw new Exception("Couldn't initialize the driver"); }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            //if (browser != null)
            //{
            //    browser.Quit();
            //}
            //else throw new Exception("There was an error while trying to close the driver");
        }
    }
}
