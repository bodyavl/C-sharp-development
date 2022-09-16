using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn = 0;
            string? strnn;
            bool nnIsValid;
            int nk = 0;
            string? strnk;
            bool nkIsValid;
            double result = 0;
            do
            {
                Console.WriteLine("Enter first index");
                strnn = Console.ReadLine();
                nnIsValid = int.TryParse(strnn, out nn);
                if (nnIsValid && nn >= 0) break;
                Console.WriteLine("Enter a valid value");
            } while (!nnIsValid);
            do
            {
                Console.WriteLine("Enter second index");
                strnk = Console.ReadLine();
                nkIsValid = int.TryParse(strnk, out nk);
                if (nkIsValid) nkIsValid = nk >= nn;
                if (nkIsValid) break;
                Console.WriteLine("Enter a valid value");
            } while (!nkIsValid);

            for (int k = nn; k <= nk; k++)
            {
                result += (Math.Pow(-1, Math.Pow(k, 2)+1) * Math.Pow(k, 2) - 2) / (3 * Math.Pow(k, 2) - 2 * k);
            }
            Console.WriteLine($"Result is {result:n4}");

        }
    }
}
