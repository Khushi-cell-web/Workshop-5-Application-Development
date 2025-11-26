using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Motorcycle : Vehicle
    {
        // Unique field
        public bool HasCarrier;

        // Constructor
        public Motorcycle(string brand, double speed, bool hasCarrier)
        {
            Brand = brand;
            Speed = speed;
            HasCarrier = hasCarrier;
        }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }

}
