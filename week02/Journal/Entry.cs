public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _signature;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"Written by: {_signature}");
        Console.WriteLine();
    }
}