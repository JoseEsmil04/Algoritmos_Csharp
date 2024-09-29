using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Csharp.Lvl1
{
    public class Binary
    {
        public static int Search(int[] numbers, int target)
        {
            // Definimos los límites iniciales del array: 'left' (izquierda) y 'right' (derecha)
            int left = 0;
            int right = numbers.Length - 1;

            // Ordenamos el array para que los elementos estén en orden ascendente.
            // Esto es necesario para que la búsqueda binaria funcione correctamente.
            numbers = numbers.OrderBy(x => x).ToArray();

            // Comenzamos el ciclo while, que continuará mientras el límite izquierdo sea menor que el derecho
            while (left < right)
            {
                // Calculamos el índice del punto medio del array.
                // Esto es una mejora a la fórmula clásica para evitar desbordamientos en arrays grandes.
                int middle = left + right / 2;

                // Si el valor en el medio es igual al objetivo (target), retornamos su índice
                if (numbers[middle] == target)
                {
                    return middle;
                }
                // Si el valor en el medio es menor que el objetivo, movemos el límite izquierdo a la derecha del medio
                else if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                // Si el valor en el medio es mayor que el objetivo, movemos el límite derecho a la izquierda del medio
                else
                {
                    right = middle - 1;
                }
            }

            // Si el ciclo termina y no se encontró el valor, retornamos -1 indicando que no está en el array
            return -1;
        }
    }
}

