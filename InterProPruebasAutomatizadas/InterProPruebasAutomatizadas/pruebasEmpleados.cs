﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools;


namespace InterProPruebasAutomatizadas
{
    [CodedUITest]
    public class pruebasEmpleados
    {
        InterProHerramientas.Empleados.ProcesoEmpleados empleadosWEPID = new InterProHerramientas.Empleados.ProcesoEmpleados();

        public TestContext TestContext { get; set; }

        private const string _OrderedTestFilename = "TestList.csv";
               
        [TestMethod]
        public void Empleados_001_CreacionDatosObligatorios()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.AltaEmpleadoDatosObligatorios(pathArchivo));
        }

        [TestMethod]
        public void Empleados_002_ValidacionCamposObligatorios()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadoValidarCampos(pathArchivo));
        }

        [TestMethod]
        public void Empleados_003_ValidacionCamposLongitud()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidarLongitudCampos(pathArchivo));
        }

        [TestMethod]
        public void Empleados_004_ValidacionUsuarioDuplicado()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidacionUsuarioDuplicado(pathArchivo));
        }

        [TestMethod]
        public void Empleados_005_ValidacionEliminarUsuario()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosValidarEliminar(pathArchivo));
        }

        [TestMethod]
        public void Empleados_006_ValidacionReactivacionUsuario()
        {
            string pathArchivo = ("C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx");
            Assert.AreEqual(true, empleadosWEPID.EmpleadosReactivacionDatosObligatorios(pathArchivo));
        }
    }
}
