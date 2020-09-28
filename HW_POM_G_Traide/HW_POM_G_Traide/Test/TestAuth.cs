using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_POM_G_Traide.Test
{
    [TestFixture]
    public class TestAuth
    {
        IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");

        UserAuthHeader userAuth;
        UserNotAuthHeader userNotAuth;
        AuthorizationForm userAuthForm;
        TestConfig config;

        [SetUp]
        public void OpenGrainTradeSite()
        {
            chrome.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            userAuth = new UserAuthHeader(chrome);
            userNotAuth = new UserNotAuthHeader(chrome);
            userAuthForm = new AuthorizationForm(chrome);
            config = new TestConfig(chrome);
            config.SiteConfig();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            chrome.Manage().Window.Maximize();
        }
        /*
        [OneTimeTearDown]
        public void CloseChromeWindow()
        {
            chrome.Quit();
        }
        */
        [Test]
        public void UserAuthorization()
        {
            userNotAuth.ClickAuthorizationButton();
            userAuthForm.SubmitFormAuth("vladhluzhin@gmail.com", "qazWSXedc");
            // chrome.FindElement(userAuth._myCabinet);
        }
    }
}
