using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_POM_G_Traide.Test
{
    public class TestConfig
    {
        IWebDriver _driver;
        public TestConfig(IWebDriver driver)
        {
            this._driver = driver;
        }

        public TestConfig SiteConfig()
        {
            _driver.FindElement(By.XPath("/html/body/div/div[2]/button[3]")).Click();
            _driver.FindElement(By.CssSelector("#proceed-link")).Click();
            return this;
        }
    }
}
