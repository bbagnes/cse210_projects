using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public class GoalManager
{
    private List<Goal> _goals;

    private int _score = 0;

    private string menuChoice;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {
        
        Console.WriteLine("");
        DisplayPlayerInfo();
        Console.WriteLine("");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Creat New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
        Console.Write("Select a choice from the menu: ");
        menuChoice = Console.ReadLine();
        do
        {
            if(menuChoice == "1")
            {
                CreateGoal();
            }

            else if(menuChoice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("The choices are:");
                ListGoalNames();
            }

            else if(menuChoice == "3")
            {
                SaveGoals();
            }

            else if(menuChoice == "4")
            {
                LoadGoals();
            }

            else if(menuChoice == "5")
            {
                RecordEvent();
            }

            else if(menuChoice == "6")
            {
                break;
            }

        }while(menuChoice != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        GetPlayerRank();
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++) 
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            goal.GetDetailsString();
        }   
    }

    public void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("The types of Goals are: \n 1. Simple goal \n 2. Eternal Goal \n 3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        string response = Console.ReadLine();
        
        
        if (response == "1")
        {
            Console.WriteLine("");
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points for completing this goal? ");
            string points = Console.ReadLine();
            int goalpoints = int.Parse(points);

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }

        else if (response == "2")
        {
            Console.WriteLine("");
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points for completing this goal? ");
            string points = Console.ReadLine();
            
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }

        else if (response == "3")
        {
            Console.WriteLine("");
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points for each completion of this goal? ");
            string points = Console.ReadLine();

            Console.WriteLine("How many times does this goal need to be completed for a bonus? ");
            string targetString = Console.ReadLine();
            int target = int.Parse(targetString);

            Console.WriteLine("What is the bonus for completing the goal that many times? ");
            string bonusString = Console.ReadLine();
            int bonus = int.Parse(bonusString);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {        
        ListGoalNames();
        Console.Write("Which Goal have you completed? ");
        string recordComplete = Console.ReadLine();
        int completedGoal = (int.Parse(recordComplete) - 1);

        Console.WriteLine("");
        _goals[completedGoal].RecordEvent();        
        _score = _score + _goals[completedGoal].GetPoints();       
    }

    public void GetPlayerRank()
    {
        if(_score >= 16000)
        {
            Console.WriteLine("Congratulations, you have obtained the rank of: GrandMaster Keeper of Goals!!!!!");
            ShowTwinklingStars();
        }

        else if(_score >= 8000)
        {
            Console.WriteLine("Congratulations, you have obtained the rank of: Master Keeper of Goals!!!!");
        }

        else if(_score >= 4000)
        {
            Console.WriteLine("Congratulations, you have obtained the rank of: Keeper of Goals!!!");
        }

        else if(_score >= 2000)
        {
            Console.WriteLine("Congratulations, you have obtained the rank of: Journeyman Keeper of Goals!!");
        }

        else if(_score >= 500)
        {
            Console.WriteLine("Congratulations, you have obtained the rank of: Apprentence Keeper of Goals!");
        }
    }

    public void ShowTwinklingStars()
    {    
        int countDown = 2;

        Console.WriteLine("");
        Console.Write("                                           ");
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
    }

    public void SaveGoals()
    {
        Console.WriteLine("Please select a file name, and add the .txt extension. (Ex. goals.txt)");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            { 
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }  
    }

     public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file to load?");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);

        int savedPoints = int.Parse(lines[0]);
        _score = savedPoints;

        foreach(string line in lines.Skip(1))
        {
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string goalDetails = parts[1];

            // Console.WriteLine($"{goalType}   {goalDetails}");

            if (goalType == "SimpleGoal")
            {
                string[] details = goalDetails.Split("&");

                string goalName = details[0];

                string goalDescription = details[1];

                string goalPoints = details[2];

                string goalStatus = details[3];

                // Console.WriteLine($"{goalName}   {goalDescription}   {goalPoints}");

                SimpleGoal simpleGoal1 = new SimpleGoal(goalName, goalDescription, goalPoints);
                
                if (goalStatus == "True")
                {
                    simpleGoal1.SetCompletion();
                    _goals.Add(simpleGoal1);
                }

                else
                {
                    _goals.Add(simpleGoal1);
                }             
            }

            else if (goalType == "EternalGoal")
            {
                string[] details = goalDetails.Split("&");

                string goalName = details[0];

                string goalDescription = details[1];

                string goalPoints = details[2];

                // Console.WriteLine($"{goalName}   {goalDescription}   {goalPoints}");

                EternalGoal eternalGoal1 = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(eternalGoal1);
            }

            else if (goalType == "ChecklistGoal")
            {
                string[] details = goalDetails.Split("&");

                string goalName = details[0];

                string goalDescription = details[1];

                string goalPoints = details[2];


                string goalTarget = details[3];

                int targetNumber = int.Parse(goalTarget);

                string goalBonus = details[4];
                int bonusPoints = int.Parse(goalBonus);

                string timesCompleted = details[5];
                int goalProgress = int.Parse(timesCompleted);

                // Console.WriteLine($"{goalName}   {goalDescription}   {goalPoints}   {goalTarget}   {goalBonus}");

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, targetNumber, bonusPoints);

                checklistGoal.SetCompletion(goalProgress);
                _goals.Add(checklistGoal);
            }
        }
    }    
}
