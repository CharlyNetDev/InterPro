using OpenQA.Selenium;

namespace InterProHerramientas.Empleados.Elementos
{ 
    public class ElementosEmpleados
    {
        public IWebElement ElementosEmpleadosBotonAgregarEmpleado(IWebDriver driver)
        {
            IWebElement agrgarEmpleado = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return agrgarEmpleado;
        }

        public IWebElement ElementosEmpleadosBotonCrearEmpleado(IWebDriver driver)
        {
            IWebElement agrgarEmpleado = driver.FindElement(By.XPath("//*[@id='btn-crear']"));
            return agrgarEmpleado;
        }

        public IWebElement ElementosEmpleadosNombreDelUsuario(IWebDriver driver)
        {
            IWebElement agrgarEmpleado = driver.FindElement(By.Id("Nombre"));
            return agrgarEmpleado;
        }

        public IWebElement ElementosEmpleadosCorreElectronico(IWebDriver driver)
        {
            IWebElement correo = driver.FindElement(By.Id("Correo"));
            return correo;
        }

        public IWebElement ElementosEmpleadosRol(IWebDriver driver)
        {
            IWebElement rolEmpleado = driver.FindElement(By.XPath("//*[@id='GuidRolSistema']"));
            return rolEmpleado;
        }

        public IWebElement ElementosEmpleadosMensajeNombre(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[3]/div/div/span"));
            return mensaje;
        }

        public IWebElement ElementosEmpleadosMensajeCorreo(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[7]/div/div/span[1]"));
            return mensaje;
        }

        public IWebElement ElementosEmpleadosMensajeRol(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[11]/div/div/span"));
            return mensaje;
        }

        public IWebElement ElementosEmpleadosMensajeNombreValidacionLongitu(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[3]/div/div/span"));
            return mensaje;
        }

        public IWebElement ElementosEmpleadosMensajeCorreoValidacionLongitu(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[7]/div/div/span[1]"));
            return mensaje;
        }

        public IWebElement ElementosEmpleadosMensajeUsuatioDuplicado(IWebDriver driver)
        {
            IWebElement mensaje = driver.FindElement(By.XPath("//*[@id='forma']/div/div[7]/div/div/span[2]"));
            return mensaje;
        }
        

        public IWebElement ElementosEmpleadosBotonCancelar(IWebDriver driver)
        {
            IWebElement boton = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return boton;
        }

        public IWebElement ElementosEmpleadosEditarEmpleado(IWebDriver driver, int registro)
        {
            IWebElement editarEmpleado = driver.FindElement(By.XPath(" //*[@id='tabla-usuarios']/tbody/tr[ " + registro + " ]/td[5]/a"));
                                                                     
            return editarEmpleado;
        }

        public IWebElement ElementosEmpleadosEliminarEmpleado(IWebDriver driver, string usuario)
        {
            IWebElement editarEmpleado = driver.FindElement(By.XPath("//*[@data-nombre-usuario=" + "'" + usuario + "'" + "]"));
            return editarEmpleado;
        }


        public IWebElement ElementosEmpleadosPaginado(IWebDriver driver, int pagina)
        {
            IWebElement paginado = driver.FindElement(By.XPath("//*[@id='tabla-usuarios_paginate']/span/a[" + pagina + "]"));
            
            return paginado;
        }

        public IWebElement ElementosEmpleadosRegistro(IWebDriver driver, int registro)
        {
            IWebElement registroCapturado = driver.FindElement(By.XPath("//*[@id='tabla-usuarios']/tbody/tr[" + registro + "]/td[2]"));
            return registroCapturado;
        }

        public IWebElement ElementosEmpleadosConfirmacionAceptarEliminar(IWebDriver driver)
        {
            IWebElement confirmacionEliminar = driver.FindElement(By.XPath("//*[@id='btn-modal-confirmar']"));
            return confirmacionEliminar;
        }

        public int ElementosEmpleadosNumeroPaginas(IWebDriver driver, int pagina)
        {
            var totalPaginas = driver.FindElements(By.XPath("//*[@id='tabla-usuarios_paginate']/span/a[' ']"));
            return totalPaginas.Count;
        }
        
        public int ElementosEmpleadosNumeroRegistros(IWebDriver driver, int pagina)
        {
            var totalRegistros = driver.FindElements(By.XPath("//*[@id='tabla-usuarios']/tbody/tr[' ']/td[1]"));
            return totalRegistros.Count;
        }



    }
}
