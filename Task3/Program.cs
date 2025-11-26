using System.Reflection;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Printer object
            Printer myPrinter = new Printer();

            // Call all overloaded methods
            myPrinter.Print("Hello, World!");    
            myPrinter.Print(2025);               
            myPrinter.Print("Repeat this", 3);   // Print message multiple times
        }
    }
}
