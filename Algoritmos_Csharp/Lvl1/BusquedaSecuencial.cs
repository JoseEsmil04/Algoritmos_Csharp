namespace Algoritmos_Csharp.Lvl1
{
    /// El algoritmo de búsqueda secuencial es un método para encontrar un valor en una lista o vector no ordenado.
    /// Consiste en comparar el valor objetivo con cada elemento de la lista, uno a uno, hasta encontrarlo o llegar al final.
    /// Si se encuentra, devuelve su posición; si no, indica que no está presente. Este algoritmo es sencillo pero ineficiente, 
    /// ya que en el peor de los casos requiere recorrer toda la lista para determinar si el valor existe.

    public class BusquedaSecuencial
    {
        public static int Search(int[] arr, int target)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == target)
                {
                    return i; // Si se encuentra se devuelve el indice.
                }
            }

            return -1; // Si no, retornamos -1
        }
    }
}
