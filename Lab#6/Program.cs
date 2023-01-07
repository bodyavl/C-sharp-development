using System;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse(1234);
            Reverse("ABC");
            Console.WriteLine();
            Reverse(123.456);
            Reverse("ABC,EFG");
            int[] array = new int[10];
            int[] reversedArray;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            ReverseArray(ref array, out reversedArray);
            Console.WriteLine("Original array:");
            PrintArray(array);
            Console.WriteLine("Reversed array:");
            PrintArray(reversedArray);
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static void Reverse(int num)
        {
            if(num < 10)
            {
                Console.Write(num);
                Console.WriteLine();
                return;
            }
            Console.Write(num % 10);
            Reverse(num / 10);

        }
        static void Reverse(string str)
        {
            if (string.IsNullOrEmpty(str)) return;
            if (str.Contains(','))
            {
                string[] splittedStirng = str.Split(',');
                Reverse(splittedStirng);
                return;
            }
            Console.Write(str[str.Length - 1]);
            Reverse(str.Substring(0, str.Length - 1));
        }
        static void Reverse(double num)
        {
            string[] splittedNum = num.ToString().Split(',');
            Reverse(splittedNum);
        }
        static void Reverse(string[] parts)
        {
            char[] firstPart = parts[0].ToCharArray();
            char[] secondPart = parts[1].ToCharArray();
            Reverse(ref firstPart);
            Reverse(ref secondPart);
            Console.WriteLine($"{new string(firstPart)},{new string(secondPart)}");
        }
        static void Reverse(ref char[] chars)
        {
            char[] reversedChars = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                reversedChars[i] = chars[chars.Length - i - 1];
            }
            chars = reversedChars;
        }
        static void ReverseArray(ref int[] array, out int[] reversedArray)
        {
            reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }
        }
    }
}