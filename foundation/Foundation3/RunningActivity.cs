using System;
using System.Data.Common;
using System.IO.Pipes;
using System.Runtime.CompilerServices;


public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(int duration, double distance) : base(duration)
    {
        _duration = duration;
        _date = GetDate();
        _activityType = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = _distance / _duration * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _duration /_distance;
        return Math.Round(pace, 2);
    }
}