public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!\n");

        Console.WriteLine(_description);
        Console.WriteLine($"\nHow long in seccond would you like to be in this activity?");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!\n");
        ShowSpinner(5);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i = (i + 1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
      for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }  
    }
}