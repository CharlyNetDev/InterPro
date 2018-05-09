using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace InterProHerramientas.Configuracion.PreguntasFrecuentes.Elementos
{

    [TestClass]
    //Clase para identificar los elementos de la sección de preguntas frecuentes.
    public class ElementosPreguntasFrecuentes
    {
        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasAgregarPreguntaYRespuesta(IWebDriver driver)
        {
            //Identificar el elemento Agregar Pregunta y Respuesta.
            IWebElement agregarPregunta = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return agregarPregunta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasCancelar(IWebDriver driver)
        {
            //Identificar el elemento para Cancelar
            IWebElement cancelar = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return cancelar;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasCrearPregunta(IWebDriver driver)
        {
            //Identificar el elemento para Crear la pregunta.
            IWebElement crear = driver.FindElement(By.Id("btn-crear"));
            return crear;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasListaCategoria(IWebDriver driver)
        {
            //Identificar el elemento para seleccionar la categoria de las preguntas.
            IWebElement lista = driver.FindElement(By.Id("GuidPreguntaCategoria"));
            return lista;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasActivarPregunta(IWebDriver driver)
        {
            //Identificar elemento para activar la pregunta.
            IWebElement activar = driver.FindElement(By.XPath("//*[@id='forma']/div[3]/div[2]/label"));
            
            return activar;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasTextoPregunta(IWebDriver driver)
        {
            //Identificar elemento para capturar la pregunta.
            IWebElement pregunta = driver.FindElement(By.Id("TextoPregunta"));
            return pregunta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasTextoRespuesta(IWebDriver driver)
        {
            //Identificar el elemento para capturar la respuesta.
            IWebElement respuesta = driver.FindElement(By.Id("TextoRespuesta"));
            return respuesta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasMensajeCategoria(IWebDriver driver)
        {
            //Identificar el elemento para advertencia seleccioanr categoria.
            IWebElement mensajeCategoria = driver.FindElement(By.XPath("//*[@id='forma']/div[3]/div[1]/span[2]"));
            return mensajeCategoria;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasMensajePregunta (IWebDriver driver)
        {
            //Identificar el elemento para advertencia capturar pregunta.
            IWebElement mensajePregunta = driver.FindElement(By.XPath("//*[@id='forma']/div[5]/div/span"));
            return mensajePregunta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasMensajeRespuesta(IWebDriver driver)
        {
            //Identificar el elemtno para capturar respuesta.
            IWebElement mensajePregunta = driver.FindElement(By.XPath("//*[@id='forma']/div[8]/div/span"));
            return mensajePregunta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasMensajeLongitudPregunta(IWebDriver driver)
        {
            //Identificar elemento para validar la longitud de la pregunta.
            IWebElement mensajeLongitudPregunta = driver.FindElement(By.XPath("//*[@id='forma']/div[5]/div/span"));
            return mensajeLongitudPregunta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasMensajeLongitudRespuesta(IWebDriver driver)
        {
            //Identificar elemento para validar la longitud de la respuesta.
            IWebElement mensajeLongitudPregunta = driver.FindElement(By.XPath("//*[@id='forma']/div[8]/div/span"));
            return mensajeLongitudPregunta;
        }
      
        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasEstatusPregunta(IWebDriver driver, string nombrePregunta)
        {
            //Identificar el elemento para activar o inactivar la pregunta pasada en el parametro del metodo el nombre.
            ////*[@data-nombre-pregunta-estatus="Pregunta 1 de servicio producto"]
            IWebElement estatusPregunta = driver.FindElement(By.XPath("//*[@data-nombre-pregunta-estatus = '" + nombrePregunta + "']"));
            return estatusPregunta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntasEliminarPregunta(IWebDriver driver, string nombrePregunta)
        {
            //Identificar el elemento para eliminar pregunta pasada en el parametro del metodo el nombre.
            IWebElement eliminarPregunta = driver.FindElement(By.XPath("//*[@data-nombre-pregunta = '" + nombrePregunta + "']"));
            return eliminarPregunta;
        }

        //Metodo para identificar elementos de de la sección de preguntas.//*[@id="tabla-preguntas_paginate"]/span/a[1]
        public IWebElement ElementosPreguntasEliminarPregunta(IWebDriver driver, int regitro)
        {
            //Identificar el elemento para eliminar pregunta pasada en el parametro del metodo el nombre.
            IWebElement editarPregunta = driver.FindElement(By.XPath("//*[@id='tabla-preguntas']/tbody/tr[" + regitro + "]/td[5]/i"));
            return editarPregunta;
        }

        public IWebElement ElementosPreguntasConfirmarEliminar(IWebDriver driver)
        {
            IWebElement confirmarEliminar = driver.FindElement(By.Id("btn-modal-confirmar"));
            return confirmarEliminar;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntaPaginado(IWebDriver driver, int pagina)
        {
            //Identifica los elementos del paginado
            IWebElement paginado = driver.FindElement(By.XPath("//*[@id='tabla-preguntas_paginate']/span/a[" + pagina + "]"));
            return paginado;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPreguntaRegistro(IWebDriver driver, int registro)
        {
            //Identificar el registro
            IWebElement registroCapturado = driver.FindElement(By.XPath("//*[@id='tabla-preguntas']/tbody/tr[" + registro + "]/td[3]"));
            return registroCapturado;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public IWebElement ElementosPeguntaEditarRegistro(IWebDriver driver, int registro)
        {
            //Identificar el registro
            IWebElement registroCapturado = driver.FindElement(By.XPath("//*[@id='tabla-preguntas']/tbody/tr[" + registro + "]/td[5]/a"));
            return registroCapturado;
        }

        //Metodo para identificar elementos de de la sección de preguntas.
        public int ElementosEmpleadosNumeroRegistros(IWebDriver driver, int pagina)
        {
            //Identificar numero de paginas
            var totalRegistros = driver.FindElements(By.XPath("//*[@id='tabla-preguntas']/tbody/tr[' ']/td[1]"));
            return totalRegistros.Count;
        }
    }
}
