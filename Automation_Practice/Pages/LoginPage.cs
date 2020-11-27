using System;
using System.Collections.Generic;
using System.Text;
using Automation_Practice.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace Automation_Practice.Pages
{
    public class LoginPage
    {
        public IWebDriver browser;

        public string AssessToTheAutomationPracticePage(string url)
        {
            browser = new ChromeDriver();
            return browser.Url = url;
        }

        public IWebElement SignInButton()
        {
            return browser.FindElement(By.ClassName("login"));
        }

        public IWebElement Email()
        {
            return browser.FindElement(By.Id("email"));
        }

        public IWebElement Password()
        {
            return browser.FindElement(By.Id("passwd"));
        }

        public IWebElement SignIn()
        {
            return browser.FindElement(By.Id("SubmitLogin"));
        }

        public IWebElement SignOut()
        {
            return browser.FindElement(By.ClassName("logout"));
        }

        //public IWebElement UserName()
        //{
        //   // return browser.FindElement(By.XPath("//*[@id="header"]/div[2]/div/div/nav/div[1]/a/span"));
        //}

        public bool IsSignInButton()
        {
            try
            {
                return SignInButton().Displayed;
            }
            catch
            {
                return false;
            }
        }

        public void ClickSignInButton()
        {
            SignInButton().Click();
        }

        public void SetEmailValue()
        {
            Email().SendKeys("vongoclien@gmail.com");
        }

        public void SetPasswordValue()
        {
            Password().SendKeys("lienvo@123");
        }

        public void ClickSignIn()
        {
            SignIn().Click();
        }

        public bool IsSignOut()
        {
            try
            {
                return SignOut().Displayed;
            }
            catch
            {
                return false;
            }
        }

    }
}
