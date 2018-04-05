using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace InterProPruebasAutomatizadas
{
    [CodedUITest]
    public class pruebasEmpleados
    {
        InterProHerramientas.Empleados.ProcesoEmpleados empleadosWEPID = new InterProHerramientas.Empleados.ProcesoEmpleados();

        [TestMethod]
        public void Empleados_001_CreacionDatosObligatorios()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.AltaEmpleadoDatosObligatorios(pathArchivo));
        }

        [TestMethod]
        public void Empleados_002_ValidacionCamposObligatorios()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadoValidarCampos(pathArchivo));
        }

        [TestMethod]
        public void Empleados_003_ValidacionCamposLongitud()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidarLongitudCampos(pathArchivo));
        }

        [TestMethod]
        public void Empleados_004_ValidacionUsuarioDuplicado()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidacionUsuarioDuplicado(pathArchivo));
        }

        [TestMethod]
        public void Empleados_005_ValidacionEliminarUsuario()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidarEliminar(pathArchivo));
        }

        [TestMethod]
        public void Empleados_006_ValidacionReactivacionUsuario()
        {
            string pathArchivo = ("C:\\Users\\User\\source\\repos\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosReactivacionDatosObligatorios(pathArchivo));
        }
    }
}
