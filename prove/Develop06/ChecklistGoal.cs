using System;
using System.Formats.Asn1;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;

        _bonus = bonus;
    }

    public override void RecordEvent()
        {
            Console.WriteLine($"Congratulations, you have earned {_points} points.");
            _amountCompleted ++;

            if (_amountCompleted == _target)
            {
               Console.WriteLine($"Congratulations, you have completed this task and earned {_bonus} bonus points!"); 
            }
        }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        bool completionCheck = IsComplete();
        if (completionCheck == true)
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}&{_description}&{_points}&{_target}&{_bonus}&{_amountCompleted}";
    }

    public void SetCompletion(int complete)
    {
        _amountCompleted = complete;
    }

    public override int GetPoints()
    {
        if (IsComplete() == true)
        {
            int earnedPoints = int.Parse(_points);
            earnedPoints = earnedPoints + _bonus;
            return earnedPoints;
        }

        else
        {
            int earnedPoints = int.Parse(_points);
            return earnedPoints;
        }
    }
}