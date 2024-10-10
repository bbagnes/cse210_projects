using System;


public class Entry
{
    
    public string _date;
 
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        _date = GetDate();
        Prompt prompt = new Prompt();
        _promptText = prompt.GetRandomPrompt();
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }
    
    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }

    public void DisplayEntryDetails()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
            Console.WriteLine(_entryText);
        }

   static string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();
        return dateText;
    }

}