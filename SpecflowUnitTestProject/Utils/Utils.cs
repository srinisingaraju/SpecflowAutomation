
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Linq.Expressions;

namespace SpecflowAutomationProject.Utils
{
    public static class Utils
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static IWebElement WaitForElement(By by)
        {
            int timeOutInSeconds = 60;
            return FindElement(Base.Base.driver, by, timeOutInSeconds);
        }

        public static void WaitandClickElement(By by)
        {
            WaitForElement(by).Click();
        }

        public static void SwitchToWindow(Expression<Func<IWebDriver, bool>> predicateExp)
        {
            var predicate = predicateExp.Compile();
            foreach (var handle in Base.Base.driver.WindowHandles)
            {
                Base.Base.driver.SwitchTo().Window(handle);
                if (predicate(Base.Base.driver))
                {
                    return;
                }
            }

            throw new ArgumentException(string.Format("Unable to find window with condition: '{0}'", predicateExp.Body));
        }        
    }
}
