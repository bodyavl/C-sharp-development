using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class GermanCar
    {
        public List<string> Colors { get; set; } = new List<string>();
        public int Year { get; set; }
        public float Price { get; set; }
        public int DoorCount { get; set; }
       
        public bool HasColor(string color)
        {
            return Colors.Contains(color);
        }
    }
}
