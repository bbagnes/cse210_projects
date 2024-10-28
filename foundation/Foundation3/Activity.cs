using System;


public abstract class Activity
{
    protected int _duration;

    protected string _date;

    protected string _activityType = "";

    public Activity(int duration)
    {
        _duration = duration;
        _date = GetDate();
    }

    public string GetSummary()
    {
        return $"{GetDate()} {_activityType} ({_duration} Min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km.";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }    

    public string GetDate()
    {
        DateTime recordDate  = DateTime.Now;

        _date = recordDate.ToString("dd MMM yyyy");
        return _date;
    }
}