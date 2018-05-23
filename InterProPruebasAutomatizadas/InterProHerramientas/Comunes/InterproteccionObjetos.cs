namespace InterProHerramientas.Comunes
{
    public class InterproteccionObjetos
    {
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string Navegador { get; set; }
        public string Url { get; set; }
        public string TestCase { get; set; }
        public string ResultadoEsperado { get; set; }
        public string Rol { get; set; }
        public string NombrePlan { get; set; }
        public string CostoPlan { get; set; }
        public string Descripcion { get; set; }
        public string ServicioBuro { get; set; }
        public string ServicioTarjeta { get; set; }
        public string Tipo { get; set; }
        public string NombreAnterior { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Categoria { get; set; }
        public string Activar { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public string TipoPrueba { get; set; }
        public string PreguntaEditada { get; set; }
        //Notifiaciones
        public string Mensaje { get; set; }
        public string Destinatario { get; set; }
        public string FechaEnvio { get; set; }
        public string HoraEnvio { get; set; }

        public string CasoPrueba { get; set; }
        public string Password { get; set; }
        public string Browser { get; set; }


        /********************************************************/
        // OBJETOS DE CLINTES - ALTA INDIVIDUOS
        /********************************************************/

        #region OBJETOS DE CLINTES - ALTA CLIENTES
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string PrimerNombre { get; set; }
        public string SegudoNombre { get; set; }
        public string FechaNacimiento { get; set; }
        //public string  CorreoElectronico { get; set; }
        public string CorreoElectronicoAlterno { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoCelular { get; set; }
        public string Calle { get; set; }
        public string CodigoPostal { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Delegacion { get; set; }
        public string Colonia { get; set; }
        public string SeleccionarPlan { get; set; }
        #endregion

        /********************************************************/
        // SECCION DE CLIENTES - CONSULTA INDIVIDUOS
        /********************************************************/

        #region SECCION DE CONSULTA INDIVIDUOS - CLIENTES   
        public string ConsutaClienteIndividuo { get; set; }
        public string ConsutaClienteNombreCliente { get; set; }
        public string ConsutaClienteTelefono { get; set; }
        public string ConsutaClienteCorreoElectronico { get; set; }
        public string ConsutaClienteRFC { get; set; }
        public string ConsutaClienteFechaNacimiento { get; set; }
        public string ConsutaClienteEsIndividual { get; set; }
        public string ConsutaClientePerteneceEmpresa { get; set; }
        public string ConsutaClientePerteneceBanco { get; set; }
        public string ConsutaClienteConsultar { get; set; }
        #endregion


        /********************************************************/
        // OBJETOS DE CREAR NUEVA EMPRESA
        /********************************************************/

        #region OBJETOS DE CREAR NUEVA EMPRESA
        public string EmpresaNombre { get; set; }
        public string EmpresaDireccion { get; set; }
        public string EmpresaTipoEmpresa { get; set; }
        public string EmpresaTipoBanco { get; set; }
        public string EmpresaRFC { get; set; }
        public string EmpresaNombreContatoUno { get; set; }
        public string EmpresaCorreoContatoUno { get; set; }
        public string EmpresaTelefonoContatoUno { get; set; }
        public string EmpresaNombreContatoDos { get; set; }
        public string EmpresaCorreoContatoDos { get; set; }
        public string EmpresaTelefonoContatoDos { get; set; }
        public string EmpresaNombreContatoTres { get; set; }
        public string EmpresaCorreoContatoTres { get; set; }
        public string EmpresaTelefonoContatoTres { get; set; }
        public string EmpresaNotas { get; set; }
        #endregion


        /********************************************************/
        // OBJETOS AGREGAR NUEVA FORMA DE PAGO
        /********************************************************/
        #region OBJETOS AGREGAR NUEVA FORMA DE PAGO
        public string FormaPagoAgregarNueva { get; set; }
        public string FormaPagoNumeroTarjeta { get; set; }
        public string FormaPagoVencimientoMM { get; set; }
        public string FormaPagoVencimientoAA { get; set; }
        public string FormaPagoCVV { get; set; }
        public string FormaPagoNombreDuenioTarjeta { get; set; }
        public string FormaPagoBotonAgregar { get; set; }
        #endregion

        /********************************************************/
        //OBJETOS PARA LA CONSULTA DE CLIENTES Y EMPRESAS
        /********************************************************/

        #region OBJETOS PARA LA CONSULTA DE CLIENTES Y EMPRESAS
        public string EmpresaCampoBusquedaEmpresa { get; set; }
        public string EmpresaCampoBusquedaContacto { get; set; }
        public string EmpresaFiltroTipoEmpresa { get; set; }
        public string EmpresaFiltroTipoBanco { get; set; }
        #endregion

        /********************************************************/
        //ELEMENTOS PARA GENERAR CÓDIGOS DE ACTIVACIÓN - EMPRESAS
        /********************************************************/

        #region ELEMENTOS PARA GENERAR CÓDIGOS DE ACTIVACIÓN - EMPRESAS
        public string EmpresaGenerarCodigosActivacionSeccionGenerarCodigoActivacion { get; set; }
        public string EmpresaGenerarCodigosActivacionCodigoFijo { get; set; }
        public string EmpresaGenerarCodigosActivacionCantidadClaves { get; set; }
        public string EmpresaGenerarCodigosActivacionTipoPlan { get; set; }
        public string EmpresaGenerarCodigosActivacionServicioDesde { get; set; }
        public string EmpresaGenerarCodigosActivacionServicioHasta { get; set; }
        public string EmpresaGenerarCodigosActivacionCodigoMovil { get; set; }
        public string EmpresaGenerarCodigosActivacionActivarAntesDel { get; set; }
        public string EmpresaGenerarCodigosActivacionPeriodoVigencia { get; set; }
        #endregion

        public string PlanContratado { get; set; }

    }
}
