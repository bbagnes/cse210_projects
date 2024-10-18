using System;
using System.ComponentModel;


public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    { 

    }

    public void Run()
    {
        DisplayStartMessage();

        Console.Write("Get Ready....");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            Console.WriteLine("");
            Console.Write("Breath in for:  ");
            ShowCountDown(4);

            Console.Write("Now Breath Out:  ");
            ShowCountDown(6);
        }

        Console.WriteLine("");
        DisplayEndMessage();
    } 
}