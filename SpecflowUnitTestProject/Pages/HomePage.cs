using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowAutomationProject.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region WebElements Definition

        // Current Url
        // https://www.google.com/intl/en-GB/gmail/about/#

        By ForWork = By.LinkText("For Work");
        By SignIn = By.LinkText("Sign in");
        By CreateAnAccount = By.LinkText("Create an account");

        #endregion

        public void NavigateToGmailHomePage()
        {            
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("URL"));            
        }

        public bool IsGmailPage()
        {
           return ((Utils.Utils.WaitForElement(ForWork) != null) &&
                   (Utils.Utils.WaitForElement(SignIn) != null) &&
                   (Utils.Utils.WaitForElement(CreateAnAccount) != null));
        }

        public void ClickSignIn()
        {
            Utils.Utils.WaitandClickElement(SignIn);
        }
    }
}
