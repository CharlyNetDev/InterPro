using OpenQA.Selenium;

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

        public IWebElement ElementosPlanServicioServiciosBuro(IWebDriver driver)
        {
            IWebElement buro = driver.FindElement(By.ClassName("ckbox"));
            //(By.XPath("html/body/div[4]/div[1]/article/form/div/div[4]/div/label[2]"));
            return buro;
        }

        public IWebElement ElementosPlanServicioServiciosTarjeta(IWebDriver driver)
        {
            IWebElement tarjeta = driver.FindElement(By.XPath("html/body/div[4]/div[1]/article/form/div/div[4]/div/label[3]"));
            return tarjeta;
        }


        //span/input[@name='payslipradio' and @value='6']
        // SELECCIONA (CLICK) AL CHECK "BURÓ DE CRÉDITO"
        //public IWebElement ElementosPlanServicioServiciosBuro(IWebDriver driver)
        //{
        //    IWebElement Buro = driver.FindElement(By.TagName("a72f8b6f-519e-458b-8868-2c4733a7711f"));
        //    return Buro;
        //}


        //SELECCIONA(CLICK) AL CHECK "BURÓ DE CRÉDITO"



    }
}
