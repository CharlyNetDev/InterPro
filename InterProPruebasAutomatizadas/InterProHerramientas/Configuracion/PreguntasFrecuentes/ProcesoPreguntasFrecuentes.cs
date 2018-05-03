using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace InterProHerramientas.Configuracion.PreguntasFrecuentes.Proceso
{

    public class ProcesoPreguntasFrecuentes
    {
        Comunes.Navegadores navegadorPruba = new Comunes.Navegadores();
        Comunes.InterproteccionObjetos objetosPrueba = new Comunes.InterproteccionObjetos();
        Comunes.CargaDatosPrueba datosPrueba = new Comunes.CargaDatosPrueba();
        LogIn.ElementosLogIn elementosLogInPrueba = new LogIn.ElementosLogIn();
        LogIn.ElementosMenuPrincipal menuPrincipal = new LogIn.ElementosMenuPrincipal();
        Elementos.ElementosPreguntasFrecuentes elementosPreguntasFrecuentesPrueba = new Elementos.ElementosPreguntasFrecuentes();
        Comunes.GeneracionCadenas cadena = new Comunes.GeneracionCadenas();

        //Metodo que regresa el resultado de la prueba "dar de alta una pregunta frecuente", recibe como parametro el path del archivo que contiene los datos de prueba
        public bool ProcesoAltaPreguntaCamposObligatorios(string pathArchivo)
        {
            //Declaracion de variables praa el control del resultado, driver para webdriver, listado de datos de prueba y total de elementos en la prueba
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPreguntasFrecuentes(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                //Se itera el número de veces que exista la prueba en el archivo
                for (int i = 0; i < elementos; i++)
                {
                    //Se valida si el casode prueba a probar
                    if (listaDatosPrueba[i].TestCase.Equals("Alta_Exitosa_PreguntaCamposObligatorios"))
                    {
                        //Se lanza el navegador y se ingresa con usuario y contraseña validos a WEB ID
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        //Se accede al menu principal y posteriormente al menu de Preguntas y respuesta
                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPreguntasFrecuentes(driver).Click();
                        Thread.Sleep(3000);

                        //Se selecciona el bton para agregar una pregunta
                        elementosPreguntasFrecuentesPrueba.ElementosPreguntasAgregarPreguntaYRespuesta(driver).Click();

                        //Se capturan los datos de la prueba para realizar el alta de la preguntas frecuentes
                        SelectElement select = new SelectElement(elementosPreguntasFrecuentesPrueba.ElementosPreguntasListaCategoria(driver));
                        select.SelectByText(listaDatosPrueba[i].Categoria);

                        if (listaDatosPrueba[i].Activar.Equals("true"))
                        {
                            elementosPreguntasFrecuentesPrueba.ElementosPreguntasActivarPregunta(driver).Click();
                        }

                        elementosPreguntasFrecuentesPrueba.ElementosPreguntasTextoPregunta(driver).SendKeys(listaDatosPrueba[i].Pregunta);
                        elementosPreguntasFrecuentesPrueba.ElementosPreguntasTextoRespuesta(driver).SendKeys(listaDatosPrueba[i].Respuesta);
                        elementosPreguntasFrecuentesPrueba.ElementosPreguntasCrearPregunta(driver).Click();

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            elementosPreguntasFrecuentesPrueba.ElementosPreguntaPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosPreguntasFrecuentesPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosPreguntasFrecuentesPrueba.ElementosPreguntaRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].Pregunta))
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


        //Metodo que regresa el resultado de la prueba "dar de alta una pregunta frecuente", recibe como parametro el path del archivo que contiene los datos de prueba
        public bool ProcesoEditarPregunta(string pathArchivo)
        {
            //Declaracion de variables praa el control del resultado, driver para webdriver, listado de datos de prueba y total de elementos en la prueba
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosPreguntasFrecuentes(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            try
            {
                //Se itera el número de veces que exista la prueba en el archivo
                for (int i = 0; i < elementos; i++)
                {
                    //Se valida si el casode prueba a probar
                    if (listaDatosPrueba[i].TestCase.Equals("Editar_Pregunta"))
                    {
                        //Se lanza el navegador y se ingresa con usuario y contraseña validos a WEB ID
                        driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                        driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                        elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                        elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                        elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                        Thread.Sleep(3000);

                        //Se accede al menu principal y posteriormente al menu de Preguntas y respuesta
                        menuPrincipal.ElementoMenu(driver, 6).Click();
                        Thread.Sleep(3000);
                        menuPrincipal.ElementoSubMenuPreguntasFrecuentes(driver).Click();
                        Thread.Sleep(3000);

                        int pagina = 1;
                        var buscar = true;
                        while (buscar)
                        {
                            elementosPreguntasFrecuentesPrueba.ElementosPreguntaPaginado(driver, pagina).Click();
                            Thread.Sleep(2000);
                            for (int indice = 1; indice <= elementosPreguntasFrecuentesPrueba.ElementosEmpleadosNumeroRegistros(driver, pagina); indice++)
                            {
                                if (elementosPreguntasFrecuentesPrueba.ElementosPreguntaRegistro(driver, indice).Text.Equals(listaDatosPrueba[i].Pregunta))
                                {
                           
                                    //Seleccionamos la pregunta que se va a editar
                                    elementosPreguntasFrecuentesPrueba.ElementosPeguntaEditarRegistro(driver, indice).Click();

                                    int elemPos = ((elementosPreguntasFrecuentesPrueba.ElementosPreguntasEstatusPregunta(driver, listaDatosPrueba[i].Pregunta)).Location.Y) - 100;
                                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, " + elemPos + ");");

                                    //Se capturan los datos de la prueba para realizar el alta de la preguntas frecuentes
                                    SelectElement select = new SelectElement(elementosPreguntasFrecuentesPrueba.ElementosPreguntasListaCategoria(driver));
                                    select.SelectByText(listaDatosPrueba[i].Categoria);

                                    if (listaDatosPrueba[i].Activar.Equals("true"))
                                    {
                                        elementosPreguntasFrecuentesPrueba.ElementosPreguntasActivarPregunta(driver).Click();
                                    }
                                    
                                    elementosPreguntasFrecuentesPrueba.ElementosPreguntasTextoPregunta(driver).SendKeys(listaDatosPrueba[i].PreguntaEditada);
                                    elementosPreguntasFrecuentesPrueba.ElementosPreguntasTextoRespuesta(driver).SendKeys(listaDatosPrueba[i].Respuesta);
                                    elementosPreguntasFrecuentesPrueba.ElementosPreguntasCrearPregunta(driver).Click();

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
