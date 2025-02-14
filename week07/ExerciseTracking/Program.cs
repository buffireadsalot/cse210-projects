using System;

// Main Program
class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("14 Feb 2025", 30, 3.0),
            new Cycling("14 Feb 2025", 30, 12.0),
            new Swimming("14 Feb 2025", 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
