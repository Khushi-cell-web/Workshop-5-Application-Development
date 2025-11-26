using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device) => devices.Add(device);

        public void RemoveDevice(ElectronicDevice device) => devices.Remove(device);

        public void ShowAllDeviceDetails()
        {
            foreach (var d in devices)
            {
                d.ShowInfo();

                if (d is Laptop l)
                    l.TurnOnBattery();

                if (d is Smartphone s)
                    s.EnableCamera();

                Console.WriteLine("");
            }

        }
    }
}