using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAutomationProject.Pages
{
    public class EmailPage
    {
        IWebDriver driver;

        public EmailPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsInbox()
        {
            // Check Url contains Inbox
            return driver.Url.Contains("inbox");
        }

    }
}
