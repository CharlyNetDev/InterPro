using OpenQA.Selenium;
using System.Threading;

namespace InterProHerramientas.LogIn
{
    public class ProcesoLogIn
    {
        Comunes.Navegadores navegadorPruba = new Comunes.Navegadores();
        Comunes.InterproteccionObjetos objetosPrueba = new Comunes.InterproteccionObjetos();
        Comunes.CargaDatosPrueba datosPrueba = new Comunes.CargaDatosPrueba();
        ElementosLogIn elementosLogInPrueba = new ElementosLogIn();
        ElementosMenuPrincipal menuPrincipal = new ElementosMenuPrincipal();

        public bool AccesoExitosoWEPID(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatos(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos - 1; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Acceso_exitoso"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(7000);
                        for (int elemntosMenu = 1; elemntosMenu <= 6; elemntosMenu++)
                        {
                            if (menuPrincipal.ElementoMenu(driver, elemntosMenu).Displayed)
                            {
                                resultado = true;
                            }
                            else
                            {
                                resultado = false;
                            }
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

        public bool AccesoNoExitosoWEPIDUsuarioIncorrecto(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatos(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Usuario_Incorrecto"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(2000);
                        if (elementosLogInPrueba.UsuarioIncorrecto(driver).Text.Equals("Usuario y/o contraseña incorrectos, intente de nuevo."))
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

        public bool AccesoNoExitosoWEPIDContraseniaIncorrecto(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatos(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Contrasenia_Incorrecta"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(2000);
                        if (elementosLogInPrueba.UsuarioIncorrecto(driver).Text.Equals("Usuario y/o contraseña incorrectos, intente de nuevo."))
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

        public bool AccesoNoExitosoWEPIDSinUsuario(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatos(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Sin_Usuario"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        //elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(2000);
                        if (elementosLogInPrueba.SinUsuario(driver).Text.Equals("Ingrese su usuario"))
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

        public bool AccesoNoExitosoWEPIDSinContrasenia(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatos(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Sin_Contrasenia"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        //elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(2000);
                        if (elementosLogInPrueba.SinContrasenia(driver).Text.Equals("Ingrese su contraseña"))
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

        public bool AccesoNoExitosoWEPIDSinDatos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatos(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (listaDatosPrueba[i].TestCase.Equals("Sin_Datos"))
                    {
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        //elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        //elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(2000);
                        if (elementosLogInPrueba.SinUsuario(driver).Text.Equals("Ingrese su usuario"))
                            if (elementosLogInPrueba.SinContrasenia(driver).Text.Equals("Ingrese su contraseña"))
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



    }
}