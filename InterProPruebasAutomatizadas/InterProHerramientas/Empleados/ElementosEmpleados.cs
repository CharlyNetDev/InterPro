using OpenQA.Selenium;

namespace InterProHerramientas.Empleados.Elementos
{ 
    public class ElementosEmpleados
    {
        public IWebElement BotonAgregarEmpleado(IWebDriver driver)
        {
            IWebElement agrgarEmpleado = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return agrgarEmpleado;
        }

        public IWebElement NombreDelUsuario(IWebDriver driver)
        {
            IWebElement agrgarEmpleado = driver.FindElement(By.Id("Nombre"));
            return agrgarEmpleado;
        }

        public IWebElement CorreElectronico(IWebDriver driver)
        {
            IWebElement correo = driver.FindElement(By.Id("Correo"));
            return correo;
        }

        public IWebElement Rol(IWebDriver driver)
        {
            IWebElement rolEmpleado = driver.FindElement(By.XPath("//*[@id='GuidRolSistema']"));
            return rolEmpleado;
        }

        public IWebElement MensajeNombre(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[3]/div/div/span"));
            return mensaje;
        }

        public IWebElement MensajeCorreo(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[7]/div/div/span[1]"));
            return mensaje;
        }

        public IWebElement MensajeRol(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[11]/div/div/span"));
            return mensaje;
        }

        public IWebElement MensajeNombreValidacionLongitu(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[3]/div/div/span"));
            return mensaje;
        }

        public IWebElement MensajeCorreoValidacionLongitu(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[7]/div/div/span[1]"));
            return mensaje;
        }

        public IWebElement BotonCancelar(IWebDriver driver)
        {
            IWebElement boton = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return boton;
        }
    }
}
