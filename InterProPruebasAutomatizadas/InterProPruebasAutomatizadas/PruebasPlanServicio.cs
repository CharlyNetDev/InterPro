using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterProPruebasAutomatizadas
{
    [TestClass]
    public class PruebasPlanServicio
    {

        InterProHerramientas.PlanesServicio.ProcesoPlanServicio planServcioWEPID = new InterProHerramientas.PlanesServicio.ProcesoPlanServicio();
        [TestMethod]
        public void PlanServicio_001_CreacionDatosObligatorios()

        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioDatosObligatorios(pathArchivo));
        }

        [TestMethod]
        public void PlanServicio_002_CreaciontTodosCampos()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioTodosLosDatos(pathArchivo));
        }

        [TestMethod]
        public void PlanServicio_003_ValidacionCampos()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioValidarCampos(pathArchivo));
        }

        [TestMethod]
        public void PlanServicio_004_ValidacionLongitudCampos()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioValidarLongitudCampos(pathArchivo));
        }

        [TestMethod]
        public void PlanServicio_005_ValidacionPlanDuplicado()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioValidarDuplicado(pathArchivo));
        }

        [TestMethod]
        public void PlanServicio_006_InactivarPlan()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioInactivarPlan(pathArchivo));
        }

        [TestMethod]
        public void PlanServicio_007_ActivarPlan()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioActivarPlan(pathArchivo));
        }

        [TestMethod]
        public void PlanServicio_008_EditarPlanCamposObligatorios()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoEdicionPlanesServicioDatosObligatorios(pathArchivo));
        }

        public void PlanServicio_008_EditarPlanTodosCampos()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoEdicionPlanesServicioDatosObligatorios(pathArchivo));
        }

    }
}
