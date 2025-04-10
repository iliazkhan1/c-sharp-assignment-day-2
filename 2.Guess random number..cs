using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int secret = random.Next(1, 11);
        int attempts = 4;

        Console.WriteLine("Guess a number between 1 and 10 ( 4 attempts):");

        for (int i = 1; i <= attempts; i++)
        {
            Console.Write("Attempt " + i + ": ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secret)
            {
                Console.WriteLine("You guessed correct!");
                return; 
            }
            else 
                Console.WriteLine("Try again its wrong!");
        }

        Console.WriteLine("Out of attempts! The correct number is: " + secret);
    }
}
