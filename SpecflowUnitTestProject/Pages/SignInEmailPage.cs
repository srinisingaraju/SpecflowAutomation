using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAutomationProject.Pages
{
    public class SignInEmailPage
    {
        IWebDriver driver;

        public SignInEmailPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // "Sign In"
        By Email = By.Id("identifierId");
        // Next Button        
        By Next = By.Id("identifierNext");
        // Choose an account page
        By ChooseAnAccount = By.XPath(@"//*[@id=""headingText""]/span");

        public bool IsSignInEmailPage()
        {            
            return ((Utils.Utils.WaitForElement(Email) != null) &&
                    (Utils.Utils.WaitForElement(Next) != null)
                   );
        }

        public void EnterEmailId()
        {        
            Utils.Utils.WaitForElement(Email).SendKeys(Base.Base.EmailID);
        }

        public void ClickNext()
        {
            Utils.Utils.WaitandClickElement(Next);
        }
    }
}
