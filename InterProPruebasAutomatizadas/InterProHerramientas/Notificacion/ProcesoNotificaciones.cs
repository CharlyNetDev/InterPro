using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Globalization;
using System;

namespace InterProHerramientas.Notificaciones
{
    public class ProcesoNotificaciones
    {
        Comunes.Navegadores navegadorPruba = new Comunes.Navegadores();
        Comunes.InterproteccionObjetos objetosPrueba = new Comunes.InterproteccionObjetos();
        Comunes.CargaDatosPrueba datosPrueba = new Comunes.CargaDatosPrueba();
        LogIn.ElementosLogIn elementosLogInPrueba = new LogIn.ElementosLogIn();
        LogIn.ElementosMenuPrincipal menuPrincipal = new LogIn.ElementosMenuPrincipal();
        Comunes.GeneracionCadenas cadena = new Comunes.GeneracionCadenas();
        Elementos.ElementosNotificaciones elementosNotificacionesPrueba = new Elementos.ElementosNotificaciones();


        public bool ProcesoAltaNotificacionCamposObligatoriosBancos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosNotificaciones(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_NotificacionCamposObligatoriosBancos"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 7).Click();
                        Thread.Sleep(3000);

                        elementosNotificacionesPrueba.ElementosNotificacionesGenerar(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesMensaje(driver).SendKeys(listaDatosPrueba[i].Mensaje);

                        elementosNotificacionesPrueba.ElementosNotificacionesSeleccionBancos(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesTodosBancos(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesEnviar(driver).Click();

                        int elemPos = (elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, 1)).Location.Y;
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        Thread.Sleep(2000);


                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosNotificacionesPrueba.ElementosNotificacionesNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosNotificacionesPrueba.ElementosNotificacionesResgistro(driver, indice).Text.Equals(listaDatosPrueba[i].Mensaje))
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

        public bool ProcesoAltaNotificacionCamposObligatoriosEmpresas(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosNotificaciones(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_NotificacionCamposObligatoriosEmpresas"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 7).Click();
                        Thread.Sleep(3000);

                        elementosNotificacionesPrueba.ElementosNotificacionesGenerar(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesMensaje(driver).SendKeys(listaDatosPrueba[i].Mensaje);

                        elementosNotificacionesPrueba.ElementosNotificacionesSeleccionEmpresas(driver).Click();
                        Thread.Sleep(2000);
                        elementosNotificacionesPrueba.ElementosNotificacionesTodosEmpresas(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesEnviar(driver).Click();

                        int elemPos = (elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, 1)).Location.Y;
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        Thread.Sleep(2000);


                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosNotificacionesPrueba.ElementosNotificacionesNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosNotificacionesPrueba.ElementosNotificacionesResgistro(driver, indice).Text.Equals(listaDatosPrueba[i].Mensaje))
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

        public bool ProcesoAltaNotificacionCamposObligatoriosPlanesServicio(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosNotificaciones(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_NotificacionCamposObligatoriosPlanes"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 7).Click();
                        Thread.Sleep(3000);

                        elementosNotificacionesPrueba.ElementosNotificacionesGenerar(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesMensaje(driver).SendKeys(listaDatosPrueba[i].Mensaje);

                        elementosNotificacionesPrueba.ElementosNotificacionesSeleccionPlanes(driver).Click();
                        Thread.Sleep(2000);
                        elementosNotificacionesPrueba.ElementosNotificacionesTodosPlanes(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesEnviar(driver).Click();

                        int elemPos = (elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, 1)).Location.Y;
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        Thread.Sleep(2000);


                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosNotificacionesPrueba.ElementosNotificacionesNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosNotificacionesPrueba.ElementosNotificacionesResgistro(driver, indice).Text.Equals(listaDatosPrueba[i].Mensaje))
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

        public bool ProcesoValidacionCampoMensajes(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosNotificaciones(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Notificaciones_Validacion_Campos"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 7).Click();
                        Thread.Sleep(3000);

                        elementosNotificacionesPrueba.ElementosNotificacionesGenerar(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesEnviar(driver).Click();

                        Thread.Sleep(3000);
                        if (elementosNotificacionesPrueba.ElementosNotificacionesMensajeValidacion(driver).Text.Equals("El campo 'Mensaje' es requerido"))
                            if (elementosNotificacionesPrueba.ElementosNotificacioneDestinatarioValidacion(driver).Text.Equals("×\r\nEs necesario elegir hacía quien o quienes se enviará la notificación.     "))
                                resultado = true;
                    }
                }
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        public bool ProcesoAltaNotificacionProgramada(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosNotificaciones(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_NotificacionProgramada"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 7).Click();
                        Thread.Sleep(3000);

                        elementosNotificacionesPrueba.ElementosNotificacionesGenerar(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesMensaje(driver).SendKeys(listaDatosPrueba[i].Mensaje);

                        elementosNotificacionesPrueba.ElementosNotificacionesSeleccionPlanes(driver).Click();
                        Thread.Sleep(2000);
                        elementosNotificacionesPrueba.ElementosNotificacionesTodosPlanes(driver).Click();

                        elementosNotificacionesPrueba.ElementosNotificacionesProgramar(driver).Click();
                        elementosNotificacionesPrueba.ElementosNotificacionesFecha(driver).Clear();
                        elementosNotificacionesPrueba.ElementosNotificacionesFecha(driver).SendKeys(listaDatosPrueba[i].FechaEnvio);
                        elementosNotificacionesPrueba.ElementosNotificacionesHora(driver).Clear();
                        
                        elementosNotificacionesPrueba.ElementosNotificacionesHora(driver).SendKeys("23:50");
                        
                        elementosNotificacionesPrueba.ElementosNotificacionesEnviar(driver).Click();

                        //int elemPos = (elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, 1)).Location.Y;
                        //((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                        //((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        //Thread.Sleep(2000);


                        //int pagina = 1;
                        //var buscar = true;
                        //while (buscar)
                        //{
                        //    elementosNotificacionesPrueba.ElementosNotificacionesPaginado(driver, pagina).Click();
                        //    Thread.Sleep(2000);
                        //    for (int indice = 1; indice <= elementosNotificacionesPrueba.ElementosNotificacionesNumeroRegistros(driver, pagina); indice++)
                        //    {
                        //        if (elementosNotificacionesPrueba.ElementosNotificacionesResgistro(driver, indice).Text.Equals(listaDatosPrueba[i].Mensaje))
                        //        {
                        //            resultado = true;
                        //            buscar = false;
                        //            break;
                        //        }
                        //    }
                        //    pagina++;
                        //}
                        //driver.Close();
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
