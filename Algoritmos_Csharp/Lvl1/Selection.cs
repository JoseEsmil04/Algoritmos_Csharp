using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Csharp.Lvl1
{
    public class Selection
    {
        // Método que realiza el ordenamiento de un array utilizando el algoritmo de Selection Sort
        public static int[] Sort(int[] numbers)
        {
            // Guardamos la longitud del array para no tener que calcularlo en cada iteración
            int n = numbers.Length;

            // Primer bucle: Recorre el array desde el primer hasta el penúltimo elemento
            for (int i = 0; i < n; i++)
            {
                // Inicialmente, asumimos que el índice del elemento más pequeño es el actual (i)
                int minIndex = i;

                // Segundo bucle: Busca el elemento más pequeño en la parte no ordenada del array
                for (int j = i + 1; j < n; j++)
                {
                    // Si encontramos un elemento más pequeño, actualizamos minIndex
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }

                    // Intercambiamos el elemento actual (numbers[i]) con el elemento más pequeño encontrado (numbers[minIndex])
                    int temporary = numbers[i]; // Guardamos el valor de numbers[i] temporalmente
                    numbers[i] = numbers[minIndex]; // Asignamos el valor mínimo en la posición de i
                    numbers[minIndex] = temporary; // Colocamos el valor original de i en la posición de minIndex
                }
            }

            // Retornamos el array ordenado
            return numbers;
        }
    }

}
