using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Algoritmos_Csharp.Lvl1
{
    public class ConteoPalabras
    {
        public static Dictionary<string, int> Contar(string texto)
        {
            // Usamos Regex para dividir el texto en palabras, permitiendo múltiples espacios, tabulaciones, saltos de línea, etc.
            // Split divide el texto cada vez que encuentra uno o más espacios en blanco (regex \s+).
            string[] palabras = Regex.Split(texto, @"\s+");

            // Creamos un diccionario que almacenará las palabras en minúsculas como clave y el número de ocurrencias como valor.
            Dictionary<string, int> result = new();

            // Iteramos sobre cada palabra obtenida del texto.
            foreach (string palabra in palabras)
            {
                // Convertimos la palabra a minúsculas para hacer el conteo insensible a mayúsculas/minúsculas.
                var palLower = palabra.ToLower();

                // Verificamos si la palabra ya existe en el diccionario.
                if (result.ContainsKey(palLower))
                {
                    // Si la palabra ya está en el diccionario, incrementamos su valor (conteo).
                    result[palLower]++;
                }
                else
                {
                    // Si la palabra no está en el diccionario, la agregamos con un valor inicial de 1.
                    result[palLower] = 1;
                }
            }

            // Devolvemos el diccionario con las palabras y sus respectivos conteos.
            return result;
        }
    }

}
