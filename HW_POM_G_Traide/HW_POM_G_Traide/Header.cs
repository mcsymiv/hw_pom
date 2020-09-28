using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_POM_G_Traide
{
    public class Header
    {
        //IWebDriver _driver;
        //public Header(IWebDriver driver)
        //{
        //    this._driver = driver;
        //}
        By _mainLogo = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[2]/div[3]");
        By _menuButton = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[2]/div[3]");
        By _stockLink = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[1]/div[2]/ul/li[1]/a");
        By _newsLink = By.CssSelector("#yw0 > li:nth-child(2) > a");
        By _grainPrice = By.CssSelector("#yw0 > li:nth-child(3) > a");
    }
}
