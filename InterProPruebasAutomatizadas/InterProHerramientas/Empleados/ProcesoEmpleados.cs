using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using InterProHerramientas.LogIn;
using System.Threading;
using InterProHerramientas.Empleados.Elementos;
using OpenQA.Selenium.Support.UI;

namespace InterProHerramientas.Empleados
{
    public class ProcesoEmpleados
    {
        Comunes.Navegadores navegadorPruba = new Comunes.Navegadores();
        Comunes.InterproteccionObjetos objetosPrueba = new Comunes.InterproteccionObjetos();
        Comunes.CargaDatosPrueba datosPrueba = new Comunes.CargaDatosPrueba();
        ElementosLogIn elementosLogInPrueba = new ElementosLogIn();
        ElementosMenuPrincipal menuPrincipal = new ElementosMenuPrincipal();
        ElementosEmpleados elementosEmpleadosPrueba = new ElementosEmpleados();
        Comunes.GeneracionCadenas cadena = new Comunes.GeneracionCadenas();

        public bool AltaEmpleadoDatosObligatorios(string pathArchivo)
        {

            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosEmpleados(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_EmpleadoCamposObligatorios"))
                    {

                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuEmpleados(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonAgregarEmpleado(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosNombreDelUsuario(driver).SendKeys(listaDatosPrueba[i].NombreUsuario);
                        elementosEmpleadosPrueba.ElementosEmpleadosCorreElectronico(driver).SendKeys(listaDatosPrueba[i].CorreoElectronico);

                        SelectElement select = new SelectElement(elementosEmpleadosPrueba.ElementosEmpleadosRol(driver));
                        select.SelectByText(listaDatosPrueba[i].Rol);

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonCrearEmpleado(driver).Click();

                        int pagina = 1;
                        bool buscar = true;
                        while (buscar)
                        {
                            elementosEmpleadosPrueba.ElementosEmpleadosPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosEmpleadosPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosEmpleadosPrueba.ElementosEmpleadosRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan))
                                {
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }
                    }
                }
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        public bool EmpleadoValidarCampos(string pathArchivo)
        {

            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosEmpleados(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("EmpleadoValidarCampos"))
                    {

                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuEmpleados(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonAgregarEmpleado(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonCrearEmpleado(driver).Click();

                        if (elementosEmpleadosPrueba.ElementosEmpleadosMensajeNombre(driver).Text.Equals("Ingrese el nombre del usuario"))
                            if (elementosEmpleadosPrueba.ElementosEmpleadosMensajeCorreo(driver).Text.Equals("Ingrese el correo del usuario"))
                                if (elementosEmpleadosPrueba.ElementosEmpleadosMensajeRol(driver).Text.Equals("Seleccione un rol valido"))
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

        public bool EmpleadosValidarLongitudCampos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosEmpleados(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("EmpleadoValidarLongitudCampos"))
                    {

                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuEmpleados(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonAgregarEmpleado(driver).Click();

                        var cadenaNombreUsuario = cadena.GenerarCadenasAlfanumericas(listaDatosPrueba[i].NombreUsuario);
                        elementosEmpleadosPrueba.ElementosEmpleadosNombreDelUsuario(driver).SendKeys(cadenaNombreUsuario);
                        elementosEmpleadosPrueba.ElementosEmpleadosCorreElectronico(driver).SendKeys(listaDatosPrueba[i].CorreoElectronico);

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonCrearEmpleado(driver).Click();

                        //Mensaje de longitud de campos
                        if (elementosEmpleadosPrueba.ElementosEmpleadosMensajeNombreValidacionLongitu(driver).Text.Equals("El tamaño máximo es de 35 caracteres"))
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

        public bool EmpleadosValidacionUsuarioDuplicado(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosEmpleados(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("EmpleadoValidarUsuarioDuplicado"))
                    {

                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuEmpleados(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonAgregarEmpleado(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosNombreDelUsuario(driver).SendKeys(listaDatosPrueba[i].NombreUsuario);
                        elementosEmpleadosPrueba.ElementosEmpleadosCorreElectronico(driver).SendKeys(listaDatosPrueba[i].CorreoElectronico);

                        SelectElement select = new SelectElement(elementosEmpleadosPrueba.ElementosEmpleadosRol(driver));
                        select.SelectByText(listaDatosPrueba[i].Rol);

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonCrearEmpleado(driver).Click();

                        //Mensaje de longitud de campos
                        if (elementosEmpleadosPrueba.ElementosEmpleadosMensajeUsuatioDuplicado(driver).Text.Equals("El usuario que intenta agregar ya existe, intente con otro correo."))
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

        public bool EmpleadosValidarEliminar(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosEmpleados(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("EmpleadoValidarUsuarioEliminar"))
                    {

                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuEmpleados(driver).Click();

                        int pagina = 1;
                        bool buscar = true;
                        while (buscar)
                        {
                            elementosEmpleadosPrueba.ElementosEmpleadosPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosEmpleadosPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosEmpleadosPrueba.ElementosEmpleadosRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombreUsuario))
                                {
                                    int elemPos = ((elementosEmpleadosPrueba.ElementosEmpleadosEliminarEmpleado(driver, listaDatosPrueba[i].NombreAnterior)).Location.Y) - 100;
                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");
                                    
                                    elementosEmpleadosPrueba.ElementosEmpleadosEliminarEmpleado(driver, listaDatosPrueba[i].NombreUsuario).Click();
                                    
                                    elementosEmpleadosPrueba.ElementosEmpleadosConfirmacionAceptarEliminar(driver).Click();
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }
                        pagina++;
                    }
                }
            
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        public bool EmpleadosReactivacionDatosObligatorios(string pathArchivo)
        {

            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosEmpleados(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Reactivacion_Exitosa_EmpleadoCamposObligatorios"))
                    {

                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuEmpleados(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonAgregarEmpleado(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosNombreDelUsuario(driver).SendKeys(listaDatosPrueba[i].NombreUsuario);
                        elementosEmpleadosPrueba.ElementosEmpleadosCorreElectronico(driver).SendKeys(listaDatosPrueba[i].CorreoElectronico);

                        SelectElement select = new SelectElement(elementosEmpleadosPrueba.ElementosEmpleadosRol(driver));
                        select.SelectByText(listaDatosPrueba[i].Rol);

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonCrearEmpleado(driver).Click();

                        int pagina = 1;
                        bool buscar = true;
                        while (buscar)
                        {
                            elementosEmpleadosPrueba.ElementosEmpleadosPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosEmpleadosPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosEmpleadosPrueba.ElementosEmpleadosRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan))
                                {
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }

                    }
                }
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        public bool EmpleadosEditarDatosObligatorios(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosEmpleados(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Edicion_Exitosa_EmpleadoCamposObligatorios"))
                    {

                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuEmpleados(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonAgregarEmpleado(driver).Click();

                        elementosEmpleadosPrueba.ElementosEmpleadosNombreDelUsuario(driver).SendKeys(listaDatosPrueba[i].NombreUsuario);
                        elementosEmpleadosPrueba.ElementosEmpleadosCorreElectronico(driver).SendKeys(listaDatosPrueba[i].CorreoElectronico);

                        SelectElement select = new SelectElement(elementosEmpleadosPrueba.ElementosEmpleadosRol(driver));
                        select.SelectByText(listaDatosPrueba[i].Rol);

                        elementosEmpleadosPrueba.ElementosEmpleadosBotonCrearEmpleado(driver).Click();

                        int pagina = 1;
                        bool buscar = true;
                        while (buscar)
                        {
                            elementosEmpleadosPrueba.ElementosEmpleadosPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosEmpleadosPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosEmpleadosPrueba.ElementosEmpleadosRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].NombrePlan))
                                {
                                    resultado = true;
                                    buscar = false;
                                    break;
                                }
                            }
                            pagina++;
                        }

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
