using OpenQA.Selenium;
using Automation_Practice.Common;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;


namespace Automation_Practice.Pages
{
    public class GoogleSearchPage        
    {
        public GoogleSearchPage(Browser browser) 
        {
            PageFactory.InitElements(browser.Driver, this);
        }

        readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");

        /// <summary>
        /// The search text box
        /// </summary>
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement search_text = null;

        //[FindsBy(How = How.Name, Using = "btnI")]
        //private IWebElement elem_submit_button = null;

        [FindsBy(How = How.Id, Using = "hplogo")]
        private IWebElement elem_logo_img = null;

        public void SetSearchValue(string vSearch)
        {
            search_text.SendKeys(vSearch);
            search_text.SendKeys(Keys.Return);
        }

        // Checks whether the Logo is displayed properly or not
        public bool getWebPageLogo()
        {
            return elem_logo_img.Displayed;
        }

    }
}
