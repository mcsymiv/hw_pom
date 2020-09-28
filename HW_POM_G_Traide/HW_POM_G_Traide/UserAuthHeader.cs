using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_POM_G_Traide
{
    public class UserAuthHeader : Header
    {
        IWebDriver _driver;
        public UserAuthHeader(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By _myProposal = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[2]/div/div/a");
        public By _myCabinet = By.CssSelector("#app > div.page-layout > div.header.transparent > div.container > div.cabinet-links > div > div.head-dropdown > div.button.transparent > a");
    }
}
