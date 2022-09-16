using System;


namespace Cylinder_volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R = 0;
            string? strR;
            int H = 0;
            string? strH;
            bool RisValid = false;
            bool HisValid = false;
            double result;
            
            do
            {
                Console.Write("Enter cylinder base radius: ");
                strR = Console.ReadLine();
                RisValid = int.TryParse(strR, out R);
                if (RisValid) break;
                Console.WriteLine("Enter a valid value");
            } while (!RisValid);

            do
            {
                Console.Write("Enter cylinder height: ");
                strH = Console.ReadLine();
                HisValid = int.TryParse(strH, out H);
                if (HisValid) break;
                Console.WriteLine("Enter a valid value");
            } while (!HisValid);

            result = (double)Math.PI * Math.Pow(R, 2) * H;
            Console.WriteLine($"The cylinder volume is: {result:n4}");
        }
    }
}