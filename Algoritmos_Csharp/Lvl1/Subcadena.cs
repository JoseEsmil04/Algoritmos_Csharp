namespace Algoritmos_Csharp.Lvl1
{
    public class Subcadena
    {
        public static List<int> BuscarSub(string cadenaPrincipal, string subCadena)
        {
            // Obtener la longitud de la cadena principal.
            int n = cadenaPrincipal.Length;

            // Obtener la longitud de la subcadena.
            int m = subCadena.Length;

            // Lista que almacenará las posiciones donde se encuentran las coincidencias.
            List<int> ocurrencias = new();

            // Bucle principal: recorre la cadena principal desde el primer carácter hasta el punto
            // donde todavía es posible encontrar la subcadena (n - m + 1 para evitar desbordamientos).
            for (int i = 0; i < n - m + 1; i++)
            {
                // Inicializamos j a 0, que se utilizará para comparar los caracteres de la subcadena.
                int j = 0;

                // Bucle interno: compara los caracteres de la subcadena con los caracteres de la cadena principal.
                while (j < m)
                {
                    // Si los caracteres no coinciden, se interrumpe el bucle interno.
                    if (cadenaPrincipal[i + j] != subCadena[j])
                    {
                        break; // Si encontramos una diferencia, salimos del bucle.
                    }

                    // Si los caracteres coinciden, avanzamos al siguiente carácter de la subcadena.
                    j++;
                }

                // Si j es igual a la longitud de la subcadena, significa que se encontró una coincidencia completa.
                if (j == m)
                {
                    // Agregamos el índice inicial donde comenzó la coincidencia en la cadena principal.
                    ocurrencias.Add(i);
                }
            }

            // Devolvemos la lista con las posiciones donde se encontraron las coincidencias.
            return ocurrencias;
        }

    }
}
