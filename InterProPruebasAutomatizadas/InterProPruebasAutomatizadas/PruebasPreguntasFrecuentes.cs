﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace InterProPruebasAutomatizadas
{

    [TestClass]
    public class PruebasPreguntasFrecuentes
    {
        InterProHerramientas.Configuracion.PreguntasFrecuentes.Proceso.ProcesoPreguntasFrecuentes preguntasFrecuentesWEPID = new InterProHerramientas.Configuracion.PreguntasFrecuentes.Proceso.ProcesoPreguntasFrecuentes();
        [TestMethod]
        public void PreguntasFrecuentes_001_CreacionDatosObligatorios()

        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, preguntasFrecuentesWEPID.ProcesoAltaPreguntaCamposObligatorios(pathArchivo));
        }

        [TestMethod]
        public void PreguntasFrecuentes_002_EdicionPregunta()

        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, preguntasFrecuentesWEPID.ProcesoEditarPregunta(pathArchivo));
        }


    }
}
