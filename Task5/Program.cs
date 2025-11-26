namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicsStore store = new ElectronicsStore();

            Laptop l = new Laptop("Dell", 1200);
            Smartphone s = new Smartphone("Samsung", 900);

            store.AddDevice(l);
            store.AddDevice(s);

            store.ShowAllDeviceDetails();
            Console.WriteLine("");
        }
    }
}