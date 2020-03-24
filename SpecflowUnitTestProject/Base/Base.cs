using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SpecflowAutomationProject.Base
{
    public static class Base
    {
        public static IWebDriver driver;

        public static string URL = ConfigurationManager.AppSettings.Get("URL");

        public static string EmailID = ConfigurationManager.AppSettings.Get("EmailID");

        public static string Password = ConfigurationManager.AppSettings.Get("Password");

        public static void SetupDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }
    }
}
