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
            IWebElement usuario = driver.FindElement(By.Id("Contrasenia"));
            return usuario;
        }
    }
}
