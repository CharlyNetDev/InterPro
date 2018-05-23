using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using InterProHerramientas.LogIn;
using System.Threading;
using InterProHerramientas.Empresa.Elementos;
using OpenQA.Selenium.Support.UI;


namespace InterProHerramientas.Empresa
{
    public class ProcesoEmpresa
    {
        /*******************************************/
        // ALTA DE VARIABLES
        /*******************************************/
        int TiempoBasico = 2500;
        int TiempoMedio = 3500;
        int TiempoAlto = 5000;

        /*******************************************/
        // CREAR INSTANCIAS
        /*******************************************/
        Comunes.Navegadores navegadorPruba = new Comunes.Navegadores();
        Comunes.InterproteccionObjetos objetosPrueba = new Comunes.InterproteccionObjetos();
        Comunes.CargaDatosPrueba datosPrueba = new Comunes.CargaDatosPrueba();
        ElementosLogIn elementosLogInPrueba = new ElementosLogIn();
        ElementosMenuPrincipal menuPrincipal = new ElementosMenuPrincipal();
        ElementosEmpresa elementosEmpresa = new ElementosEmpresa();
        Comunes.GeneracionCadenas cadena = new Comunes.GeneracionCadenas();

        /*******************************************/
        // CREAR EXITOSAMENTE UNA EPRESA
        /*******************************************/
        public bool A001_AltaEmpresaTodosLosDatos(string pathArchivo)
        {
            bool resultado = false;
            IWebDriver driver = null;
            var listaDatosPrueba = datosPrueba.CargaDatosClientes(pathArchivo);
            var elementos = listaDatosPrueba.Count;

            for (int i = 0; i < elementos; i++)
            {
                if (listaDatosPrueba[0].TestCase.Equals("Alta_Exitosa_AltaEmpresaTodosLosDatos"))
                {

                    driver = navegadorPruba.LanzarNavegador(listaDatosPrueba[i]);
                    driver.Navigate().GoToUrl(listaDatosPrueba[i].Url);
                    elementosLogInPrueba.UsuarioWEPID(driver).SendKeys(listaDatosPrueba[i].Usuario);
                    elementosLogInPrueba.ContraseniaWEPID(driver).SendKeys(listaDatosPrueba[i].Contrasenia);
                    elementosLogInPrueba.ContraseniaWEPID(driver).Submit();
                    // Esperar a que se cargue la página. 
                    Thread.Sleep(TiempoMedio);


                    // MENÚ PRINCIPAL DONDE SE SELECCIONA LA OPCION DE "CLIENTES"
                    menuPrincipal.ElementoMenu(driver, 2).Click();
                    // Esperar a que se cargue la página. 
                    Thread.Sleep(TiempoMedio);

                    // DAR CLIC AL BOTÓN "AGREGAR CLIENTE INDIVIDUAL"
                    elementosEmpresa.ElementoEmpresaAgregar(driver).Click();
                    // Esperar a que se cargue la página. 
                    Thread.Sleep(TiempoBasico);

                    // CREAR EMPRESA - LOS CAMPOS DEL MÓDULO
                    // CREAR EMPRESA - GENERALES
                    elementosEmpresa.ElementoEmpresaNombre(driver).SendKeys(listaDatosPrueba[i].EmpresaNombre);
                    elementosEmpresa.ElementoEmpresaDireccion(driver).SendKeys(listaDatosPrueba[i].EmpresaDireccion);
                    elementosEmpresa.ElementoEmpresaRFC(driver).SendKeys(listaDatosPrueba[i].EmpresaRFC);
                    // VALIDAR SI ES TIPO "EMPRESA" O "BANCO"
                    if (listaDatosPrueba[i].EmpresaTipoEmpresa.Equals("Si"))
                    {
                        elementosEmpresa.ElementoEmpresaTipoEmpresa(driver).SendKeys(listaDatosPrueba[i].EmpresaTipoEmpresa);
                    }
                    else
                    {
                        elementosEmpresa.ElementoEmpresaTipoBanco(driver).SendKeys(listaDatosPrueba[i].EmpresaTipoBanco);
                    }
                    // CREAR EMPRESA - CONTACTOS
                    elementosEmpresa.ElementoEmpresaNombreContatoUno(driver).SendKeys(listaDatosPrueba[i].EmpresaNombreContatoUno);
                    elementosEmpresa.ElementoEmpresaCorreoContatoUno(driver).SendKeys(listaDatosPrueba[i].EmpresaCorreoContatoUno);
                    elementosEmpresa.ElementoEmpresaNombreContatoDos(driver).SendKeys(listaDatosPrueba[i].EmpresaNombreContatoDos);
                    elementosEmpresa.ElementoEmpresaCorreoContatoDos(driver).SendKeys(listaDatosPrueba[i].EmpresaCorreoContatoDos);
                    elementosEmpresa.ElementoEmpresaNombreContatoTres(driver).SendKeys(listaDatosPrueba[i].EmpresaNombreContatoTres);
                    elementosEmpresa.ElementoEmpresaCorreoContatoTres(driver).SendKeys(listaDatosPrueba[i].EmpresaCorreoContatoTres);
                    // CREAR EPRESA - NOTAS
                    elementosEmpresa.ElementoEmpresaNotas(driver).SendKeys(listaDatosPrueba[i].EmpresaNotas);

                    // GUARDAR EMPRESA
                    elementosEmpresa.ElementoEmpresaGuardar(driver).Click();
                    // Esperar. 
                    Thread.Sleep(TiempoBasico);

                    // GENERAR CÓDIGOS DE ACTIVACIÓN
                    // SELECCIONAR TIPO DE CODIGO
                    elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionSeccionGenerarCodigoActivacion(driver).Click();
                    if (elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionCodigoFijo(driver).Equals("True"))
                    {
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionCodigoFijo(driver).Click();
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionCantidadClaves(driver).SendKeys(listaDatosPrueba[i].EmpresaGenerarCodigosActivacionCantidadClaves);
                        // Seleccionar un tipo de plan
                        SelectElement selectTipoPlan = new SelectElement(elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionTipoPlan(driver));
                        selectTipoPlan.SelectByText(listaDatosPrueba[i].EmpresaGenerarCodigosActivacionTipoPlan);
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionServicioDesde(driver).SendKeys(listaDatosPrueba[i].EmpresaGenerarCodigosActivacionServicioDesde);
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionServicioHasta(driver).SendKeys(listaDatosPrueba[i].EmpresaGenerarCodigosActivacionServicioHasta);
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionBotonGenerarCodigoActivacion(driver).Click();

                        // Validar si existe el Codigo Generado

                    }
                    else
                    {
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionCodigoMovil(driver).Click();
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionCantidadClaves(driver).SendKeys(listaDatosPrueba[i].EmpresaGenerarCodigosActivacionCantidadClaves);
                        // Seleccionar un tipo de plan
                        SelectElement selectTipoPlan = new SelectElement(elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionTipoPlan(driver));
                        selectTipoPlan.SelectByText(listaDatosPrueba[i].EmpresaGenerarCodigosActivacionTipoPlan);
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionActivarAntesDel(driver).SendKeys(listaDatosPrueba[i].EmpresaGenerarCodigosActivacionActivarAntesDel);
                        //Guarda los datos del plan 
                        elementosEmpresa.ElementoEmpresaGenerarCodigosActivacionBotonGenerarCodigoActivacion(driver).Click();

                        // Validar si existe el Codigo Generado
                    }

                    //////////////////////////////////////////
                    //////////////////////////////////////////
                    //////////////////////////////////////////
                    //////////////////////////////////////////
                    //////////////////////////////////////////
                    //////////////////////////////////////////
                    //////////////////////////////////////////
                    /////////////////////////////////////////////
                    //////////////////////////////////////////
                    //////////////////////////////////////////


                    //SelectElement select = new SelectElement(elementosClientes.ElementosClienteEstado(driver));
                    //select.SelectByText(listaDatosPrueba[i].Estado);


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
                }
            }

            return resultado;
        }
    }
}
