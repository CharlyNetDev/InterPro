using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace InterProHerramientas.LogIn
{
    public class ElementosMenuPrincipal
    {
        public IWebElement ElementoMenu(IWebDriver driver, int i)
        {
            IWebElement elementoMenu = driver.FindElement(By.XPath("html/body/div[2]/ul/li[" + i + "]/a"));
            return elementoMenu;
        }

        public IWebElement ElementoSubMenuPlanDeServicio(IWebDriver driver)
        {
            IWebElement elementoMenu = driver.FindElement(By.Id("sub-opt-planes-servicios"));
            return elementoMenu;

            //*[@id="sub-opt-planes-servicios"]
        }
    }
}
