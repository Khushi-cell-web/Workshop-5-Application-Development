using System;

class Program
{
    static void Main(string[] args)
    {
        NepaliTeacher nepali = new NepaliTeacher();
        nepali.Name = "Ram";
        Console.WriteLine("Name: " + nepali.Name);
        nepali.Teaching();
        nepali.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher english = new EnglishTeacher();
        english.Name = "John";
        Console.WriteLine("Name: " + english.Name);
        english.Teaching();
        english.SalaryInfo();
    }
}