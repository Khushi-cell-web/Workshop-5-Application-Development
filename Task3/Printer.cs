using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        // Print an integer number
        public void Print(int number)
        {
            Console.WriteLine($"Number: {number}");
        }

        // Print a message multiple times
        public void Print(string message, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"{i}: {message}");
            }
        }
    }
}
