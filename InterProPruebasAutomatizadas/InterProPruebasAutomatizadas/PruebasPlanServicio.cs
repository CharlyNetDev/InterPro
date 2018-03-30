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
        //public void PlanServicio_002_CreaciontTodosDatos()
        //{
        //    string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
        //    Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicio(pathArchivo));
        //}
    }
}
