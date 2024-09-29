


using Algoritmos_Csharp.Lvl1;

class Program
{
    static void Main(string[] args)
    {
       

        var result = ConteoPalabras.Contar("Hola Esmil como estas. Hola Michelle como estas");
        
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }    
        
    }
}