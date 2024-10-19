/*For this week's Show Creativity and Exceeding Requirements I added a method to remove each question 
from the list of questions used in the Reflection Activity after it had been used once to prevent repetition.
 This method does not prevent any questions from being reused if the Reflection Activity is run again.*/

using System;


public class ReflectionActivity : Activity
{
    List<string> _prompts = new List<string>();

    List<string> _questions = new List<string>();

    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
         _prompts.Add("Think of a time when you stood up for someone else.");

        _prompts.Add("Think of a time when you did something truly selfless.");

        _prompts.Add("Think of a time when you did something really difficult.");

        _prompts.Add("Think of a time when you helped someone in need.");

        _questions.Add("Why was this experience meaningful to you?");

        _questions.Add("Have you ever done anything like this before?");

        _questions.Add("How did you get started?");

        _questions.Add("How did you feel when it was complete?");

        _questions.Add("What made this time different than other times when you were not as successful?");

        _questions.Add("What is your favorite thing about this experience?");

        _questions.Add("What could you learn from this experience that applies to other situations?");

        _questions.Add("What did you learn about yourself through this experience?");

        _questions.Add("How can you keep this experience in mind in the future?");
         
    }
    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("");

        Console.Write("Get Ready...  ");
        ShowSpinner(3);
        Console.WriteLine("");

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        GetRandomPrompt();
        DisplayPrompt();
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();     

        Console.WriteLine("Now ponder of each of the following questions as they relate to this experience.");
        Console.WriteLine("");
        Console.Write("You may begin in:  ");
        ShowCountDown(5);

        int timeDivisor = _questions.Count;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now <= endTime)
        {
            string newQuestion = GetRandomQuestion();
            string[] questionInformation = newQuestion.Split(",");
            string questionToUSe = questionInformation[0];
            string questionNumber = questionInformation[1];
            int qNumber = int.Parse(questionNumber);

            Console.WriteLine("");
            DisplayQuestion(questionToUSe);
            _questions.RemoveAt(qNumber);            

            if (_duration > 90)
            {
                ShowSpinner((_duration / timeDivisor));
            }

            else
            {
                ShowSpinner(5);
            }                                 
        }
        Console.WriteLine("");
        DisplayEndMessage();
    } 

    public string GetRandomPrompt()
    {       
        Random prompting = new Random();
        int r = prompting.Next(_prompts.Count);
        string prompt = _prompts[r];
        return prompt;
    }

    public string GetRandomQuestion()
    {        
        Random questions = new Random();
        int R = questions.Next(_questions.Count);
        string question = _questions[R];
        string questionInfo = $"{question}, {R} ";
        return questionInfo;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"* * * {GetRandomPrompt()} * * *");
    }

    public void DisplayQuestion(string question)
    {
        Console.Write($"> {question}  ");
    }

}