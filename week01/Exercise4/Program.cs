using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<int> numbers = new List<int>();

        int user_input = -1;
        while (user_input != 0)
        {
            Console.WriteLine("Enter a number or 0 to quit");

            string number_input  = Console.ReadLine();
            user_input = int.Parse(number_input);

            if(user_input != 0)
            {
                numbers.Add(user_input);
            }


        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average  = ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}