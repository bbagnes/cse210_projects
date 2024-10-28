using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity runningActivity1 = new RunningActivity(30, 5.2);
        activities.Add(runningActivity1);

        CyclingActivity cyclingActivity1 = new CyclingActivity(30, 19);
        activities.Add(cyclingActivity1);

        SwimmingActivity swimmingActivity1 = new SwimmingActivity(10, 14);
        activities.Add(swimmingActivity1);

        foreach (Activity activity in activities)
        {
        Console.WriteLine("");
        Console.WriteLine(activity.GetSummary());        
        }

        Console.WriteLine("");
    }
}