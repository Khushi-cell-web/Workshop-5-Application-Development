using System;
using System.Runtime.ConstrainedExecution;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car object
            Car myCar = new Car("Toyota", 120, 5);
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine();

            // Motorcycle object
            Motorcycle myMotorcycle = new Motorcycle("Honda", 90, true);
            myMotorcycle.Start();
            myMotorcycle.DisplayInfo();
            myMotorcycle.Stop();
        }
    }
}
