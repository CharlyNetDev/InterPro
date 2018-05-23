using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace InterProPruebasAutomatizadas
{

    [TestClass]
    public class PruebasPreguntasFrecuentes
    {
        InterProHerramientas.Configuracion.PreguntasFrecuentes.Proceso.ProcesoPreguntasFrecuentes preguntasFrecuentesWEPID = new InterProHerramientas.Configuracion.PreguntasFrecuentes.Proceso.ProcesoPreguntasFrecuentes();
        InterProHerramientas.Comunes.Soporte constantesTest = new InterProHerramientas.Comunes.Soporte(); 

        [TestMethod]
        public void PreguntasFrecuentes_001_CreacionDatosObligatorios()

        {
            Assert.AreEqual(true, preguntasFrecuentesWEPID.ProcesoAltaPreguntaCamposObligatorios(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PreguntasFrecuentes_002_EdicionPregunta()

        {
            Assert.AreEqual(true, preguntasFrecuentesWEPID.ProcesoEditarPregunta(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PreguntasFrecuentes_003_ValidacionCampos()

        {
            Assert.AreEqual(true, preguntasFrecuentesWEPID.ProcesoValidacionDeCampos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PreguntasFrecuentes_004_ValidacionLongitudDeCampos()

        {
            Assert.AreEqual(true, preguntasFrecuentesWEPID.ProcesoValidacionDeLongitudCampos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PreguntasFrecuentes_004_EliminarPregunta()

        {
            Assert.AreEqual(true, preguntasFrecuentesWEPID.ProcesoEliminarPregunta(constantesTest.PathArchivo()));
        }
        
    }
}
