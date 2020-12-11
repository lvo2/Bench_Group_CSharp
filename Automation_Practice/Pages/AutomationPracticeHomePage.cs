using OpenQA.Selenium;
using Automation_Practice.Common;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;

namespace Automation_Practice.Pages
{
    [Binding]
    public class AutomationPracticeHomePage
    {
        public AutomationPracticeHomePage(Browser browser)
        {
            PageFactory.InitElements(browser.Driver, this);
        }

        readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");

        /// <summary>
        /// The sign in the practice automation page
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[1]/a")]
        private IWebElement _women = null;

        [FindsBy(How = How.XPath, Using = "//*[@id='categories_block_left']/div/ul/li[2]/a")]
        private IWebElement _dresses = null;

        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[3]/a")]
        private IWebElement _tShirt = null;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li/div/div[1]/div/a[1]")]
        private IWebElement _selectaTShirt = null;

        [FindsBy(How = How.Id, Using = "search_query_top")]
        private IWebElement _search = null;

        [FindsBy(How = How.Name, Using = "submit_search")]
        private IWebElement _submitsearch = null;
        

        public void ClickWomenButton()
        {
            _women.Click();
        }


        public void SearchKeyword(string keyword)
        {
            _search.Click();
            _search.SendKeys(keyword);
            _submitsearch.Click();
            Sleep.Wait(2);
        }

        public string GetSearchValue()
        {
            string vkeyword = browser.Driver.FindElement(By.XPath("//*[@id='center_column']/h1/span[1]")).Text;
            vkeyword = "SEARCH" + vkeyword.ToUpper();
            Sleep.Wait(1);
            return vkeyword;            
        }

        public void ClickTShirtButton()
        {
            _tShirt.Click();
            _selectaTShirt.Click();
            Sleep.Wait(2);
        }

        public void ClickDressButton()
        {
            _dresses.Click();
        }

        public void AddToCart()
        {
            var driver = browser.Driver;
            var vframe = driver.FindElement(By.ClassName("fancybox-skin")).FindElement(By.TagName("iframe"));
            driver.SwitchTo().Frame(vframe);
            driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span")).Click();
            Sleep.Wait(2);
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span")).Click();
        }
        public void SelectADress()
        {
            _women.Click();
            Sleep.Wait(3);
            _dresses.Click();
            var driver = browser.Driver;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("scroll(0, 550)");
            Sleep.Wait(1);
            var element = driver.FindElement(By.ClassName("product_img_link"));
            element.Click();           
            Sleep.Wait(4);
        }

        public int NumberItemsInCart() {
            string objectPath = "//*[@id='header']/div[3]/div/div/div[3]/div/a/span[1]";
            Sleep.Wait(1);
            int count = browser.Driver.FindElements(By.XPath(objectPath)).Count;
            return count;
        }
    }
}
