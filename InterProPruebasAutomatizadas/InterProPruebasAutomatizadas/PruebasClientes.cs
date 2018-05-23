using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterProPruebasAutomatizadas
{
    /// <summary>
    /// Descripción resumida de PruebasClientes
    /// </summary>
    [TestClass]
    public class PruebasClientes
    {
        InterProHerramientas.Clientes.ProcesoClientes clientesWEPID = new InterProHerramientas.Clientes.ProcesoClientes();
        InterProHerramientas.Comunes.Soporte constantesTest = new InterProHerramientas.Comunes.Soporte();

        [TestMethod]
        public void Clientes_001_CreacionDatosObligatorios()
        {
            Assert.AreEqual(true, clientesWEPID.A001_AltaClientesTodosLosDatos(constantesTest.PathArchivo()));
        }
    }
}
