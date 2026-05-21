using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();

        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2010;
        job1._endYear = 2020;

        


        
        Job job2 = new Job();

        job2._company = "Steam";
        job2._jobTitle = "Beta Tester";
        job2._startYear = 2015;
        job2._endYear = 2026;

        
        Resume resume1 = new Resume();
        
        resume1._name = "Harold Smith";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();  

    }    
}