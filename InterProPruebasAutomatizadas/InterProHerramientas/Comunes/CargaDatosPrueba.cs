﻿using System.Collections.Generic;
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
                                 ServicioBuro = row["ServicioBuro"].Cast<string>(),
                                 ServicioTarjeta = row ["ServicioTarjeta"].Cast<string>()
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }
    }
}