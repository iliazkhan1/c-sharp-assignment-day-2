using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine()); 

        int a = 0, b = 1, next; 

        Console.Write("Fibonacci Sequence: " + a + " " + b + " "); 

        for (int i = 2; i < n; i++) 
        {
            next = a + b; 
            Console.Write(next + " "); 
            a = b; 
            b = next;
        }
    }
}
