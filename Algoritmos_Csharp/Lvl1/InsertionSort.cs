namespace Algoritmos_Csharp.Lvl1
{
    public class InsertionSort
    {
        public static int[] Insertion(int[] arr)
        {
            // Recorremos todo el arreglo, empezando desde el segundo elemento
            for (int i = 1; i < arr.Length; i++)
            {
                // Guardamos el valor actual como la "clave" para realizar comparaciones
                int key = arr[i];

                // Iniciamos la comparación desde el elemento anterior al actual
                int j = i - 1;

                // Mover los elementos de la porción ordenada que sean mayores que la clave,
                // un espacio a la derecha, para hacer espacio para insertar la clave en su lugar correcto
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j]; // Desplazamos el elemento a la derecha
                    j--; // Avanzamos hacia la izquierda para seguir comparando
                }

                // Insertamos la clave en el lugar correcto dentro de la porción ordenada
                arr[j + 1] = key;
            }

            // Retornamos el arreglo ya ordenado
            return arr;
        }
    }
}
