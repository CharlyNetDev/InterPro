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
        InterProHerramientas.Comunes.Soporte constantesTest = new InterProHerramientas.Comunes.Soporte();

        [TestMethod]
        public void LogIn_001_ExitosoWEPID()
        {
            Assert.AreEqual(true, LogInWEPID.AccesoExitosoWEPID(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void LogIn_002_UsuarioIncorrecto()
        {
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDUsuarioIncorrecto(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void LogIn_003_ContraseniaIncorrecto()
        {
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDUsuarioIncorrecto(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void LogIn_004_SinUsuario()
        {
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinUsuario(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void LogIn_005_SinContrasenia()
        {
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinContrasenia(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void LogIn_006_SinUsurioYContrasenia()
        {
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinDatos(constantesTest.PathArchivo()));
        }
    }
}
