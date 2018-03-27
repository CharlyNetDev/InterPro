using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Threading;

namespace InterProHerramientas.PlanesServicio
{
    [TestClass]
    public class ProcesoPlanServicio
    {
        Comunes.Navegadores navegadorPruba = new Comunes.Navegadores();
        Comunes.InterproteccionObjetos objetosPrueba = new Comunes.InterproteccionObjetos();
        Comunes.CargaDatosPrueba datosPrueba = new Comunes.CargaDatosPrueba();
        LogIn.ElementosLogIn elementosLogInPrueba = new LogIn.ElementosLogIn();
        LogIn.ElementosMenuPrincipal menuPrincipal = new LogIn.ElementosMenuPrincipal();
        Elementos.ElementosPlanServicio ElementosPlanServicioPrueba = new Elementos.ElementosPlanServicio();

        [TestMethod]
        public bool ProcesoAltaPlanesServicio(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            //try
            //{
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitoasa_PlanServicioCamposObligatorios"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(2000);

                        menuPrincipal.ElementoMenu(driver, 7).Click();
                        Thread.Sleep(2000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(2000);
                        ElementosPlanServicioPrueba.ElementosPlanServicioBotonAgregarPlan(driver).Click();
                        ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).SendKeys(listaDatosPrueba[i].NombrePlan);
                        ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).Clear();
                        ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).SendKeys(listaDatosPrueba[i].CostoPlan);

                        
                        ElementosPlanServicioPrueba.ElementosPlanServicioServiciosBuro(driver).Click();

                        
                       // ElementosPlanServicioPrueba.ElementosPlanServicioBotonAgregarPlan(driver).Click();
                        Thread.Sleep(2000);
                        driver.Close();
                    }
                }
            //}
            //catch
            //{
            //    resultado = false;
            //}

            return resultado;
        }
    }
}
