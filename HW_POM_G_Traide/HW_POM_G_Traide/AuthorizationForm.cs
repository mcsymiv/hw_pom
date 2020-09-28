using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_POM_G_Traide
{
    public class AuthorizationForm
    {
        IWebDriver _driver;
        public AuthorizationForm(IWebDriver driver)
        {
            this._driver = driver;
        }
        By _login = By.Id("login");
        By _password = By.Id("password");
        By _signInButton = By.XPath("/html/body/noindex/div/div[5]/div[3]/div[2]/div[1]/div[1]/fieldset/div[3]/div/input");
        By _registrationLink = By.XPath("/html/body/noindex/div/div[5]/div[3]/div[2]/div[1]/div[3]/div[2]/a[2]");
        By _passwordReset = By.XPath("/html/body/noindex/div/div[5]/div[3]/div[2]/div[1]/div[3]/div[2]/a[1]");

        public AuthorizationForm SubmitFormAuth(string mail, string password)
        {
            _driver.FindElement(_login).SendKeys(mail);
            _driver.FindElement(_password).SendKeys(password);
            _driver.FindElement(_signInButton).Click();
            return this;
        }
    }
}
