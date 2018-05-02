﻿using System;
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
            IWebElement fechaNacimiento  = driver.FindElement(By.Id("fecha-picker"));
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

    }
}
