using System.Collections.Generic;
using System.Linq;
using LinqToExcel;

namespace InterProHerramientas.Comunes
{
    public class CargaDatosPrueba
    {
        InterProHerramientas.Comunes.InterproteccionObjetos ObjetosPrueba = new InterProHerramientas.Comunes.InterproteccionObjetos();
        public List<Comunes.InterproteccionObjetos> CargaDatos(string pathFichero)
        {
            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("UsuariosPortal")
                             let item = new Comunes.InterproteccionObjetos
                             {
                                 TestCase = row["CasoPrueba"].Cast<string>(),
                                 Usuario = row["Usuario"].Cast<string>(),
                                 Contrasenia = row["Password"].Cast<string>(),
                                 Url = row["Url"].Cast<string>(),
                                 ResultadoEsperado = row["ResultadoEsperado"].Cast<string>(),
                                 Navegador = row["Browser"].Cast<string>(),
                                 Rol = row["Rol"].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }

        public List<Comunes.InterproteccionObjetos> CargaDatosPlanServicio(string pathFichero)
        {
            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("PlanesDeServicio")
                             let item = new Comunes.InterproteccionObjetos
                             {
                                 TestCase = row["CasoPrueba"].Cast<string>(),
                                 Usuario = row["Usuario"].Cast<string>(),
                                 Contrasenia = row["Password"].Cast<string>(),
                                 Url = row["Url"].Cast<string>(),
                                 ResultadoEsperado = row["ResultadoEsperado"].Cast<string>(),
                                 Navegador = row["Browser"].Cast<string>(),
                                 NombrePlan = row["NombrePlan"].Cast<string>(),
                                 CostoPlan = row["CostoPlan"].Cast<string>(),
                                 Descripcion = row["Descripcion"].Cast<string>(),
                                 ConsutltaReporte = row["ConsutltaReporte"].Cast<string>(),
                                 ConsultaAlertas = row["ConsultaAlertas"].Cast<string>(),
                                 ServicioTarjeta = row["ServicioTarjeta"].Cast<string>(),
                                 Tipo = row["Tipo"].Cast<string>(),
                                 NombreAnterior = row["NombreAnterior"].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }

        //Metodo para extraer la informacion del excel para los casos de prueba de empleados.
        public List<Comunes.InterproteccionObjetos> CargaDatosEmpleados(string pathFichero)
        {
            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("Empleados")
                             let item = new Comunes.InterproteccionObjetos
                             {
                                 TestCase = row["CasoPrueba"].Cast<string>(),
                                 Usuario = row["Usuario"].Cast<string>(),
                                 Contrasenia = row["Password"].Cast<string>(),
                                 Url = row["Url"].Cast<string>(),
                                 ResultadoEsperado = row["ResultadoEsperado"].Cast<string>(),
                                 Navegador = row["Browser"].Cast<string>(),
                                 NombreUsuario = row["NombreUsuario"].Cast<string>(),
                                 CorreoElectronico = row["CorreoElectronico"].Cast<string>(),
                                 Rol = row["Rol"].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }

        //Metodo para extraer la informacion del excel para los casos de prueba de Preguntas Frecuentes.
        public List<Comunes.InterproteccionObjetos> CargaDatosPreguntasFrecuentes(string pathFichero)
        {
    
            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("PreguntasFrecuentes")
                             let item = new Comunes.InterproteccionObjetos
                             {
                                 TestCase = row["CasoPrueba"].Cast<string>(),
                                 Usuario = row["Usuario"].Cast<string>(),
                                 Contrasenia = row["Password"].Cast<string>(),
                                 Url = row["Url"].Cast<string>(),
                                 ResultadoEsperado = row["ResultadoEsperado"].Cast<string>(),
                                 Navegador = row["Browser"].Cast<string>(),
                                 Categoria = row["Categoria"].Cast<string>(),
                                 Activar = row["Activar"].Cast<string>(),
                                 Pregunta = row["Pregunta"].Cast<string>(),
                                 Respuesta = row["Respuesta"].Cast<string>(),
                                 TipoPrueba = row["TipoPrueba"].Cast<string>(),
                                 PreguntaEditada = row["PreguntaEditada"].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }

        //Metodo para extraer la informacion del excel para los casos de prueba de Notificaciones.
        public List<Comunes.InterproteccionObjetos> CargaDatosNotificaciones(string pathFichero)
        {

            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("Notificaciones")
                             let item = new Comunes.InterproteccionObjetos
                             {
                                 TestCase = row["CasoPrueba"].Cast<string>(),
                                 Usuario = row["Usuario"].Cast<string>(),
                                 Contrasenia = row["Password"].Cast<string>(),
                                 Url = row["Url"].Cast<string>(),
                                 ResultadoEsperado = row["ResultadoEsperado"].Cast<string>(),
                                 Navegador = row["Browser"].Cast<string>(),
                                 Mensaje = row["Mensaje"].Cast<string>(),
                                 Destinatario = row["Destinatario"].Cast<string>(),
                                 FechaEnvio = row["FechaEnvio"].Cast<string>(),
                                 HoraEnvio = row["HoraEnvio"].Cast<string>(),
                                 TipoPrueba = row["TipoPrueba"].Cast<string>(),
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }

        /**************************************************************/
        //CARGA DE DATOS DE CLIENTES - INDIVIDUOS
        /**************************************************************/

        #region CARGA DE DATOS DE CLIENTES - INDIVIDUOS
        public List<Comunes.InterproteccionObjetos> CargaDatosClientes(string pathFichero)
        {
            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("Clientes")
                             let item = new Comunes.InterproteccionObjetos
                             {
                                 TestCase = row["CasoPrueba"].Cast<string>(),
                                 Usuario = row["Usuario"].Cast<string>(),
                                 Contrasenia = row["Password"].Cast<string>(),
                                 Url = row["Url"].Cast<string>(),
                                 ResultadoEsperado = row["ResultadoEsperado"].Cast<string>(),
                                 Navegador = row["Browser"].Cast<string>(),

                                 ApPaterno = row["ApellidoPaterno"].Cast<string>(),
                                 ApMaterno = row["ApellidoMaterno"].Cast<string>(),
                                 PrimerNombre = row["PrimerNombre"].Cast<string>(),
                                 SegudoNombre = row["SegundoNombre"].Cast<string>(),
                                 FechaNacimiento = row["FechaNacimiento"].Cast<string>(),
                                 CorreoElectronico = row["CorreoElectronico"].Cast<string>(),
                                 CorreoElectronicoAlterno = row["CorreoElectronicoAlterno"].Cast<string>(),
                                 RFC = row["RFC"].Cast<string>(),
                                 CURP = row["CURP"].Cast<string>(),
                                 TelefonoCasa = row["TelefonoCasa"].Cast<string>(),
                                 TelefonoCelular = row["TelefonoCelular"].Cast<string>(),
                                 Calle = row["Calle"].Cast<string>(),
                                 CodigoPostal = row["CodigoPostal"].Cast<string>(),
                                 Estado = row["Estado"].Cast<string>(),
                                 Ciudad = row["Ciudad"].Cast<string>(),
                                 Delegacion = row["Delegacion"].Cast<string>(),
                                 Colonia = row["Colonia"].Cast<string>(),
                                 //SeleccionarPlan = row["SeleccionaPlan"].Cast<string>(),
                                 // AGREGAR NUEVA FORMA DE PAGO
                                 //ClienteFormaPagoAgregarNueva = row[""].Cast<string>(),
                                 PlanContratado = row ["PlanContratado"].Cast<string>(),
                                 FormaPagoNumeroTarjeta = row["NumeroTarjeta"].Cast<string>(),
                                 FormaPagoVencimientoMM = row["VencimientoMM"].Cast<string>(),
                                 FormaPagoVencimientoAA = row["VencimientoAA"].Cast<string>(),
                                 FormaPagoCVV = row["PagoCVV"].Cast<string>(),
                                 FormaPagoNombreDuenioTarjeta = row["NombreDuenioTarjeta"].Cast<string>()
                                 //ClienteFormaPagoBotonAgregar = row[""].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }
        #endregion

        /**************************************************************/
        //CARGA DE DATOS DE CLIENTES - EMPRESA
        /**************************************************************/

        #region CARGA DE DATOS DE CLIENTES - EMPRESA
        public List<Comunes.InterproteccionObjetos> CargaDatosEmpresa(string pathFichero)
        {
            var book = new ExcelQueryFactory(pathFichero);
            var resultado = (from row in book.Worksheet("Empresa")
                             let item = new Comunes.InterproteccionObjetos
                             {

                                 EmpresaNombre = row["EmpresaNombre"].Cast<string>(),
                                 EmpresaDireccion = row["EmpresaDireccion"].Cast<string>(),
                                 EmpresaTipoEmpresa = row["EmpresaTipoEmpresa"].Cast<string>(),
                                 EmpresaTipoBanco = row["EmpresaTipoBanco"].Cast<string>(),
                                 EmpresaRFC = row["EmpresaRFC"].Cast<string>(),
                                 EmpresaNombreContatoUno = row["EmpresaNombreContatoUno"].Cast<string>(),
                                 EmpresaCorreoContatoUno = row["EmpresaCorreoContatoUno"].Cast<string>(),
                                 EmpresaTelefonoContatoUno = row["EmpresaTelefonoContatoUno"].Cast<string>(),
                                 EmpresaNombreContatoDos = row["EmpresaNombreContatoDos"].Cast<string>(),
                                 EmpresaCorreoContatoDos = row["EmpresaCorreoContatoDos"].Cast<string>(),
                                 EmpresaTelefonoContatoDos = row["EmpresaTelefonoContatoDos"].Cast<string>(),
                                 EmpresaNombreContatoTres = row["EmpresaNombreContatoTres"].Cast<string>(),
                                 EmpresaCorreoContatoTres = row["EmpresaCorreoContatoTres"].Cast<string>(),
                                 EmpresaTelefonoContatoTres = row["EmpresaTelefonoContatoTres"].Cast<string>(),
                                 EmpresaNotas = row["EmpresaNotas"].Cast<string>(),
                                 // SECCION DE CLIENTES - CONSULTA EMPRESAS
                                 EmpresaCampoBusquedaEmpresa = row["EmpresaCampoBusquedaEmpresa"].Cast<string>(),
                                 EmpresaCampoBusquedaContacto = row["EmpresaCampoBusquedaContacto"].Cast<string>(),
                                 EmpresaFiltroTipoEmpresa = row["EmpresaFiltroTipoEmpresa"].Cast<string>(),
                                 EmpresaFiltroTipoBanco = row["EmpresaFiltroTipoBanco"].Cast<string>(),
                                 // SECCION GENERAR CÓDIGOS DE ACTIVACIÓN - EMPRESAS
                                 EmpresaGenerarCodigosActivacionCodigoFijo = row["CodigoFijo"].Cast<string>(),
                                 EmpresaGenerarCodigosActivacionCantidadClaves = row["CantidadClaves"].Cast<string>(),
                                 EmpresaGenerarCodigosActivacionTipoPlan = row["TipoPlan"].Cast<string>(),
                                 EmpresaGenerarCodigosActivacionServicioDesde = row["ServicioDesde"].Cast<string>(),
                                 EmpresaGenerarCodigosActivacionServicioHasta = row["ServicioHasta"].Cast<string>(),
                                 EmpresaGenerarCodigosActivacionCodigoMovil = row["CodigoMovil"].Cast<string>(),
                                 EmpresaGenerarCodigosActivacionActivarAntesDel = row["ActivarAntesDel"].Cast<string>(),
                                 EmpresaGenerarCodigosActivacionPeriodoVigencia = row["PeriodoVigencia"].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }
        #endregion
    }
}
