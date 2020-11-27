using System;
using System.Collections.Generic;
using System.Text;
using Automation_Practice.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


namespace Automation_Practice.Pages
{
    public class GoogleSearchPage         
    {
        public IWebDriver browser;    

        public string GoToGooglePage(string url)
        {
            browser = new ChromeDriver();
            return browser.Url = url;
        }

        public IWebElement GetTxtSearch()
        {
            return browser.FindElement(By.Name("q"));
        }

        public void FillTxtSearch(string search)
        {
            GetTxtSearch().SendKeys(search);
        }

        public IWebElement SearchButton()
        {
            return browser.FindElements(By.Name("btnK"))[1];
        }

        public void SearchButtonClick()
        {
            SearchButton().Click();
        }

        public IWebElement GoogleLogoImage()
        {
            return browser.FindElement(By.Id("hplogo"));
        }

        public void GoogleLogoImageClick()
        {
            GoogleLogoImage().Click();
        }

        public bool IsGooglePage()
        {           
            try
            {                    
                return GoogleLogoImage().Displayed;
            }
            catch
            {
                return false;
            }            
        }

        public void CloseBrowser()
        {
            browser.Close();
        }
    }
}
