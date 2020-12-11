using OpenQA.Selenium;
using Automation_Practice.Common;
using SeleniumExtras.PageObjects;

namespace Automation_Practice.Pages
{
    public class LoginPage
    {
        public LoginPage(Browser browser) 
        {
            PageFactory.InitElements(browser.Driver, this);
        }

        /// <summary>
        /// The sign in the practice automation page
        /// </summary>
        [FindsBy(How = How.ClassName, Using = "login")]
        private IWebElement _login = null;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement _email = null;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement _SubmitLogin = null;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement _passwd = null;

        [FindsBy(How = How.ClassName, Using = "logout")]
        private IWebElement _logout = null;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[2]/div/div/nav/div[1]/a/span")]
        private IWebElement _username = null;


        public bool IsSignInButton()
        {
            try
            {
                return  _login.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public void SetEmailandPassword()
        {
            _login.Click();
        _email.SendKeys("vongoclien@gmail.com");
            _passwd.SendKeys("lienvo@123");
        }

        public void ClickSubmitSignIn()
        {
            _SubmitLogin.Click();
            Sleep.Wait(1);
        }

        public bool IsSignOut()
        {
            try
            {
                return _logout.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public string UserName()
        {
            return _username.Text;
        }
    }
}
