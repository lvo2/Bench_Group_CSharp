using OpenQA.Selenium;
using Automation_Practice.Common;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System;

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

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement _addtocart = null;

        //[FindsBy(How = How.ClassName, Using = "product-image-container")]
        // private IWebElement _clickimage = null;




        public void ClickWomenButton()
        {
            _women.Click();
        }

        public void ClickDressButton()
        {
            _dresses.Click();
        }

        public void AddToCart()
        {
            // _addtocart.Click();
        }
        public void SelectADress()
        {
            _women.Click();
            Sleep.Wait(2);
            _dresses.Click();
            var driver = browser.Driver;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("scroll(0, 550)");
            var element = driver.FindElement(By.ClassName("product_img_link"));
            element.Click();
            Sleep.Wait(3);
             driver.FindElement(By.ClassName("fancybox-skin"));
            //driver.SwitchTo().Frame(simFrame);
            //driver.SwitchTo().Frame(1);
        }
    }
}
