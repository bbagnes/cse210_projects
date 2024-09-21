using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int percent = int.Parse(gradePercent);
        string letter;
        string sign;
        bool success;

        if (percent >= 90)
            {
                letter = "A";
            }

        else if (percent >= 80)
            {
                letter = "B";
            }

        else if (percent >= 70)
           {
                letter = "C";
           }

        else if (percent >= 60)
            {
                letter = "D";
            }

        else 
            {
                letter = "F";
            }

        int grade = percent % 10;
        if (grade >= 7)
            {
                sign = "+";
            }

        else if (grade <= 3)
            {
                sign = "-";
            }
        else
            {
                sign = "";
            }

        if (percent > 93 || letter == "F")
            {
                sign = "";
            }

        Console.WriteLine($"Your grade is a {letter}{sign}.");

        if (percent >= 70)
            {
                success = true;
            }

        else
            {
                success = false;
            }

        if (success)
            {
                Console.WriteLine ("Congratulations, you are passing the class.");
            }

        else
            {
                Console.WriteLine("Sorry, you failed. But at least you know what to expect next time.");
            }   
    }
}