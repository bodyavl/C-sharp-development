using System;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a number to show in seven segment style: ");
            int input;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                SegmentNumber segmentNumber = new SegmentNumber(input);
                segmentNumber.output();
            }
            catch (OverflowException)
            { 
                Console.WriteLine("The number you entered is too big");
            }
            catch(FormatException)
            {
                Console.WriteLine("Number is not valid");
            }
            
        }
    }
}
