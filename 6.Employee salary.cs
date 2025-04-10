using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter hourly wage: ");
        double hourlyWage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter hours worked: ");
        double hoursWorked = Convert.ToDouble(Console.ReadLine());

        double salary = hourlyWage * hoursWorked;

        Console.WriteLine("Total Salary: " + salary);
    }
}
