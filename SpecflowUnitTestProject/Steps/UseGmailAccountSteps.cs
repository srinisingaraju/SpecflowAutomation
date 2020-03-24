using System;
using TechTalk.SpecFlow;
using SpecflowAutomationProject.Pages;
using SpecflowAutomationProject.Base;
using OpenQA.Selenium;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecflowAutomationProject.Utils;
using System.Diagnostics;
using System.Threading;

namespace SpecflowUnitTestProject.Steps
{
    [Binding]
    public class UseGmailAccountSteps
    {
        // Base.driver is initialised in Hooks             

        HomePage homePage = new HomePage(Base.driver);
        SignInEmailPage signInPage = new SignInEmailPage(Base.driver);
        SignInPasswordPage signInPasswordPage = new SignInPasswordPage(Base.driver);
        EmailPage emailInbox = new EmailPage(Base.driver);

        [Given(@"I navigate to Gmail")]
        public void GivenINavigateToGmail()
        {
            homePage.NavigateToGmailHomePage();

            Assert.IsTrue(homePage.IsGmailPage());
         }
        
        [When(@"I navigate to Sign In")]
        public void WhenINavigateToSignIn()
        {
            if (homePage.IsGmailPage())
            {
                homePage.ClickSignIn();
            }

            // Base.driver.SwitchTo().Window(Base.driver.WindowHandles.Last());
            // Thread.Sleep(2000);

            // Base.driver.SwitchTo().ActiveElement();
             Utils.SwitchToWindow(driver => driver.Url.Contains("accounts.google.com"));            

            // Thread.Sleep(1000);

            Assert.IsTrue(signInPage.IsSignInEmailPage());
        } 
        
        [When(@"I Provide Email ID")]
        public void WhenIProvideEmailID()
        {
            if (signInPage.IsSignInEmailPage())
            {
                signInPage.EnterEmailId();
                // Thread.Sleep(1000);
                signInPage.ClickNext();
            }

            Assert.IsTrue(signInPasswordPage.IsSignInPasswordPage());
        }
        
        [When(@"I Provide Password")]
        public void WhenIProvidePassword()
        {
            Utils.SwitchToWindow(driver => driver.Url.Contains("accounts.google.com"));

            Thread.Sleep(1000);

            if (signInPasswordPage.IsSignInPasswordPage())
            {
                signInPasswordPage.EnterPassword();
                Thread.Sleep(1000);
                signInPasswordPage.ClickNext();
            }
        }
        
        [Then(@"I should login to Gmail account")]
        public void ThenIShouldLoginToGmailAccount()
        {
            Utils.SwitchToWindow(driver => driver.Url.Contains("mail.google.com"));

            Thread.Sleep(3000);

            Assert.IsTrue(emailInbox.IsInbox());
        }
    }}
