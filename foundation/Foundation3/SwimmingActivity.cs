using System;


public class SwimmingActivity : Activity
{

    private double _laps;

    public SwimmingActivity(int duration, double laps) : base(duration)
    {
        _duration = duration;
        _date = GetDate();
        _activityType = "Swimming";
        _laps = laps;
    }
    
    public override double GetDistance()
    {
        double distanceSwam = (_laps * 50/ 1000);
        return distanceSwam;
    }
    
     public override double GetSpeed()
    {
        double speed = (_laps * 50 / 1000) / _duration * 60;
        return Math.Round(speed, 2);
    }

    public override double GetPace()
    {
        double pace = 1/ ((_laps * 50 / 1000) / _duration);
        return Math.Round(pace, 2);
    }

}