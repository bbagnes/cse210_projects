using System;


public class ListingActivity : Activity
{
    private int _count = 0; 
   
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    
    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("");

        Console.Write("Get Ready...  ");
        ShowSpinner(2);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");

        Console.WriteLine($"* * * {GetRandomPrompt()} * * *");
        Console.WriteLine("");

        Console.Write("You May begin in:  ");
        ShowCountDown(6);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count ++;
        }
        
        Console.WriteLine("");
        Console.WriteLine($"You have listed {_count} items!");
        Console.WriteLine("");

        DisplayEndMessage();
    } 
    public string GetRandomPrompt()
    {    
        _prompts.Add("Who are people that you appreciate?");

        _prompts.Add("What are personal strengths of yours?");

        _prompts.Add("Who are people that you have helped this week?");

        _prompts.Add("When have you felt the Holy Ghost this month?");

        _prompts.Add("Who are some of your personal heroes?");
        
        Random prompting = new Random();
        int r = prompting.Next(_prompts.Count);
        string prompt = _prompts[r];
        return prompt;
    }

    public List<string> GetListFromUser()
    {

        List<string> listings = new List<string>{};        
        string listing = Console.ReadLine();
        listings.Add(listing);
        
        return listings;
    }
}