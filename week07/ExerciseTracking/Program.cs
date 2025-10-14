using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity run1 = new RunningActivity(new DateTime(2025, 10, 13), 30, 3);

        CyclingActivity cycle1 = new CyclingActivity(new DateTime(2025, 10, 13), 45, 20);

        SwimmingActivity swim1 = new SwimmingActivity(new DateTime(2025, 10, 13), 60, 40);

        List<Activity> activities = new List<Activity>();
        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swim1);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
    

}