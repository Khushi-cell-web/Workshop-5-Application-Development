using System;

public class Teacher
{
    public string Name;

    public virtual void Teaching()

    {
        Console.WriteLine("Teacher teaches in english");
    }

    public void SalaryInfo()

    {
        Console.WriteLine("Salary information cannot be overridden");
    }
}