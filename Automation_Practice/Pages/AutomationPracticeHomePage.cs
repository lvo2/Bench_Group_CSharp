using OpenQA.Selenium;
using Automation_Practice.Common;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System;
using OpenQA.Selenium.Interactions;

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
            var driver = browser.Driver;
            Sleep.Wait(4);
            var vframe = driver.FindElement(By.ClassName("fancybox-skin")).FindElement(By.TagName("iframe"));
            driver.SwitchTo().Frame(vframe);

            //Add the selected item to cart
            var vAddToCart = driver.FindElement(By.Id("product")).FindElement(By.ClassName("primary_block")).FindElement(By.ClassName("pb-right-column")).FindElement(By.Id("buy_block")).FindElement(By.ClassName("box-info-product")).FindElement(By.ClassName("box-cart-bottom")).FindElement(By.Id("add_to_cart"));
            vAddToCart.FindElement(By.Name("Submit")).Click();

            //Switch to new pop up
            //driver.SwitchTo().ActiveElement();
            Sleep.Wait(3);

            //Continue shopping
            driver.FindElement(By.Id("layer_cart")).FindElement(By.ClassName("clearfix")).FindElement(By.ClassName("button-container")).FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span")).Click();

            Sleep.Wait(2);
        }
        public void SelectADress()
        {
            _women.Click();
            Sleep.Wait(2);
            _dresses.Click();
            var driver = browser.Driver;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("scroll(0, 550)");
            Sleep.Wait(1);
            var element = driver.FindElement(By.ClassName("product_img_link"));
            element.Click();
           
            Sleep.Wait(2);
        }

        public int NumberItemsInCart() {

            string objectPath = "//*[@id='header']/div[3]/div/div/div[3]/div/a/span[1]";
            Sleep.Wait(1);
            int count = browser.Driver.FindElements(By.XPath(objectPath)).Count;
            return count;

        }
    }
}
