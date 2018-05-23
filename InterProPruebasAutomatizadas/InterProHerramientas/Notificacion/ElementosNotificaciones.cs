using OpenQA.Selenium;

namespace InterProHerramientas.Notificaciones.Elementos
{
    public class ElementosNotificaciones
    {
        public IWebElement ElementosNotificacionesGenerar(IWebDriver driver)
        {
            IWebElement generarNotificación = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return generarNotificación;
        }

        public IWebElement ElementosNotificacionesMensaje(IWebDriver driver)
        {
            IWebElement mensajeNotificación = driver.FindElement(By.Id("Mensaje"));
            return mensajeNotificación;
        }

        public IWebElement ElementosNotificacionesCancelar(IWebDriver driver)
        {
            IWebElement cancelarNotificación = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return cancelarNotificación;
        }

        public IWebElement ElementosNotificacionesEnviar(IWebDriver driver)
        {
            IWebElement enviarNotificación = driver.FindElement(By.Id("btn-crear"));
            return enviarNotificación;
        }

        public IWebElement ElementosNotificacionesSeleccionBancos(IWebDriver driver)
        {
            IWebElement seleccionarBancosNotificación = driver.FindElement(By.Id("bancos-tab"));
            return seleccionarBancosNotificación;
        }

        public IWebElement ElementosNotificacionesSeleccionEmpresas(IWebDriver driver)
        {
            IWebElement seleccionarEmpresasNotificación = driver.FindElement(By.Id("empresas-tab"));
            return seleccionarEmpresasNotificación;
        }

        public IWebElement ElementosNotificacionesSeleccionPlanes(IWebDriver driver)
        {
            IWebElement seleccionarEmpresasNotificación = driver.FindElement(By.Id("planes-tab"));
            return seleccionarEmpresasNotificación;
        }

        public IWebElement ElementosNotificacionesTodosBancos(IWebDriver driver)
        {
            IWebElement todosBancosNotificación = driver.FindElement(By.ClassName("ckbox"));
            return todosBancosNotificación;
        }

        public IWebElement ElementosNotificacionesTodosEmpresas(IWebDriver driver)
        {
            IWebElement todosEmpresasNotificación = driver.FindElement(By.XPath("//*[@id='empresas']/label[1]/span"));
            return todosEmpresasNotificación;
        }

        public IWebElement ElementosNotificacionesTodosPlanes(IWebDriver driver)
        {
            IWebElement todosPlanesNotificación = driver.FindElement(By.XPath("//*[@id='planes']/label[1]/span"));
            return todosPlanesNotificación;
        }

        public IWebElement ElementosNotificacionesProgramar(IWebDriver driver)
        {
            IWebElement progamarPlanes = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div[3]/div[2]/label/span"));
            return progamarPlanes;
        }


        public IWebElement ElementosNotificacionesFecha(IWebDriver driver)
        {
            IWebElement fechaPlanes = driver.FindElement(By.Id("fecha-picker"));
            return fechaPlanes;
        }

        public IWebElement ElementosNotificacionesHora(IWebDriver driver)
        {
            IWebElement horaPlanes = driver.FindElement(By.Id("tiempo-picker"));
            return horaPlanes;
        }

        public IWebElement ElementosNotificacionesPaginado(IWebDriver driver, int pagina)
        {
            IWebElement paginaNotificacion = driver.FindElement(By.XPath("//*[@id='tabla-notificaciones_paginate']/span/a[" + pagina + "]"));
            return paginaNotificacion;
        }

        public IWebElement ElementosNotificacionesResgistro(IWebDriver driver, int registro)
        {
            IWebElement registroCapturado = driver.FindElement(By.XPath("//*[@id='tabla-notificaciones']/tbody/tr[" + registro + "]/td[3]"));
            return registroCapturado;
        }

        public int ElementosNotificacionesNumeroRegistros(IWebDriver driver, int pagina)
        {
            var totalRegistros = driver.FindElements(By.XPath("//*[@id='tabla-notificaciones']/tbody/tr[' ']/td[1]"));
            return totalRegistros.Count;
        }

        public IWebElement ElementosNotificacionesMensajeValidacion(IWebDriver driver)
        {
            IWebElement mensajeAlerta = driver.FindElement(By.Id("lbl-mensaje"));
            return mensajeAlerta;
        }

        public IWebElement ElementosNotificacioneDestinatarioValidacion(IWebDriver driver)
        {
            IWebElement mensajeAlerta = driver.FindElement(By.Id("div-alerta"));
            return mensajeAlerta;
        }
        //div-alerta
    }
}
