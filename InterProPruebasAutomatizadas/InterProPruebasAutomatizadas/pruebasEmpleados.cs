using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools;


namespace InterProPruebasAutomatizadas
{
    [CodedUITest]
    public class PruebasEmpleados
    {
        InterProHerramientas.Empleados.ProcesoEmpleados empleadosWEPID = new InterProHerramientas.Empleados.ProcesoEmpleados();
        InterProHerramientas.Comunes.Soporte constantesTest = new InterProHerramientas.Comunes.Soporte();

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Empleados_001_CreacionDatosObligatorios()
        {
            Assert.AreEqual(true, empleadosWEPID.AltaEmpleadoDatosObligatorios(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Empleados_002_ValidacionCamposObligatorios()
        {
            Assert.AreEqual(true, empleadosWEPID.EmpleadoValidarCampos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Empleados_003_ValidacionCamposLongitud()
        {
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidarLongitudCampos(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Empleados_004_ValidacionUsuarioDuplicado()
        {
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidacionUsuarioDuplicado(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Empleados_005_ValidacionEliminarUsuario()
        {
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidarEliminar(constantesTest.PathArchivo()));
        }

        [TestMethod]
        public void Empleados_006_ValidacionReactivacionUsuario()
        {
            Assert.AreEqual(true, empleadosWEPID.EmpleadosReactivacionDatosObligatorios(constantesTest.PathArchivo()));
        }
    }
}
