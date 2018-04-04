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
        Comunes.GeneracionCadenas cadena = new Comunes.GeneracionCadenas();

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
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);
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

                        //int elemPos = (ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver)).Location.Y;
                        //((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        Thread.Sleep(2000);
                        ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan))
                                {
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }
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

        public bool ProcesoAltaPlanesServicioTodosLosDatos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_PlanServicioTodosLosCampos"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);
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

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        Thread.Sleep(2000);
                        ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan))
                                {
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }
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

        public bool ProcesoAltaPlanesServicioValidarCampos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("PlanServicioValidarCampos"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);
                        ElementosPlanServicioPrueba.ElementosPlanServicioBotonAgregarPlan(driver).Click();

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");

                        ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();

                        if (ElementosPlanServicioPrueba.ElementosPlanServicioMensajeNombre(driver).Text.Equals("Ingrese el nombre del plan"))
                            if (ElementosPlanServicioPrueba.ElementosPlanServicioMensajeDescripcion(driver).Text.Equals("Ingrese la descripción del plan"))
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioMensajeServicios(driver).Text.Equals("Ingrese toda la información del paquete"))
                                    resultado = true;

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

        public bool ProcesoAltaPlanesServicioValidarLongitudCampos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("PlanServicioValidarLongitudCampos"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);
                        ElementosPlanServicioPrueba.ElementosPlanServicioBotonAgregarPlan(driver).Click();

                        var cadenaNombrePlan = cadena.GenerarCadenasAlfanumericas(listaDatosPrueba[i].NombrePlan);
                        ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).SendKeys(cadenaNombrePlan);

                        var cadenaDescripcionPlan = cadena.GenerarCadenasAlfanumericas(listaDatosPrueba[i].Descripcion);
                        ElementosPlanServicioPrueba.ElementosPlanServicioDescripcion(driver).SendKeys(cadenaDescripcionPlan);

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();

                        //Mensaje de longitud de campos
                        if (ElementosPlanServicioPrueba.ElementosPlanServicioMensajeLongitudNombre(driver).Text.Equals("El tamaño máximo es de 26 caracteres"))
                            if (ElementosPlanServicioPrueba.ElementosPlanServicioMensajeLongitudDescripcion(driver).Text.Equals("El tamaño máximo es de 100 caracteres"))
                                resultado = true;

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

        public bool ProcesoAltaPlanesServicioValidarDuplicado(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("PlanServicioDuplicado"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);

                        var planExiste = ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, 1).Text;

                        ElementosPlanServicioPrueba.ElementosPlanServicioBotonAgregarPlan(driver).Click();
                        ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).SendKeys(planExiste);
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

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        Thread.Sleep(2000);
                        ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();

                        if (ElementosPlanServicioPrueba.ElementosPlanServicioMensajeDuplicado(driver).Text.Equals("El plan solicitado ya existe, favor de validar."))
                            resultado = true;

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

        public bool ProcesoAltaPlanesServicioInactivarPlan(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("PlanServicioInactivarPlan"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan) & ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan).Text.Equals("ACTIVO"))
                                {
                                    int elemPos = ((ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan)).Location.Y) - 100;
                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                                    ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan).Click();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioInactivarPlanConfirmar(driver).Click();
                                    Thread.Sleep(2000);
                                    if (ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan).Text.Equals("INACTIVO"))
                                    {
                                        resultado = true;
                                        buscar = false;
                                        break;
                                    }
                                }
                            }
                            pagina++;
                        }
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

        public bool ProcesoAltaPlanesServicioActivarPlan(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("PlanServicioActivarPlan"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan) & ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan).Text.Equals("INACTIVO"))
                                {
                                    int elemPos = ((ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan)).Location.Y) - 100;
                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                                    ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan).Click();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioInactivarPlanConfirmar(driver).Click();
                                    Thread.Sleep(2000);
                                    if (ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombrePlan).Text.Equals("ACTIVO"))
                                    {
                                        resultado = true;
                                        buscar = false;
                                        break;
                                    }
                                }
                            }
                            pagina++;
                        }
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

        public bool ProcesoEdicionPlanesServicioDatosObligatorios(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Edicion_Exitosa_PlanServicioCamposObligatorios"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombreAnterior))
                                {
                                    int elemPos = ((ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombreAnterior)).Location.Y) - 100;
                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                                    ElementosPlanServicioPrueba.ElementosPlanServicioEditarPlan(driver, indice).Click();

                                    ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).Clear();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).SendKeys(listaDatosPrueba[i].NombrePlan);

                                    ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).Clear();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).SendKeys(listaDatosPrueba[i].CostoPlan);

                                    ElementosPlanServicioPrueba.ElementosPlanServicioDescripcion(driver).Clear();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioDescripcion(driver).SendKeys(listaDatosPrueba[i].Descripcion);

                                    if (listaDatosPrueba[i].ServicioBuro.Equals("true"))
                                    {
                                        if (!ElementosPlanServicioPrueba.ElementosPlanServicioServiciosBuro(driver).Selected)
                                        {
                                            ElementosPlanServicioPrueba.ElementosPlanServicioServiciosBuro(driver).Click();
                                        }
                                    }

                                    if (listaDatosPrueba[i].ServicioTarjeta.Equals("true"))
                                    {
                                        if (!ElementosPlanServicioPrueba.ElementosPlanServicioServiciosTarjeta(driver).Selected)
                                        {
                                            ElementosPlanServicioPrueba.ElementosPlanServicioServiciosTarjeta(driver).Click();
                                        }
                                    }

                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                                    Thread.Sleep(2000);
                                    ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();
                                    Thread.Sleep(2000);
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;

                        }

                        pagina = 1;
                        buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan))
                                {
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }
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

        public bool ProcesoEdicionPlanesServicioTodosLosDatos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPlanServicio(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Edicion_Exitosa_PlanServicioTodosLosCampos"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPlanDeServicio(driver).Click();
                        Thread.Sleep(3000);

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombreAnterior))
                                {
                                    int elemPos = ((ElementosPlanServicioPrueba.ElementosPlanServicioEstatusPlan(driver, listaDatosPrueba[i].NombreAnterior)).Location.Y) - 100;
                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                                    ElementosPlanServicioPrueba.ElementosPlanServicioEditarPlan(driver, indice).Click();

                                    ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).Clear();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioNombrePlan(driver).SendKeys(listaDatosPrueba[i].NombrePlan);

                                    ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).Clear();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioCostoPlan(driver).SendKeys(listaDatosPrueba[i].CostoPlan);

                                    ElementosPlanServicioPrueba.ElementosPlanServicioDescripcion(driver).Clear();
                                    ElementosPlanServicioPrueba.ElementosPlanServicioDescripcion(driver).SendKeys(listaDatosPrueba[i].Descripcion);

                                    if (listaDatosPrueba[i].ServicioBuro.Equals("true"))
                                    {
                                        if (!ElementosPlanServicioPrueba.ElementosPlanServicioServiciosBuro(driver).Selected)
                                        {
                                            ElementosPlanServicioPrueba.ElementosPlanServicioServiciosBuro(driver).Click();
                                        }
                                    }

                                    if (listaDatosPrueba[i].ServicioTarjeta.Equals("true"))
                                    {
                                        if (!ElementosPlanServicioPrueba.ElementosPlanServicioServiciosTarjeta(driver).Selected)
                                        {
                                            ElementosPlanServicioPrueba.ElementosPlanServicioServiciosTarjeta(driver).Click();
                                        }
                                    }

                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                                    Thread.Sleep(2000);
                                    ElementosPlanServicioPrueba.ElementosPlanServiciAgregarPlan(driver).Click();
                                    Thread.Sleep(2000);
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;

                        }

                        pagina = 1;
                        buscar = true;
                        while (buscar)
                        {
                            ElementosPlanServicioPrueba.ElementosPlanServicioPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= ElementosPlanServicioPrueba.ElementosPlanServicioNumeroRegistros(driver, pagina); indice++)
                            {
                                if (ElementosPlanServicioPrueba.ElementosPlanServicioRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan))
                                {
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }
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
