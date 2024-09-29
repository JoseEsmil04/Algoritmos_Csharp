namespace Algoritmos_Csharp.Lvl1
{
    public class Factorial
    {
        public static int Operation(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
