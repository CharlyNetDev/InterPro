using OpenQA.Selenium;
using System.Collections.Generic;

namespace InterProHerramientas.PlanesServicio.Elementos
{
    public class ElementosPlanServicio
    {
        public IWebElement ElementosPlanServicioBotonAgregarPlan(IWebDriver driver)
        {
            IWebElement agregarPlan = null;
            agregarPlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return agregarPlan;
        }

        public IWebElement ElementosPlanServiciAgregarPlan(IWebDriver driver)
        {
            IWebElement agregarPlan = driver.FindElement(By.Id("btn-crear"));
            return agregarPlan;
        }

        public IWebElement ElementosPlanServicioNombrePlan(IWebDriver driver)
        {
            IWebElement nombrePlan = null;
            nombrePlan = driver.FindElement(By.Id("NombrePlan"));
            return nombrePlan;
        }

        public IWebElement ElementosPlanServicioCostoPlan(IWebDriver driver)
        {
            IWebElement costoPlan = null;
            costoPlan = driver.FindElement(By.Name("Costo"));
            return costoPlan;
        }

        public IWebElement ElementosPlanServicioDescripcion(IWebDriver driver)
        {
            IWebElement descripcion = driver.FindElement(By.Id("Descripcion"));
            return descripcion;
        }
        
        //Metodo para identificar el serivicio de reporte Circulo de Credito
        public IWebElement ElementosPlanServicioCreditoReporte(IWebDriver driver)
        {
            IWebElement reporteCredito = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[4]/div/div/label[2]"));
            //(By.XPath("html/body/div[4]/div[1]/article/form/div/div[4]/div/label[2]"));
            return reporteCredito;
        }

        //Metodo para identificar el serivicio de circulo de Credito Alertas
        public IWebElement ElementosPlanServicioCreditoAlertas (IWebDriver driver)
        {
            IWebElement creditoAlertas = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[4]/div/div/label[4]"));
            //(By.XPath("html/body/div[4]/div[1]/article/form/div/div[4]/div/label[2]"));
            return creditoAlertas;
        }

        public IWebElement ElementosPlanServicioServiciosTarjeta(IWebDriver driver)
        {
            IWebElement tarjeta = driver.FindElement(By.XPath("html/body/div[4]/div[1]/article/form/div/div[4]/div/label[3]"));
            return tarjeta;
        }

        public IWebElement ElementosPlanServicioPaginado(IWebDriver driver, int pagina)
        {
            IWebElement paginado = driver.FindElement(By.XPath("//*[@id='tabla-planes_paginate']/span/a[" + pagina + "]"));
            return paginado;
        }

        public IWebElement ElementosPlanServicioRegistro(IWebDriver driver, int registro)
        {
            IWebElement registroCapturado = driver.FindElement(By.XPath("//*[@id='tabla-planes']/tbody/tr[" + registro + "]/td[2]"));
            return registroCapturado;
        }

        public int ElementosPlanServicioNumeroRegistros(IWebDriver driver, int pagina)
        {
            var totalRegistros = driver.FindElements(By.XPath("//*[@id='tabla-planes']/tbody/tr[' ']/td[2]"));
            return totalRegistros.Count;
        }

        public IWebElement ElementosPlanServicioMensajeNombre(IWebDriver driver)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[1]/div/div/span[2]"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioMensajeDescripcion(IWebDriver driver)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[3]/div/div/span"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioMensajeServicios(IWebDriver driver)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[4]/div/div/span"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioMensajeLongitudNombre(IWebDriver driver)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[1]/div/div/span[2]"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioMensajeLongitudDescripcion(IWebDriver driver)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[3]/div/div/span"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioMensajeDuplicado(IWebDriver driver)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/article/form/div/div[4]/div/div/span"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioEstatusPlan(IWebDriver driver, string nombrePlan)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("//*[@data-nombre-plan='" + nombrePlan + "']"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioInactivarPlanConfirmar(IWebDriver driver)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("//*[@id='btn-modal-confirmar']"));
            return mensajeNombrePlan;
        }

        public IWebElement ElementosPlanServicioEditarPlan(IWebDriver driver, int registro)
        {
            IWebElement mensajeNombrePlan = driver.FindElement(By.XPath("//*[@id='tabla-planes']/tbody/tr[" + registro + "]/td[5]/a/i"));
            return mensajeNombrePlan;
        }

        //Metodo para identificar el numero de reportes de Circulo de Credito
        public IWebElement ElementosPlanServicioNumReportes(IWebDriver driver)
        {
            IWebElement numReportes = driver.FindElement(By.Id("CantidadReportesCredito"));
            return numReportes;
        }

        //Metodo para identificar el primer mes en el cual se realizara la consulta
        public IWebElement ElementosPlanServicioPrimerConsulta(IWebDriver driver)
        {
            IWebElement primerConsulta = driver.FindElement(By.Id("MesPrimerReporte"));
            return primerConsulta;
        }

        //Metodo para identificar segundo mes en el cual se realizara la consulta
        public IWebElement ElementosPlanServicioSegundaConsulta(IWebDriver driver)
        {
            IWebElement primerConsulta = driver.FindElement(By.Id("MesSegundoReporte"));
            return primerConsulta;
        }
    }
}
