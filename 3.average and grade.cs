using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter marks for 3 subjects: ");

        double sub1 = Convert.ToDouble(Console.ReadLine()); 
        double sub2 = Convert.ToDouble(Console.ReadLine()); 
        double sub3 = Convert.ToDouble(Console.ReadLine()); 

        double average = (sub1 + sub2 + sub3) / 3; 

        char grade;

        if (average >= 90) grade = 'A';
        else if (average >= 80) grade = 'B';
        else if (average >= 70) grade = 'C';
        else if (average >= 60) grade = 'D';
        else grade = 'F';

        Console.WriteLine("Average Marks: " + average); 
        Console.WriteLine("Grade: " + grade); 
    }
}
