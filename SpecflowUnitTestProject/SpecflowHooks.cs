using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowAutomationProject
{
    [Binding]
    public sealed class SpecflowHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {            
            Base.Base.SetupDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {      
            // Don't quit the driver as we want to see the Gmail login
            // Base.Base.QuitDriver();
        }
    }
}
