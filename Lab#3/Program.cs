using System;

namespace Lab3_university
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string? strNum;
            bool numIsValid = false;
            do
            {
                Console.WriteLine("Enter number");
                strNum = Console.ReadLine();
                numIsValid = int.TryParse(strNum, out num);
                if (numIsValid) break;
                Console.WriteLine("Enter a valid number");
            } while (!numIsValid);

            //перевірка чи число непарне і тризначне
            bool numIsWhatWeNeed = num % 2 != 0 && strNum?.Length == 3;

            Console.WriteLine(numIsWhatWeNeed);
        }
    }
}