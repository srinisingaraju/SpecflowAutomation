using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAutomationProject.Pages
{
    public class SignInPasswordPage
    {
        IWebDriver driver;

        public SignInPasswordPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Password tetx box
        By Password = By.Name("password");
        // Next button
        By Next = By.Id("passwordNext");


        public bool IsSignInPasswordPage()
        {            
            return ((Utils.Utils.WaitForElement(Password) != null) &&
                    (Utils.Utils.WaitForElement(Next) != null)
                   );
        }

        public void EnterPassword()
        {
            Utils.Utils.WaitForElement(Password).SendKeys(ConfigurationManager.AppSettings.Get("Password"));
        }

        public void ClickNext()
        {
            Utils.Utils.WaitandClickElement(Next);
        }

    }
}
