using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.Marshalling;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();     

    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        
        bool completionCheck = IsComplete();
        if (completionCheck == true)
        {
            return $"[X] {_shortName} ({_description})";
        }

        else
        {
            return $"[ ] {_shortName} ({_description})";
        }                   
    }

    public abstract string GetStringRepresentation();

    public virtual int GetPoints()
    {
        int earnedPoints = int.Parse(_points);
        return earnedPoints;
    }
            
}