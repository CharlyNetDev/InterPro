using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterProPruebasAutomatizadas
{
    [TestClass]
    public class PruebasPlanServicio
    {

        InterProHerramientas.PlanesServicio.ProcesoPlanServicio planServcioWEPID = new InterProHerramientas.PlanesServicio.ProcesoPlanServicio();
        [TestMethod]
        public void PlanServicioCreacionDatosObligatorios()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, planServcioWEPID.ProcesoAltaPlanesServicio(pathArchivo));
        }
    }
}
