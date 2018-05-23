using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;

namespace InterProHerramientas.Clientes
{
    public class ProcesoClientes
    {
        // ALTA DE VARIABLES
        int TiempoBasico = 2000;
        int TiempoMedio = 3000;
        int TiempoAlto = 4000;


        // CREAR INSTANCIAS
        Comunes.Navegadores navegadorPruba = new Comunes.Navegadores();
        Comunes.InterproteccionObjetos objetosPrueba = new Comunes.InterproteccionObjetos();
        Comunes.CargaDatosPrueba datosPrueba = new Comunes.CargaDatosPrueba();
        LogIn.ElementosLogIn elementosLogInPrueba = new LogIn.ElementosLogIn();
        LogIn.ElementosMenuPrincipal menuPrincipal = new LogIn.ElementosMenuPrincipal();
        Elementos.ElementosClientes elementosClientes = new Elementos.ElementosClientes();
        Comunes.GeneracionCadenas cadena = new Comunes.GeneracionCadenas();

        //CREAR UN CLIENTE EXITOSAMENTE

        //public bool A001_AltaClientesTodosLosDatos(string pathArchivo)
        //{

        //    bool resultado = false;
        //    IWebDriver driver = null;
        //    var listaDatosPrueba = datosPrueba.CargaDatosClientes(pathArchivo);
        //    var elementos = listaDatosPrueba.Count;

        //    try
        //    {
        //        for (int i = 0; i < elementos; i++)
        //        {
        //            if (listaDatosPrueba[0].TestCase.Equals("Alta_Exitosa_AltaClientesTodosLosDatos"))
        //            {

        //                driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
        //                driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
        //                elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
        //                elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
        //                elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
        //                // Esperar a que se cargue la página. 
        //                Thread.Sleep(TiempoMedio);


        //                // MENÚ PRINCIPAL DONDE SE SELECCIONA LA OPCION DE "CLIENTES"
        //                menuPrincipal.ElementoMenu(driver, 2).Click();
        //                // Esperar a que se cargue la página. 
        //                Thread.Sleep(TiempoMedio);

        //                // DAR CLIC AL BOTÓN "AGREGAR CLIENTE INDIVIDUAL"
        //                elementosClientes.ElementosClienteAgregar(driver).Click();
        //                // Esperar a que se cargue la página. 
        //                Thread.Sleep(TiempoBasico);

        //                // CAPTURA LOS CAMPOS DEL MÓDULO
        //                if (listaDatosPrueba[i].ApPaterno != null)
        //                {
        //                    elementosClientes.ElementosClienteApellidoPaterno(driver).SendKeys(listaDatosPrueba[i].ApPaterno);
        //                }

        //                if (listaDatosPrueba[i].ApMaterno != null)
        //                {
        //                    elementosClientes.ElementosClienteApellidoMaterno(driver).SendKeys(listaDatosPrueba[i].ApMaterno);
        //                }

        //                if (listaDatosPrueba[i].PrimerNombre != null)
        //                {
        //                    elementosClientes.ElementosClientePrimerNombre(driver).SendKeys(listaDatosPrueba[i].PrimerNombre);
        //                }

        //                if (listaDatosPrueba[i].SegudoNombre != null)
        //                {
        //                    elementosClientes.ElementosClienteSegundoNombre(driver).SendKeys(listaDatosPrueba[i].SegudoNombre);
        //                    //elementosClientes.ElementosClienteFechaNacimiento(driver).SendKeys(listaDatosPrueba[i].FechaNacimiento);
        //                }

        //                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //                js.ExecuteScript("document.getElementById('fecha-picker').value='" + listaDatosPrueba[i].FechaNacimiento + "'");
        //                //js.ExecuteScript("document.getElementById('fecha-picker').value='01/01/1984'");

        //                if (listaDatosPrueba[i].CorreoElectronico != null)
        //                {
        //                    elementosClientes.ElementosClienteCorreoPrincipal(driver).SendKeys(listaDatosPrueba[i].CorreoElectronico);
        //                }

        //                if (listaDatosPrueba[i].CorreoElectronicoAlterno != null)
        //                {
        //                    elementosClientes.ElementosClienteCorreoSecundario(driver).SendKeys(listaDatosPrueba[i].CorreoElectronicoAlterno);
        //                }

        //                if (listaDatosPrueba[i].RFC != null)
        //                {
        //                    elementosClientes.ElementosClienteRFC(driver).SendKeys(listaDatosPrueba[i].RFC);
        //                }

        //                if (listaDatosPrueba[i].CURP != null)
        //                {
        //                    elementosClientes.ElementosClienteCURP(driver).SendKeys(listaDatosPrueba[i].CURP);
        //                }

        //                if (listaDatosPrueba[i].TelefonoCasa != null)
        //                {
        //                    elementosClientes.ElementosClienteTelefonoCasa(driver).SendKeys(listaDatosPrueba[i].TelefonoCasa);
        //                }

        //                if (listaDatosPrueba[i].TelefonoCelular != null)
        //                {
        //                    elementosClientes.ElementosClienteTelefonoCelular(driver).SendKeys(listaDatosPrueba[i].TelefonoCelular);
        //                }

        //                if (listaDatosPrueba[i].Calle != null)
        //                {
        //                    elementosClientes.ElementosClienteCalleyNumero(driver).SendKeys(listaDatosPrueba[i].Calle);
        //                }

        //                if (listaDatosPrueba[i].CodigoPostal != null)
        //                {
        //                    elementosClientes.ElementosClienteCodigoPostal(driver).SendKeys(listaDatosPrueba[i].CodigoPostal);
        //                }

        //                SelectElement select = new SelectElement(elementosClientes.ElementosClienteEstado(driver));
        //                select.SelectByText(listaDatosPrueba[i].Estado);

        //                if (listaDatosPrueba[i].Ciudad != null)
        //                {
        //                    elementosClientes.ElementosClienteCiudad(driver).SendKeys(listaDatosPrueba[i].Ciudad);
        //                }

        //                if (listaDatosPrueba[i].Delegacion != null)
        //                {
        //                    elementosClientes.ElementosClienteDelegacionMunicipio(driver).SendKeys(listaDatosPrueba[i].Delegacion);
        //                }

        //                if (listaDatosPrueba[i].Colonia != null)
        //                {
        //                    elementosClientes.ElementosClienteDelegacionColonia(driver).SendKeys(listaDatosPrueba[i].Colonia);
        //                }

        //                // CAPTURAR CAMPOS DE LA SECCION "DATOS DE USUARIO"
        //                ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
        //                Thread.Sleep(2000);

        //                elementosClientes.ElementosClientePestanaDatosUsuario(driver).Click();
        //                Thread.Sleep(TiempoBasico);

        //                //elementosClientes.ElementosClienteSeleccionarPlan(driver).Click();

        //                IList<IWebElement> planes = elementosClientes.ElementosClienteNumeroPlanes(driver);
        //                var listaPlanes = planes.Count;

        //                for (int indice = 2; indice <= listaPlanes; indice++)
        //                {
        //                    if (elementosClientes.ElementosClienteSeleccionarPlan(driver, indice).Text.Contains(listaDatosPrueba[i].PlanContratado))
        //                    {
        //                        elementosClientes.ElementosClienteSeleccionarPlan(driver, indice).Click();
        //                        Thread.Sleep(TiempoBasico);
        //                    }
        //                }

        //                //Guardar informacion 
        //                elementosClientes.ElementosClienteGuardar(driver).Click();
        //                Thread.Sleep(TiempoBasico);

        //                elementosClientes.ElementosClientePestanaDatosUsuario(driver).Click();

        //                // CAPTURAR FORMAS DE PAGO
        //                //elementosClientes.ElementosClienteFormaPagoAgregarNueva(driver, 1).Click();
        //                int elemPos = (elementosClientes.ElementosClienteFormaPagoBotonAgregar(driver)).Location.Y;
        //                Thread.Sleep(TiempoBasico);
        //                ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(" + elemPos + ", " + elemPos + ");");

        //                elementosClientes.ElementosClienteFormaPagoNumeroTarjeta(driver).SendKeys(listaDatosPrueba[i].FormaPagoNumeroTarjeta);
        //                elementosClientes.ElementosClienteFormaPagoVencimientoMM(driver).SendKeys(listaDatosPrueba[i].FormaPagoVencimientoMM);
        //                elementosClientes.ElementosClienteFormaPagoVencimientoAA(driver).SendKeys(listaDatosPrueba[i].FormaPagoVencimientoAA);
        //                elementosClientes.ElementosClienteFormaPagoCVV(driver).SendKeys(listaDatosPrueba[i].FormaPagoCVV);
        //                elementosClientes.ElementosClienteFormaPagoNombreDuenioTarjeta(driver).SendKeys(listaDatosPrueba[i].FormaPagoNombreDuenioTarjeta);

        //                // AGREGAR TARJETA
        //                elementosClientes.ElementosClienteFormaPagoBotonAgregar(driver).Click();
        //                Thread.Sleep(TiempoBasico);

        //                // SECCION "ESTADOS DE CUENTA" Y PAGAR
        //                ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
        //                Thread.Sleep(2000);

        //                elementosClientes.ElementosEstadosCuentaSeccion(driver).Click();
        //                Thread.Sleep(TiempoBasico);
        //                // Pagar el estado de cuenta
        //                elementosClientes.ElementosEstadosCuentaBotonPagar(driver).Click();

        //                //Confirmar el pago
        //                elementosClientes.ElementosEstadosCuentaBotonConfirmarPagar(driver).Click();

        //                driver.Close();

        //                //int pagina = 1;
        //                //bool buscar = true;
        //                //while (buscar)
        //                //{
        //                //    elementosEmpleadosPrueba.ElementosEmpleadosPaginado(driver, pagina).Click();
        //                //    Thread.Sleep(TiempoBasico);
        //                //    for (int indice = 1; indice <= elementosEmpleadosPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
        //                //    {
        //                //        if (elementosEmpleadosPrueba.ElementosEmpleadosRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombreUsuario))
        //                //        {
        //                //            resultado = true;
        //                //            buscar = false;
        //                //            break;
        //                //        }
        //                //    }
        //                //    pagina++;
        //                //}
        //                resultado = true;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        resultado = false;
        //    }
        //    return resultado;
        //}

        public bool A001_AltaClientesTodosLosDatos(string pathArchivo)
        {

            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosClientes(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            int i = 0;
            driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
            driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
            elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
            elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
            elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
            // Esperar a que se cargue la página. 
            Thread.Sleep(TiempoMedio);

            try
            {
                for (; i < elementos; i++)
                {
                    if (listaDatosPrueba[0].TestCase.Equals("Alta_Exitosa_AltaClientesTodosLosDatos"))
                    {
                        // MENÚ PRINCIPAL DONDE SE SELECCIONA LA OPCION DE "CLIENTES"
                        menuPrincipal.ElementoMenu(driver, 2).Click();
                        // Esperar a que se cargue la página. 
                        Thread.Sleep(TiempoMedio);

                        // DAR CLIC AL BOTÓN "AGREGAR CLIENTE INDIVIDUAL"
                        elementosClientes.ElementosClienteAgregar(driver).Click();
                        // Esperar a que se cargue la página. 
                        Thread.Sleep(TiempoBasico);

                        // CAPTURA LOS CAMPOS DEL MÓDULO
                        if (listaDatosPrueba[i].ApPaterno != null)
                        {
                            elementosClientes.ElementosClienteApellidoPaterno(driver).SendKeys(listaDatosPrueba[i].ApPaterno);
                        }

                        if (listaDatosPrueba[i].ApMaterno != null)
                        {
                            elementosClientes.ElementosClienteApellidoMaterno(driver).SendKeys(listaDatosPrueba[i].ApMaterno);
                        }

                        if (listaDatosPrueba[i].PrimerNombre != null)
                        {
                            elementosClientes.ElementosClientePrimerNombre(driver).SendKeys(listaDatosPrueba[i].PrimerNombre);
                        }

                        if (listaDatosPrueba[i].SegudoNombre != null)
                        {
                            elementosClientes.ElementosClienteSegundoNombre(driver).SendKeys(listaDatosPrueba[i].SegudoNombre);
                            //elementosClientes.ElementosClienteFechaNacimiento(driver).SendKeys(listaDatosPrueba[i].FechaNacimiento);
                        }

                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("document.getElementById('fecha-picker').value='" + listaDatosPrueba[i].FechaNacimiento + "'");
                        //js.ExecuteScript("document.getElementById('fecha-picker').value='01/01/1984'");

                        if (listaDatosPrueba[i].CorreoElectronico != null)
                        {
                            elementosClientes.ElementosClienteCorreoPrincipal(driver).SendKeys(listaDatosPrueba[i].CorreoElectronico);
                        }

                        if (listaDatosPrueba[i].CorreoElectronicoAlterno != null)
                        {
                            elementosClientes.ElementosClienteCorreoSecundario(driver).SendKeys(listaDatosPrueba[i].CorreoElectronicoAlterno);
                        }

                        if (listaDatosPrueba[i].RFC != null)
                        {
                            elementosClientes.ElementosClienteRFC(driver).SendKeys(listaDatosPrueba[i].RFC);
                        }

                        if (listaDatosPrueba[i].CURP != null)
                        {
                            elementosClientes.ElementosClienteCURP(driver).SendKeys(listaDatosPrueba[i].CURP);
                        }

                        if (listaDatosPrueba[i].TelefonoCasa != null)
                        {
                            elementosClientes.ElementosClienteTelefonoCasa(driver).SendKeys(listaDatosPrueba[i].TelefonoCasa);
                        }

                        if (listaDatosPrueba[i].TelefonoCelular != null)
                        {
                            elementosClientes.ElementosClienteTelefonoCelular(driver).SendKeys(listaDatosPrueba[i].TelefonoCelular);
                        }

                        if (listaDatosPrueba[i].Calle != null)
                        {
                            elementosClientes.ElementosClienteCalleyNumero(driver).SendKeys(listaDatosPrueba[i].Calle);
                        }

                        if (listaDatosPrueba[i].CodigoPostal != null)
                        {
                            elementosClientes.ElementosClienteCodigoPostal(driver).SendKeys(listaDatosPrueba[i].CodigoPostal);
                        }

                        SelectElement select = new SelectElement(elementosClientes.ElementosClienteEstado(driver));
                        select.SelectByText(listaDatosPrueba[i].Estado);

                        if (listaDatosPrueba[i].Ciudad != null)
                        {
                            elementosClientes.ElementosClienteCiudad(driver).SendKeys(listaDatosPrueba[i].Ciudad);
                        }

                        if (listaDatosPrueba[i].Delegacion != null)
                        {
                            elementosClientes.ElementosClienteDelegacionMunicipio(driver).SendKeys(listaDatosPrueba[i].Delegacion);
                        }

                        if (listaDatosPrueba[i].Colonia != null)
                        {
                            elementosClientes.ElementosClienteDelegacionColonia(driver).SendKeys(listaDatosPrueba[i].Colonia);
                        }

                        // CAPTURAR CAMPOS DE LA SECCION "DATOS DE USUARIO"
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        Thread.Sleep(2000);

                        elementosClientes.ElementosClientePestanaDatosUsuario(driver).Click();
                        Thread.Sleep(TiempoBasico);

                        //elementosClientes.ElementosClienteSeleccionarPlan(driver).Click();

                        IList<IWebElement> planes = elementosClientes.ElementosClienteNumeroPlanes(driver);
                        var listaPlanes = planes.Count;

                        for (int indice = 2; indice <= listaPlanes; indice++)
                        {
                            if (elementosClientes.ElementosClienteSeleccionarPlan(driver, indice).Text.Contains(listaDatosPrueba[i].PlanContratado))
                            {
                                elementosClientes.ElementosClienteSeleccionarPlan(driver, indice).Click();
                                Thread.Sleep(TiempoBasico);
                            }
                        }

                        //Guardar informacion 
                        elementosClientes.ElementosClienteGuardar(driver).Click();
                        Thread.Sleep(TiempoBasico);

                        elementosClientes.ElementosClientePestanaDatosUsuario(driver).Click();

                        // CAPTURAR FORMAS DE PAGO
                        //elementosClientes.ElementosClienteFormaPagoAgregarNueva(driver, 1).Click();
                        //int elemPos = (elementosClientes.ElementosClienteFormaPagoBotonAgregar(driver)).Location.Y;
                        //Thread.Sleep(TiempoBasico);
                        //((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(" + elemPos + ", " + elemPos + ");");

                        //elementosClientes.ElementosClienteFormaPagoNumeroTarjeta(driver).SendKeys(listaDatosPrueba[i].FormaPagoNumeroTarjeta);
                        //elementosClientes.ElementosClienteFormaPagoVencimientoMM(driver).SendKeys(listaDatosPrueba[i].FormaPagoVencimientoMM);
                        //elementosClientes.ElementosClienteFormaPagoVencimientoAA(driver).SendKeys(listaDatosPrueba[i].FormaPagoVencimientoAA);
                        //elementosClientes.ElementosClienteFormaPagoCVV(driver).SendKeys(listaDatosPrueba[i].FormaPagoCVV);
                        //elementosClientes.ElementosClienteFormaPagoNombreDuenioTarjeta(driver).SendKeys(listaDatosPrueba[i].FormaPagoNombreDuenioTarjeta);

                        //// AGREGAR TARJETA
                        //elementosClientes.ElementosClienteFormaPagoBotonAgregar(driver).Click();
                        //Thread.Sleep(TiempoBasico);

                        // SECCION "ESTADOS DE CUENTA" Y PAGAR
                        //((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 0);");
                        //Thread.Sleep(2000);

                        //elementosClientes.ElementosEstadosCuentaSeccion(driver).Click();
                        //Thread.Sleep(TiempoBasico);
                        //// Pagar el estado de cuenta
                        //elementosClientes.ElementosEstadosCuentaBotonPagar(driver).Click();

                        //Confirmar el pago
                        //elementosClientes.ElementosEstadosCuentaBotonConfirmarPagar(driver).Click();

                        //driver.Close();

                        //int pagina = 1;
                        //bool buscar = true;
                        //while (buscar)
                        //{
                        //    elementosEmpleadosPrueba.ElementosEmpleadosPaginado(driver, pagina).Click();
                        //    Thread.Sleep(TiempoBasico);
                        //    for (int indice = 1; indice <= elementosEmpleadosPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
                        //    {
                        //        if (elementosEmpleadosPrueba.ElementosEmpleadosRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombreUsuario))
                        //        {
                        //            resultado = true;
                        //            buscar = false;
                        //            break;
                        //        }
                        //    }
                        //    pagina++;
                        //}
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

    }
}
