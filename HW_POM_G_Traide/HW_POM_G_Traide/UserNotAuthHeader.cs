using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_POM_G_Traide
{

    public class UserNotAuthHeader : Header
    {
        IWebDriver _driver;
        public UserNotAuthHeader(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _signIn = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[2]/div/div/a");

        public UserNotAuthHeader ClickAuthorizationButton()
        {
            _driver.FindElement(_signIn).Click();
            return this;
        }
    }
}
