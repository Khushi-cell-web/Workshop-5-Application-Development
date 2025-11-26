using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car : Vehicle
    {
        // Unique field
        public int Seats;

        // Constructor
        public Car(string brand, double speed, int seats)
        {
            Brand = brand;
            Speed = speed;
            Seats = seats;
        }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
