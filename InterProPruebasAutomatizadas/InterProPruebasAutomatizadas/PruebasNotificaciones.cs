using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterProPruebasAutomatizadas
{
   
    [TestClass]
    public class PruebasNotificaciones
    {
        InterProHerramientas.Notificaciones.ProcesoNotificaciones NotificaionesWepID = new InterProHerramientas.Notificaciones.ProcesoNotificaciones();
        InterProHerramientas.Comunes.Soporte constantesTest = new InterProHerramientas.Comunes.Soporte();

        [TestMethod]
        public void Notificacion_001_CreacionExitosaBancos()
        {
            Assert.AreEqual(true, NotificaionesWepID.ProcesoAltaNotificacionCamposObligatoriosBancos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Notificacion_002_CreacionExitosaEmpresas()
        {
            Assert.AreEqual(true, NotificaionesWepID.ProcesoAltaNotificacionCamposObligatoriosEmpresas(constantesTest.PathArchivo()));
        }


        [TestMethod]
        public void Notificacion_003_CreacionExitosaPlanesServicio()
        {
            Assert.AreEqual(true, NotificaionesWepID.ProcesoAltaNotificacionCamposObligatoriosPlanesServicio(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Notificacion_004_ValidacionCampos()
        {
            Assert.AreEqual(true, NotificaionesWepID.ProcesoValidacionCampoMensajes(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Notificacion_005_ValidacionCampos()
        {
            Assert.AreEqual(true, NotificaionesWepID.ProcesoAltaNotificacionProgramada(constantesTest.PathArchivo()));
        }

    }
}
