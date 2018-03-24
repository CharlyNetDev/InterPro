using OpenQA.Selenium;

namespace InterProHerramientas.LogIn
{
    public class ElementosLogIn
    {
        public IWebElement UsuarioWEPID(IWebDriver driver)
        {
            IWebElement usuario = driver.FindElement(By.Id("Usuario"));
            return usuario;
        }

        public IWebElement ContraseniaWEPID(IWebDriver driver)
        {
            IWebElement contrasenia = driver.FindElement(By.Id("Contrasenia"));
            return contrasenia;
        }

        public IWebElement UsuarioIncorrecto (IWebDriver driver)
        {
            IWebElement mensajeUsuarioIncorrecto = driver.FindElement(By.XPath("html/body/form/div/div[2]/div[1]/div[1]/ul/li"));
            return mensajeUsuarioIncorrecto;
        }
    }
}
