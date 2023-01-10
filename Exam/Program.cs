using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cars cars = new Cars(new GermanCar
            {
                Colors = { "red", "green", "blue", "black", "white" },
                Year = 2020,
                Price = 20_000.00F,
                DoorCount = 4
            },
            new GermanCar
            {
                Colors = { "black", "grey", "white", "yellow" },
                Year = 2022,
                Price = 60_000.00F,
                DoorCount = 2
            },
            new GermanCar
            {
                Colors = { "white", "brown" },
                Year = 2021,
                Price = 40_000.00F,
                DoorCount = 4
            },
            new GermanCar
            {
                Colors = { "pink", "blue", "green" },
                Year = 2020,
                Price = 22_000.00F,
                DoorCount = 4
            },
            new GermanCar
            {
                Colors = { "black", "white" },
                Year = 2023,
                Price = 50_000.00F,
                DoorCount = 2
            });

            GermanCar suitableCar = new GermanCar();
            string color = "";
            int year = 0;
            float price = 0;
            int doorCount = 0;

            Console.WriteLine("Enter color you want / Press enter to skip: ");
            string strColor = Console.ReadLine();
            if (!string.IsNullOrEmpty(strColor)) color = strColor.ToLower();

            Console.WriteLine("Enter year you want / Press enter to skip: ");
            string strYear;
            bool isInt = false;
            do
            {
                strYear = Console.ReadLine();
                if (string.IsNullOrEmpty(strYear)) break;
                isInt = int.TryParse(strYear, out year);
                if (isInt && year > 0) break;
                Console.WriteLine("Enter a valid value: ");
            } 
            while (true);

            Console.WriteLine("Enter price you want / Press enter to skip: ");
            string strPrice;
            bool isFloat;
            do
            {
                strPrice = Console.ReadLine();
                if (string.IsNullOrEmpty(strPrice)) break;
                isFloat = float.TryParse(strPrice, out price);
                if (isFloat && price > 0) break;
                Console.WriteLine("Enter a valid value: ");
            }
            while (true);

            Console.WriteLine("Enter door count you want / Press enter to skip: ");
            string strDoorCount;
            isInt = false;
            do
            {
                strDoorCount = Console.ReadLine();
                if (string.IsNullOrEmpty(strDoorCount)) break;
                isInt = int.TryParse(strDoorCount, out doorCount);
                if (isInt && doorCount > 0) break;
                Console.WriteLine("Enter a valid value: ");
            }
            while (true);

            bool isFound = cars.TryFindCar(ref suitableCar, color, year, price, doorCount);
            
            // Якщо колір не вказаний, то виводяться всі кольори які є в потрібного авто
            if(isFound && color == "")
            {
                for (int i = 0; i < suitableCar.Colors.Count; i++)
                {
                    color += $"{suitableCar.Colors[i]} ";
                }
            }
            if(isFound)
            {
                Console.WriteLine($"Car that matches your requirements:\nColor: {color}\nYear: {suitableCar.Year}\nPrice: {suitableCar.Price}\nDoor Count: {suitableCar.DoorCount}");
            }
            else
            {
                Console.WriteLine("Suitable car is not found");
            }

        }
    }
}