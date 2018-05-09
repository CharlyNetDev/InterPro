using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace InterProHerramientas.Clientes.Elementos
{

    public class ElementosClientes
    {
        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteAgregar(IWebDriver driver)
        {
            //Identificar el elemento Agregar un cliente nuevo.
            IWebElement agregarCliente = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return agregarCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteGuardar(IWebDriver driver)
        {
            //Identificar el elemento Guardar un cliente.
            IWebElement guardarCliente = driver.FindElement(By.Id("btn-crear"));
            return guardarCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteCancelar(IWebDriver driver)
        {
            //Identificar el elemento para cancelar el proceso de Actualización y creación de un cliente.
            IWebElement cancelarCliente = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return cancelarCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteApellidoPaterno(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el apellido paterno del cliente.
            IWebElement apellidoPaternoCliente = driver.FindElement(By.XPath("ApPaterno"));
            return apellidoPaternoCliente;
        }


        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteApellidoMaterno(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el apellido materno del cliente.
            IWebElement apellidoPaternoMaterno = driver.FindElement(By.Id("ApMaterno"));
            return apellidoPaternoMaterno;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClientePrimerNombre(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el primer nombre del cliente.
            IWebElement primerNombre = driver.FindElement(By.Id("PrimerNombre"));
            return primerNombre;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClientePrimerSegundoNombre(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el segundo nombre del cliente.
            IWebElement sgundoNombre = driver.FindElement(By.Id("SegundoNombre"));
            return sgundoNombre;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteFechaNacimiento(IWebDriver driver)
        {
            //Identificar el elemento para Agregar la fecha de nacimiento del cliente.
            IWebElement fechaNacimiento = driver.FindElement(By.Id("fecha-picker"));
            return fechaNacimiento;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteCorreoPrincipal(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el correo principal del cliente.
            IWebElement correoPrincipal = driver.FindElement(By.Id("CorreoElectronicoPrincipal"));
            return correoPrincipal;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteCorreoSecundario(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el correo secundario del cliente.
            IWebElement correoSecundario = driver.FindElement(By.Id("CorreoElectronicoAlternativo"));
            return correoSecundario;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteRFC(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el RFC secundario del cliente.
            IWebElement rcfCliente = driver.FindElement(By.Id("Rfc"));
            return rcfCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteCURP(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el RFC secundario del cliente.
            IWebElement curpCliente = driver.FindElement(By.Id("Curp"));
            return curpCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteTelefonoCasa(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el RFC secundario del cliente.
            IWebElement telefonoCasa = driver.FindElement(By.Id("TelefonoCasa"));
            return telefonoCasa;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteTelefonoCelular(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el Telefono del cliente.
            IWebElement telefonoCelular = driver.FindElement(By.Id("TelefonoCelular"));
            return telefonoCelular;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteCalleyNumero(IWebDriver driver)
        {
            //Identificar el elemento para Agregar la Calle y número del cliente.
            IWebElement calleNumero = driver.FindElement(By.Id("CalleNumero"));
            return calleNumero;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteCodigoPostal(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el código postal del cliente.
            IWebElement codigoPostal = driver.FindElement(By.Id("CodigoPostal"));
            return codigoPostal;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteEstado(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el código postal del cliente.
            IWebElement codigoPostal = driver.FindElement(By.Id("Estado"));
            return codigoPostal;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteCiudad(IWebDriver driver)
        {
            //Identificar el elemento para Agregar la ciudad del cliente.
            IWebElement ciudadCliente = driver.FindElement(By.Id("Ciudad"));
            return ciudadCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteDelegacionMunicipio(IWebDriver driver)
        {
            //Identificar el elemento para Agregar el Municipio del cliente.
            IWebElement municipioDelegacionCliente = driver.FindElement(By.Id("Municipio"));
            return municipioDelegacionCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteDelegacionColonia(IWebDriver driver)
        {
            //Identificar el elemento para Agregar la Colonia del cliente.
            IWebElement coloniaCliente = driver.FindElement(By.Id("Colonia"));
            return coloniaCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClientePestanaDatosUsuario(IWebDriver driver)
        {
            //Identificar el elemento para seleccionar los datos del usuario.
            IWebElement datosUsusarioCliente = driver.FindElement(By.Id("datos-tab"));
            return datosUsusarioCliente;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteSeleccionarPlan(IWebDriver driver, string plan)
        {
            //Identificar el elemento para seleccionar los datos del usuario.
            IWebElement tipoPlan = driver.FindElement(By.Id("datos-tab"));
            return tipoPlan;
        }

        //Metodo para identificar elementos de de la sección de clientes.
        public IWebElement ElementosClienteBuscarClienteNombre(IWebDriver driver)
        {
            //Identificar el elemento para buscar a un cliente Nombre del cliente.
            IWebElement buscarCliente = driver.FindElement(By.Id("NombreCliente"));
            return buscarCliente;
        }

        //Metodo para identificar elementos de de la sección de cliente.
        public IWebElement ElementosClienteBuscarClienteRFC(IWebDriver driver)
        {
            //Identificar el elemento para buscar a un cliente por RFC.
            IWebElement buscarCliente = driver.FindElement(By.Id("Rfc"));
            return buscarCliente;
        }

        //Metodo para identificar elementos de de la sección de cliente.
        public IWebElement ElementosClienteBuscarClienteTelefono(IWebDriver driver)
        {
            //Identificar el elemento para buscar a un cliente por telefono.
            IWebElement buscarCliente = driver.FindElement(By.Id("Telefono"));
            return buscarCliente;
        }

        //Metodo para identificar elementos de de la sección de cliente.
        public IWebElement ElementosClienteBuscarClienteCorreo(IWebDriver driver)
        {
            //Identificar el elemento para buscar a un cliente por correo.
            IWebElement buscarCliente = driver.FindElement(By.Id("Correo"));
            return buscarCliente;
        }

        //Metodo para identificar elementos de de la sección de cliente.
        public IWebElement ElementosClienteBuscarClienteTipoCliente(IWebDriver driver, int numeroTipo)
        {
            //Identificar el elemento para buscar a un cliente por correo.
            IWebElement buscarCliente = driver.FindElement(By.Id("//*[@id='form-buscarclientes']/div[2]/div[3]/div/label[" + numeroTipo + "]"));
            return buscarCliente;
        }
    }
}
