using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace InterProHerramientas.Comunes
{
    public class Navegadores
    {
        public IWebDriver LanzarNavegador(InterproteccionObjetos objetosPrueba)
        {
            IWebDriver driver = null;

            if (objetosPrueba.Navegador.Equals("Chrome"))
            {
                ChromeOptions opciones = new ChromeOptions();

                opciones.AddArguments("-incognito");
                opciones.AddArguments("--disable-infobars");
                opciones.AddArguments("--disable-popup-bloking");
                opciones.AddArguments("-start-maximized");

                driver = new ChromeDriver(opciones);
            }

            if (objetosPrueba.Navegador.Equals("FireFox"))
            {
                driver = new FirefoxDriver("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\bin\\Debug");
            }

            return driver;
        }


    }
}
