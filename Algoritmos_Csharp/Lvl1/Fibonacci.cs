using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Csharp.Lvl1
{
    public class Fibonacci
    {
        public static int[] Metodo(int n)
        {
            if (n <= 0)
            {
                return []; // Si es menor o igual a 0, retornamos array vacio.
            }
            else if (n == 1)
            {
                return [0]; // Si es igual a 1, retornamos el primer valor que siempre es 0.
            }
            else if(n == 2)
            {
                return [0, 1]; // Si es igual a 2, solo retornamos los dos valores.
            }
            else
            {
                int[] fibSequence = [0, 1]; // Inicializamos el array con los dos primeros números de Fibonacci.

                int a = 0, b = 1; // Variables para guardar los dos últimos números de la secuencia.

                // Bucle que empieza en 2 porque ya tenemos los primeros dos valores en el array.
                for (int i = 2; i < n; i++)
                {
                    int nextFib = a + b; // Calculamos el siguiente número de Fibonacci sumando los dos anteriores.

                    fibSequence[i] = nextFib; // Asignamos el número calculado en la posición correspondiente del array.
                    a = b; // Actualizamos 'a' con el valor de 'b'.
                    b = nextFib; // Actualizamos 'b' con el valor del nuevo número de Fibonacci.
                }

                return fibSequence; // Retornamos la secuencia completa.
            }

        }
    }
}
