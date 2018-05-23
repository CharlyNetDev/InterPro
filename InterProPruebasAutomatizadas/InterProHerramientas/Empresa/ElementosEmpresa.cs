using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace InterProHerramientas.Empresa.Elementos
{
    public class ElementosEmpresa
    {

        /********************************************************/
        // SECCION DE CREAR NUEVA EMPRESA
        /********************************************************/

        #region CREAR NUEVA EMPRESA
        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaAgregar(IWebDriver driver)
        {
            //Identificar el elemento Agregar una Empresa nuevo.
            IWebElement agregarEmpresa = driver.FindElement(By.XPath("//div[3]/a"));
            return agregarEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaGuardar(IWebDriver driver)
        {
            //Identificar el elemento Guardar una Empresa nuevo.
            IWebElement guardarEmpresa = driver.FindElement(By.Id("btn-crear"));
            return guardarEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaCancelar(IWebDriver driver)
        {
            //Identificar el elemento Cancelar una Empresa nuevo.
            IWebElement cancelarEmpresa = driver.FindElement(By.XPath("//div[2]/div[2]/a"));
            return cancelarEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaNombre(IWebDriver driver)
        {
            //Identificar el elemento para capturar el nombre de una Empresa.
            IWebElement nombreEmpresa = driver.FindElement(By.Id("empresa_NombreEmpresa"));
            return nombreEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaDireccion(IWebDriver driver)
        {
            //Identificar el elemento para capturar la direccion de una Empresa.
            IWebElement direccionEmpresa = driver.FindElement(By.Id("empresa_DireccionCompleta"));
            return direccionEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaTipoEmpresa(IWebDriver driver)
        {
            //Identificar el elemento seleccionar el tipo de la Empresa.
            IWebElement tipoEmpresa = driver.FindElement(By.XPath("//div[2]/input"));
            return tipoEmpresa;
        }

        public IWebElement ElementoEmpresaTipoBanco(IWebDriver driver)
        {
            //Identificar el elemento seleccionado de tipo Banco
            IWebElement tipoBanco = driver.FindElement(By.XPath("//div[3]/input"));
            return tipoBanco;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaRFC(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement rfcEmpresa = driver.FindElement(By.Id("empresa_RFC"));
            return rfcEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaNombreContatoUno(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement contactoEmpresaUno = driver.FindElement(By.Id("empresa_NombreContacto"));
            return contactoEmpresaUno;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaCorreoContatoUno(IWebDriver driver)
        {
            //Identificar el elemento para capturar el Correo electrónico.
            IWebElement correoContactoEmpresaUno = driver.FindElement(By.Id("empresa_CorreoElectronicoContacto"));
            return correoContactoEmpresaUno;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaTelefonoContatoUno(IWebDriver driver)
        {
            //Identificar el elemento para capturar el Teléfono.
            IWebElement telefonoContactoEmpresaUno = driver.FindElement(By.Id("empresa_TelefonoContacto"));
            return telefonoContactoEmpresaUno;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaNombreContatoDos(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement contactoEmpresaDos = driver.FindElement(By.Id("empresa_NombreContactoDos"));
            return contactoEmpresaDos;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaCorreoContatoDos(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement correoContactoEmpresaDos = driver.FindElement(By.Id("empresa_CorreoElectronicoContactoDos"));
            return correoContactoEmpresaDos;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaTelefonoContatoDos(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement telefonoContactoEmpresaDos = driver.FindElement(By.Id("empresa_TelefonoContactoDos"));
            return telefonoContactoEmpresaDos;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaNombreContatoTres(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement contactoEmpresaTres = driver.FindElement(By.Id("empresa_NombreContactoTres"));
            return contactoEmpresaTres;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaCorreoContatoTres(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement correoContactoEmpresaTres = driver.FindElement(By.Id("empresa_CorreoElectronicoContactoTres"));
            return correoContactoEmpresaTres;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaTelefonoContatoTres(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement telefonoContactoEmpresaTres = driver.FindElement(By.Id("empresa_TelefonoContactoTres"));
            return telefonoContactoEmpresaTres;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaNotas(IWebDriver driver)
        {
            //Identificar el elemento para capturar el RFC de una Empresa.
            IWebElement telefonoContactoNotas = driver.FindElement(By.Id("empresa_Notas"));
            return telefonoContactoNotas;
        }
        #endregion

        /********************************************************/
        //ELEMENTOS PARA LA CONSULTA DE CLIENTES Y EMPRESAS
        /********************************************************/

        #region ELEMENTOS PARA LA CONSULTA DE CLIENTES Y EMPRESAS
        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaPestanaEmpresa(IWebDriver driver)
        {
            //Identificar el elemento para seleccionar la pastaña de la Empresa.
            IWebElement pestanaEmpresa = driver.FindElement(By.Id("empresa-tab"));
            return pestanaEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaCampoBusquedaEmpresa(IWebDriver driver)
        {
            //Identificar el elemento para capturar el nombre de la empresa a buscar.
            IWebElement busquedaNombreEmpresa = driver.FindElement(By.Id("NombreEmpresa"));
            return busquedaNombreEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaCampoBusquedaContacto(IWebDriver driver)
        {
            //Identificar el elemento para capturar el nombre de la empresa a buscar.
            IWebElement busquedaEmpresaContacto = driver.FindElement(By.Id("NombreContacto"));
            return busquedaEmpresaContacto;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaFiltroTipoEmpresa(IWebDriver driver)
        {
            //Identificar el elemento para capturar el nombre de la empresa a buscar.
            IWebElement busquedaTipoEmpresa = driver.FindElement(By.Id("EsEmpresa"));
            return busquedaTipoEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaFiltroTipoBanco(IWebDriver driver)
        {
            //Identificar el elemento para capturar el nombre de la empresa a buscar.
            IWebElement busquedaTipoEmpresa = driver.FindElement(By.Id("EsBanco"));
            return busquedaTipoEmpresa;
        }

        //Metodo para identificar elementos de de la sección de empresas.
        public IWebElement ElementoEmpresaConsultar(IWebDriver driver)
        {
            //Identificar el elemento para capturar el nombre de la empresa a buscar.
            IWebElement consultarEmpresa = driver.FindElement(By.XPath("//div[2]/button"));
            return consultarEmpresa;
        }
        public IWebElement ElementoEmpresaRegresarDeConsulta(IWebDriver driver)
        {
            //Identificar el elemento para capturar el nombre de la empresa a buscar.
            IWebElement regresarDeConsultaEmpresa = driver.FindElement(By.XPath("//div[2]/div[2]/a"));
            return regresarDeConsultaEmpresa;
        }

        #endregion

        /********************************************************/
        //ELEMENTOS PARA GENERAR CÓDIGOS DE ACTIVACIÓN - EMPRESAS
        /********************************************************/

        #region ELEMENTOS PARA GENERAR CÓDIGOS DE ACTIVACIÓN - EMPRESAS
        //Metodo para identificar elementos de PESTAÑA GENERAR CÓDIGOS DE ACTIVACIÓN
        public IWebElement ElementoEmpresaGenerarCodigosActivacionSeccionGenerarCodigoActivacion(IWebDriver driver)
        {
            IWebElement seccionGenerarCodigoActivacion = driver.FindElement(By.Id("contact-tab"));
            return seccionGenerarCodigoActivacion;
        }

        //Metodo para identificar elementos de CODIGO FIJO
        public IWebElement ElementoEmpresaGenerarCodigosActivacionCodigoFijo(IWebDriver driver)
        {
            IWebElement codigoFijo = driver.FindElement(By.Id("TipoCodigoFijo"));
            return codigoFijo;
        }

        //Metodo para identificar elementos de CODIGO FIJO - CANTIDAD DE CLAVES GENERAR
        public IWebElement ElementoEmpresaGenerarCodigosActivacionCantidadClaves(IWebDriver driver)
        {
            IWebElement cantidadClaves = driver.FindElement(By.Id("codigoLote-cantidad"));
            return cantidadClaves;
        }

        //Metodo para identificar elementos de CODIGO FIJO - TIPO PLAN
        public IWebElement ElementoEmpresaGenerarCodigosActivacionTipoPlan(IWebDriver driver)
        {
            IWebElement tipoPlan = driver.FindElement(By.Id("GuidTipoPlan"));
            return tipoPlan;
        }

        //Metodo para identificar elementos de CODIGO FIJO - TIENE SERVICIO DESDE
        public IWebElement ElementoEmpresaGenerarCodigosActivacionServicioDesde(IWebDriver driver)
        {
            IWebElement x = driver.FindElement(By.Id("fecha-picker2"));
            return x;
        }

        //Metodo para identificar elementos de CODIGO FIJO - TIENE SERVICIO HASTA
        public IWebElement ElementoEmpresaGenerarCodigosActivacionServicioHasta(IWebDriver driver)
        {
            IWebElement servicioHasta = driver.FindElement(By.Id("fecha-picker3"));
            return servicioHasta;
        }

        //Metodo para identificar elementos de CODIGO MOVIL - TIPO PLAN
        public IWebElement ElementoEmpresaGenerarCodigosActivacionCodigoMovil(IWebDriver driver)
        {
            IWebElement codigoMovil = driver.FindElement(By.Id("TipoCodigoMovil"));
            return codigoMovil;
        }

        //Metodo para identificar elementos de CODIGO MOVIL - TIENE SERVICIO HASTA
        public IWebElement ElementoEmpresaGenerarCodigosActivacionActivarAntesDel(IWebDriver driver)
        {
            IWebElement activarAntesDel = driver.FindElement(By.Id("fecha-picker"));
            return activarAntesDel;
        }

        //Metodo para identificar elementos de CODIGO MOVIL - TIENE SERVICIO HASTA
        public IWebElement ElementoEmpresaGenerarCodigosActivacionPeriodoVigencia(IWebDriver driver)
        {
            IWebElement periodoVigencia = driver.FindElement(By.Id("GuidPeriodo"));
            return periodoVigencia;
        }

        //Metodo para identificar elementos de BOTÓN - GENERAR
        public IWebElement ElementoEmpresaGenerarCodigosActivacionBotonGenerarCodigoActivacion(IWebDriver driver)
        {
            IWebElement botonGenerarCodigoAvtivacion = driver.FindElement(By.Id("GuidPeriodo"));
            return botonGenerarCodigoAvtivacion;
        }
        #endregion

    }
}
