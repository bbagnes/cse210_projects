using System;

class Program
{
     
    static void Main(string[] args)
    {
        Activity activity = new Activity("activity", "This activity is purely for the purposes of demonstrating the Twinkling Stars method", 30);
        
        activity.DisplayStartMessage();
        Console.WriteLine("");        
        activity.ShowTwinklingStars();
        Console.WriteLine("");
    }
}