using System;
using System.Text;

namespace InterProHerramientas.Comunes
{
    public class GeneracionCadenas
    {
        public string GenerarCadenasAlfanumericas(string longitud)
        {
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < Convert.ToInt32(longitud); i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            return token.ToString();
        }
    }
}
