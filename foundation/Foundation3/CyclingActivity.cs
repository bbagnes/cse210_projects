using System;


public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(int duration, float speed) : base(duration)
    {        
        _duration = duration;
        _date = GetDate();
        _activityType = "Cylcing";
        _speed = speed;        
    }

    public override double GetDistance()
    {
        double distance = _speed * _duration / 60;
        return distance;
    }
     public override double GetSpeed()
    {        
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60/_speed;
        return Math.Round(pace, 2);
    }
}