using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace InterProPruebasAutomatizadas
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class PruebasLogin
    {
        InterProHerramientas.LogIn.ProcesoLogIn LogInWEPID = new InterProHerramientas.LogIn.ProcesoLogIn();
        [TestMethod]
        public void LogIn_001_ExitosoWEPID()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoExitosoWEPID(pathArchivo));
        }

        [TestMethod]
        public void LogIn_002_UsuarioIncorrecto()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDUsuarioIncorrecto(pathArchivo));
        }

        [TestMethod]
        public void LogIn_003_ContraseniaIncorrecto()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDUsuarioIncorrecto(pathArchivo));
        }

        [TestMethod]
        public void LogIn_004_SinUsuario()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinUsuario(pathArchivo));
        }

        [TestMethod]
        public void LogIn_005_SinContrasenia()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinContrasenia(pathArchivo));
        }

        [TestMethod]
        public void LogIn_006_SinUsurioYContrasenia()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinDatos(pathArchivo));
        }
    }
}
