using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have completed this goals and earned {_points} points!");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}&{_description}&{_points}&{_isComplete}";
    }

    public void SetCompletion()
    {
        _isComplete = true;
    }

}