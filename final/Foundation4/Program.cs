using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("05/25/2024", 50, 5);
        Cycling cycle = new Cycling("06/25/2024", 50, 15);
        Swim swim = new Swim("07/25/2024", 50, 25);

        List<Activity> activities = [run, cycle, swim];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}