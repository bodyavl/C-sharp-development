using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Cars
    {
        public GermanCar[] GermanCars { get; private set; }

        public Cars(params GermanCar[] cars)
        {
            GermanCars = new GermanCar[5];

            for (int i = 0; i < GermanCars.Length; i++)
            {
                GermanCars[i] = cars[i];
            }

        }
        public bool TryFindCar(ref GermanCar suitableCar, string color, int year, float price, int doorCount)
        {
            for(int i = 0; i < GermanCars.Length; i++)
            {
                if (color != "" && !GermanCars[i].HasColor(color)) continue;
                if (year != 0 && GermanCars[i].Year != year) continue;
                if (price != 0 && GermanCars[i].Price != price) continue;
                if (doorCount != 0 && GermanCars[i].DoorCount != doorCount) continue;

                suitableCar = GermanCars[i];
                return true;
            }
            return false;
        }
    }
}
