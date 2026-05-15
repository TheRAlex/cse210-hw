// Added another data type in the entry so now the user can add who wrote the journal.
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("Please Select one the options.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            
            

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();
                Console.WriteLine("Written by:");
                string answer2 = Console.ReadLine();
                Entry entry = new Entry();                
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = answer;
                entry._signature = answer2;
                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.WriteLine("Filename:");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
        }
    }
}