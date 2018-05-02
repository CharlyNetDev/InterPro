using OpenQA.Selenium;

namespace InterProHerramientas.Configuracion.Roles
{
    public class ElementosRoles
    {
        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesAgregar(IWebDriver driver)
        {
            //Identificar el elemento Agregar un rol.
            IWebElement agregarPregunta = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return agregarPregunta;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesCancelar(IWebDriver driver)
        {
            //Identificar el elemento cancelar proceso de creación de un rol.
            IWebElement cancelarRol = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div[2]/a"));
            return cancelarRol;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesGuardar(IWebDriver driver)
        {
            //Identificar el elemento guardar el rol.
            IWebElement guardarRol = driver.FindElement(By.Id("btn-crear"));
            return guardarRol;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesNombreRol(IWebDriver driver)
        {
            //Identificar el elemento para asignar un nombre a un rol.
            IWebElement nombreRol = driver.FindElement(By.Id("NombreRol"));
            return nombreRol;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesDescripcion(IWebDriver driver)
        {
            //Identificar el elemento para asignar un nombre a un rol.
            IWebElement descripcionRol = driver.FindElement(By.Id("Descripcion"));
            return descripcionRol;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesTodoslosPermisosPorModulo(IWebDriver driver, string subMenu)
        {
            //Identificar el elemento para asignar todos los permisos al modulo pasado en el parametro del metodo.
            IWebElement todosPermisos = driver.FindElement(By.Id(subMenu));
            return todosPermisos;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesPermisoVerOAcceder(IWebDriver driver, string subMenu)
        {
            //Identificar el elemento para asignar un permiso para ver o acceder, enviando al metodo el submenu para asignar el permiso.
            //IWebElement permisosEmpleadosVerAcceder = driver.FindElement(By.Id("Empleados + verAcceder"));
            IWebElement permisosVerAcceder = driver.FindElement(By.Id(subMenu + " + verAcceder"));
            return permisosVerAcceder;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesPermisoModificar(IWebDriver driver, string subMenu)
        {
            //Identificar el elemento para asignar un permiso para modificar, enviando al metodo el submenu para asignar el permiso.
            IWebElement permisosModificar = driver.FindElement(By.Id(subMenu + " + modificar"));
            return permisosModificar;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesPermisoEliminar(IWebDriver driver, string subMenu)
        {
            //Identificar el elemento para asignar un permiso para eliminar, enviando al metodo el submenu para asignar el permiso.
            IWebElement permisosEliminar = driver.FindElement(By.Id(subMenu + " + Eliminar"));
            return permisosEliminar;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesPermisoCrear(IWebDriver driver, string subMenu)
        {
            //Identificar el elemento para asignar un permiso para eliminar, enviando al metodo el submenu para asignar el permiso.
            IWebElement permisosCrear = driver.FindElement(By.Id(subMenu + " + Crear"));
            return permisosCrear;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesMensajeNombreRol(IWebDriver driver)
        {
            //Identificar el elemento para validar mensajes de campos obligatorios en el nombre del rol.
            IWebElement permisosCrear = driver.FindElement(By.XPath("//*[@id='forma']/div/div[1]/div/span[2]"));
            return permisosCrear;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesMensajePermisos(IWebDriver driver)
        {
            //Identificar el elemento para validar mensajes de campos obligatorios en el nombre del rol.
            IWebElement permisos = driver.FindElement(By.XPath("//*[@id='forma']/div/div[3]/div/span[2]"));
            return permisos;
        }

        //Metodo para identificar elementos de de la sección de roles.
        public IWebElement ElementosRolesEliminar(IWebDriver driver, int regitro)
        {
            //Identificar el elemento para validar mensajes de campos obligatorios en el nombre del rol.
            IWebElement eliminarRol = driver.FindElement(By.XPath("//*[@id='tabla-roles']/tbody/tr[" + regitro + "]/td[4]/i"));
            return eliminarRol;
        }

        public IWebElement ElementosRolesEditar (IWebDriver driver, int regitro)
        {
            //Identificar el elemento para validar mensajes de campos obligatorios en el nombre del rol.
            IWebElement editarRol = driver.FindElement(By.XPath("//*[@id='tabla-roles']/tbody/tr[" + regitro + "]/td[4]/a"));
            return editarRol;
        }

    }
}
