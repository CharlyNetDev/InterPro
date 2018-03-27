﻿using Microsoft.VisualStudio.TestTools.UITesting;
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
        public void LogInExitosoWEPID()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoExitosoWEPID(pathArchivo));
        }

        [TestMethod]
        public void LogInUsuarioIncorrecto()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDUsuarioIncorrecto(pathArchivo));
        }

        [TestMethod]
        public void LogInContraseniaIncorrecto()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDUsuarioIncorrecto(pathArchivo));
        }

        [TestMethod]
        public void LogInSinUsuario()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinUsuario(pathArchivo));
        }

        [TestMethod]
        public void LogInSinContrasenia()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinContrasenia(pathArchivo));
        }

        [TestMethod]
        public void LogInSinUsurioYContrasenia()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, LogInWEPID.AccesoNoExitosoWEPIDSinDatos(pathArchivo));
        }
    }
}