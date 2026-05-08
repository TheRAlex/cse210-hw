using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
       
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1,11);

        int guess = -1;

        while (magicnumber != guess)
        {
        Console.WriteLine($"What is the magic number {magicnumber}");
        Console.WriteLine($"What is your guess?");
        guess = int.Parse(Console.ReadLine());

        if (guess > magicnumber)
        {
            Console.WriteLine("Lower");
        }

        else if (guess == magicnumber)
        {
            Console.WriteLine("You guessed it!");
        }

        else
        {
            Console.WriteLine("Higher");
        }

            
        }
        




    }
}