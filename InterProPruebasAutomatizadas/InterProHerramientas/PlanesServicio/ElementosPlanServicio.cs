using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace InterProHerramientas.PlanesServicio.Elementos
{
    public class ElementosPlanServicio
    {
        public IWebElement ElementosPlanServicioBotonAgregarPlan(IWebDriver driver)
        {
            IWebElement agregarPlan = null;
            agregarPlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return agregarPlan;
        }
  
        public IWebElement ElementosPlanServiciAgregarPlan(IWebDriver driver)
        {
            IWebElement agregarPlan = null;
            agregarPlan = driver.FindElement(By.Id("btn-crear"));
            return agregarPlan;
        }

        public IWebElement ElementosPlanServicioNombrePlan(IWebDriver driver)
        {
            IWebElement nombrePlan = null;
            nombrePlan = driver.FindElement(By.Id("NombrePlan"));
            return nombrePlan;
        }

        public IWebElement ElementosPlanServicioCostoPlan(IWebDriver driver)
        {
            IWebElement costoPlan = null;
            costoPlan = driver.FindElement(By.Name("Costo"));
            return costoPlan;
        }

        public IWebElement ElementosPlanServicioDescripcion(IWebDriver driver)
        {
            IWebElement descripcion = driver.FindElement(By.Id("Descripcion"));
            return descripcion;
        }

        public IWebElement ElementosPlanServicioServiciosBuro(IWebDriver driver)
        {
            IWebElement Buro = driver.FindElement(By.Id("primerSelect"));
            return Buro;

        }

        //public void ElementosPlanServicioServiciosBuro(IWebDriver driver)
        //{
        //    driver.FindElement(By.Id("primerSelect")).Click();

        //}
    }
}
