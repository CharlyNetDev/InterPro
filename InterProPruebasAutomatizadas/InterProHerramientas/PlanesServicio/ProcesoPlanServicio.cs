using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        public bool ProcesoAltaPlanesServicioDatosObligatorios(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_PlanServicioCamposObligatorios"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(7000);

                        menuPrincipal.ElementoMenu(driver, 7).Click();
                        Thread.Sleep(7000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(7000);
                        ElementosPlanServicioPrueba.ElementosPlanServicioBotonAgregarPlan(driver).Click();
                        ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).SendKeys(listaDatosPrueba[i].NombrePlan);
                        ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).Clear();
                        ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).SendKeys(listaDatosPrueba[i].CostoPlan);

                        ElementosPlanServicioPrueba.ElementosPlanServicioDescripcion(driver).Clear();
                        ElementosPlanServicioPrueba.ElementosPlanServicioDescripcion(driver).SendKeys(listaDatosPrueba[i].Descripcion);

                        if (listaDatosPrueba[i].ServicioBuro.Equals("true"))
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioServiciosBuro(driver).Click();
                        }

                        if (listaDatosPrueba[i].ServicioTarjeta.Equals("true"))
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioServiciosTarjeta(driver).Click();
                        }
                        Thread.Sleep(2000);

                        //int elemPos = (ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver)).Location.Y;
                        //((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();

                        resultado = true;

                        Thread.Sleep(2000);
                        driver.Close();
                    }
                }
            }
            catch
            {
                resultado = false;
            }


            return resultado;
        }


    }
}
