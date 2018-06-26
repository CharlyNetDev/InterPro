using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterProPruebasAutomatizadas
{

    [TestClass]
    public class PruebasPlanServicio
    {

        InterProHerramientas.PlanesServicio.ProcesoPlanServicio planServcioWEPID = new InterProHerramientas.PlanesServicio.ProcesoPlanServicio();
        InterProHerramientas.Comunes.Soporte constantesTest = new InterProHerramientas.Comunes.Soporte();

        [TestMethod]
        public void PlanServicio_001_CreacionDatosObligatorios()

        {
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioDatosObligatorios(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PlanServicio_002_CreaciontTodosCampos()
        {
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioTodosLosDatos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PlanServicio_003_ValidacionCampos()
        {
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioValidarCampos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PlanServicio_004_ValidacionLongitudCampos()
        {
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioValidarLongitudCampos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PlanServicio_005_ValidacionPlanDuplicado()
        {
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioValidarDuplicado(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void PlanServicio_006_InactivarPlanYActivarPlan()
        {
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioInactivarPlan(constantesTest.PathArchivo()));
        }

        //// [TestMethod]
        // public void PlanServicio_007_ActivarPlan()
        // {
        //     string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
        //     Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicioActivarPlan(pathArchivo));
        // }

        //[TestMethod]
        //public void PlanServicio_008_EditarPlanCamposObligatorios()
        //{
        //    Assert.AreEqual(true, planServcioWEPID.ProcesoEdicionPlanesServicioDatosObligatorios(constantesTest.PathArchivo()));
        //}

        //public void PlanServicio_009_EditarPlanTodosCampos()
        //{
        //    Assert.AreEqual(true, planServcioWEPID.ProcesoEdicionPlanesServicioDatosObligatorios(constantesTest.PathArchivo()));
        //}

    }
}
