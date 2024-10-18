using System;


public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _duration = 0;
    

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
            Console.WriteLine("");
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine(_description);
            Thread.Sleep(2000);
            Console.WriteLine("");

            Console.Write("How long, in seconds, would you like for your session to last? ");
            string programDuration = Console.ReadLine();
            _duration = int.Parse(programDuration);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!");

        ShowSpinner(2);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

        ShowSpinner(2);
    }

    public void ShowSpinner(int countdown)
    {
    
        int countDown = countdown;
        while (countDown > 0)
        {  
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("——");
            Thread.Sleep(500);

            Console.Write("\b\b  \b\b");
            Console.Write(@"\");
            Thread.Sleep(500);
            
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);

            countDown --;
        }
        Console.Write("\b \b");
        Console.WriteLine("");
    }

    public void ShowCountDown(int count)
    {
        int countDown = count;
        while (countDown > 0)
        {  
            Console.Write("\b \b");
            Console.Write($"{countDown}");
            Thread.Sleep(1000);

            countDown --;
        }
        Console.Write("\b \b");
        Console.WriteLine("");
    
    }

    public void ShowTwinklingStars()
        {
    
            int countDown = 30;
            while (countDown > 0)
            {
                Console.Write("\b\b\b\b\b     \b\b\b\b\b");
                Console.Write("' ' '");
                Thread.Sleep(1000);
    
                Console.Write("\b\b\b\b\b     \b\b\b\b\b");
                Console.Write("* ' '");
                Thread.Sleep(1000);

                Console.Write("\b\b\b\b\b     \b\b\b\b\b");
                Console.Write("' * '");
                Thread.Sleep(1000);

                Console.Write("\b\b\b\b\b     \b\b\b\b\b");
                Console.Write("' ' *");
                Thread.Sleep(1000);

                Console.Write("\b\b\b\b\b     \b\b\b\b\b");
                Console.Write("* * *");
                Thread.Sleep(1000);

                countDown --;
            }
            Console.Write("\b \b");
            Console.WriteLine("");
        }
}