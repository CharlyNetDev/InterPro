using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace InterProHerramientas.Clientes.Elementos
{

    public class ElementosClientes
    {
        /********************************************************/
        // SECCION DE CREAR NUEVO INDIVIDUO - INFORMACIÓN PERSONAL
        /********************************************************/

        #region CREAR NUEVO CLIENTE - INFORMACIÓN PERSONAL
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
            IWebElement apellidoPaternoCliente = driver.FindElement(By.Id("ApPaterno"));
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
        public IWebElement ElementosClienteSegundoNombre(IWebDriver driver)
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

        //Metodo para identificar el mes anterior
        public IWebElement ElementosClienteFechaNacimientoMesAnterior(IWebDriver driver)
        {
            //Identificar el elemento para Agregar la fecha de nacimiento del cliente.
            IWebElement fechaNacimiento = driver.FindElement(By.XPath("//*[@id='ui-datepicker-div']/div/a[1]"));
            return fechaNacimiento;
        }

        public IWebElement ElementosClienteFechaNacimientoMesSiguiente(IWebDriver driver)
        {
            //Identificar el elemento para Agregar la fecha de nacimiento del cliente.
            IWebElement fechaNacimiento = driver.FindElement(By.XPath("//*[@id='ui-datepicker-div']/div/a[2]"));
            return fechaNacimiento;
        }

        public IWebElement ElementosClienteFechaNacimientoDia(IWebDriver driver)
        {
            //Identificar el elemento para Agregar la fecha de nacimiento del cliente.
            IWebElement fechaNacimiento = driver.FindElement(By.XPath("//*[@id='ui-datepicker-div']/table/tbody"));
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
            IWebElement codigoPostal = driver.FindElement(By.Id("selectEstados"));
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
        #endregion

        /********************************************************/
        // SECCION DE CREAR NUEVO INDIVIDUO - DATOS DE USUARIO
        /********************************************************/

        #region SECCION DE CREAR NUEVO INDIVIDUO - DATOS DE USUARIO

        // PLAN

        //Metodo para identificar elementos de de la sección de DATOS DE USUARIO.
        public IWebElement ElementosClientePestanaDatosUsuario(IWebDriver driver)
        {
            //Identificar el elemento para seleccionar los datos del usuario.
            IWebElement datosUsusarioCliente = driver.FindElement(By.Id("datos-tab"));
            return datosUsusarioCliente;
        }

        //Metodo para identificar elementos de de la sección de DATOS DE USUARIO.
        public IList<IWebElement> ElementosClienteNumeroPlanes(IWebDriver driver)
        {
            //Identificar el elemento para seleccionar el tipo de plan.
            //IWebElement tipoPlan = driver.FindElement(By.XPath("//input"));
            ////*[@id="datos-usuario"]/div/div[2]/label/span
            ////*[@id="datos-usuario"]/div
            //IWebElement tipoPlan = driver.FindElement(By.XPath("//*[@id='datos-usuario']/div/div[2]/label/span"));
            IList<IWebElement> tipoPlan = driver.FindElements(By.XPath("//*[@id='datos-usuario']/div/div[' ']"));
            return tipoPlan;
        }

        //Seleccionar el plan de acuerdo al data pool
        public IWebElement ElementosClienteSeleccionarPlan(IWebDriver driver, int registro)
        {
            IWebElement tipoPlan = driver.FindElement(By.XPath("//*[@id='datos-usuario']/div/div[" + registro + "]/label"));
            return tipoPlan;
        }

        // FORMA DE PAGO

        //AGREGAR NUEVA FORMA DE PAGO - AGREGAR NUEVA FORMA DE PAGO
        public IWebElement ElementosClienteFormaPagoAgregarNueva(IWebDriver driver, int i)
        {
            IWebElement agregarNuevaFormaPago = driver.FindElement(By.XPath("//tr[" + i + "]/th/label/span"));
            return agregarNuevaFormaPago;
        }

        //AGREGAR NUEVA FORMA DE PAGO - NÚMERO DE TARJETA DE DÉBITO O CREDITO
        public IWebElement ElementosClienteFormaPagoNumeroTarjeta(IWebDriver driver)
        {
            IWebElement numeroTarjeta = driver.FindElement(By.Id("numero-tarjeta"));
            return numeroTarjeta;
        }

        //AGREGAR NUEVA FORMA DE PAGO - VENCIMIENTO - MM
        public IWebElement ElementosClienteFormaPagoVencimientoMM(IWebDriver driver)
        {
            IWebElement vencimientoMM = driver.FindElement(By.Id("mes-tarjeta"));
            return vencimientoMM;
        }

        //AGREGAR NUEVA FORMA DE PAGO - VECIMIENTO - AA
        public IWebElement ElementosClienteFormaPagoVencimientoAA(IWebDriver driver)
        {
            IWebElement vencimientoAA = driver.FindElement(By.Id("anio-tarjeta"));
            return vencimientoAA;
        }

        //AGREGAR NUEVA FORMA DE PAGO - CVV
        public IWebElement ElementosClienteFormaPagoCVV(IWebDriver driver)
        {
            IWebElement cvv = driver.FindElement(By.Id("cvv-tarjeta"));
            return cvv;
        }

        //AGREGAR NUEVA FORMA DE PAGO - NOMBRE DEL DUEÑO DE LA TARJETA
        public IWebElement ElementosClienteFormaPagoNombreDuenioTarjeta(IWebDriver driver)
        {
            IWebElement nombreDuenioTarjeta = driver.FindElement(By.Id("duenio-tarjeta"));
            return nombreDuenioTarjeta;
        }

        //AGREGAR NUEVA FORMA DE PAGO - AGREGAR FORMA DE PAGO
        public IWebElement ElementosClienteFormaPagoBotonAgregar(IWebDriver driver)
        {
            IWebElement botonAgregar = driver.FindElement(By.Id("btn-openpay"));
            return botonAgregar;
        }
        #endregion

        /********************************************************/
        // SECCION DE CLIENTES - CONSULTA INDIVIDUOS
        /********************************************************/

        #region SECCION DE CLIENTES - CONSULTA INDIVIDUOS
        //Identificar el elemento para la seccion INDIVIDUOS.
        public IWebElement ElementosConsutaClienteIndividuo(IWebDriver driver)
        {
            IWebElement individuo = driver.FindElement(By.Id("datos-tab"));
            return individuo;
        }

        //Identificar el elemento para NOMBRE DE CLIENTE
        public IWebElement ElementosConsutaClienteNombreCliente(IWebDriver driver)
        {
            IWebElement nombreCliente = driver.FindElement(By.Id("NombreCliente"));
            return nombreCliente;
        }
        //Identificar el elemento para TELÉFONO
        public IWebElement ElementosConsutaClienteTelefono(IWebDriver driver)
        {
            IWebElement telefono = driver.FindElement(By.Id("Telefono"));
            return telefono;
        }

        //Identificar el elemento para CORREO ELECTRÓNICO
        public IWebElement ElementosConsutaClienteCorreoElectronico(IWebDriver driver)
        {
            IWebElement correoElectronico = driver.FindElement(By.Id("Correo"));
            return correoElectronico;
        }

        //Identificar el elemento para RFC
        public IWebElement ElementosConsutaClienteRFC(IWebDriver driver)
        {
            IWebElement rfc = driver.FindElement(By.Id("Rfc"));
            return rfc;
        }

        //Identificar el elemento para FECHA DE NACIMIENTO
        public IWebElement ElementosConsutaClienteFechaNacimiento(IWebDriver driver)
        {
            IWebElement fechaNacimiento = driver.FindElement(By.Id("fecha-picker"));
            return fechaNacimiento;
        }

        //Identificar el elemento para TIPO CLIENTE - ES INDIVIDUAL
        public IWebElement ElementosConsutaClienteEsIndividual(IWebDriver driver)
        {
            IWebElement esIndividual = driver.FindElement(By.Id("//label[1]/span/label"));
            return esIndividual;
        }

        //Identificar el elemento para TIPO CLIENTE - PERTENECE A UNA EMPRESA
        public IWebElement ElementosConsutaClientePerteneceEmpresa(IWebDriver driver)
        {
            IWebElement perteneceEmpresa = driver.FindElement(By.Id("//label[2]/span/label"));
            return perteneceEmpresa;
        }

        //Identificar el elemento para TIPO CLIENTE - PERTENECE A UN BANCO
        public IWebElement ElementosConsutaClientePerteneceBanco(IWebDriver driver)
        {
            IWebElement perteneceBanco = driver.FindElement(By.Id("//label[3]/span/label"));
            return perteneceBanco;
        }

        //Identificar el elemento para el botón CONSULTAR
        public IWebElement ElementosConsutaClienteConsultar(IWebDriver driver)
        {
            IWebElement consultar = driver.FindElement(By.Id("div-consultar"));
            return consultar;
        }
        #endregion

        /********************************************************/
        // SECCION DE ESTADOS DE CUENTA
        /********************************************************/

        #region SECCION DE ESTADOS DE CUENTA
        //Identificar el elemento para la pestaña ESTADOS DE CUENTA.
        public IWebElement ElementosEstadosCuentaSeccion(IWebDriver driver)
        {
            IWebElement seccion = driver.FindElement(By.Id("estados-cuenta-tab"));
            return seccion;
        }

        //Identificar el elemento para la seccion PAGAR.
        public IWebElement ElementosEstadosCuentaBotonPagar(IWebDriver driver)
        {
            IWebElement botonPagar = driver.FindElement(By.Id("btn-pagar"));
            return botonPagar;
        }

        //Identificar el elemento para Pagar
        public IWebElement ElementosEstadosCuentaBotonConfirmarPagar(IWebDriver driver)
        {
            IWebElement botonConfirmarPagar = driver.FindElement(By.Id("btn-modal-confirmar"));
            return botonConfirmarPagar;
        }
        //
        #endregion
    }
}
