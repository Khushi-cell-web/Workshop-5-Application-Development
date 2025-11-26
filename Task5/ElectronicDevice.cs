using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        public string Brand { get; set; }
        public double Price { get; set; }

        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public abstract void ShowInfo();
    }
}