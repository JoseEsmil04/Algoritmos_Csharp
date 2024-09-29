


using Algoritmos_Csharp.Lvl1;

class Program
{
    static void Main(string[] args)
    {
        string cadena = "holaesmilaaaaaesmil";
        string sub = "esmil";

        var result = Subcadena.BuscarSub(cadena, sub);
        
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        
    }
}