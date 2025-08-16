using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 8, 10), 30, 5.0), // 5 km in 30 min
            new Cycling(new DateTime(2025, 8, 11), 40, 20.0), // 20 kph for 40 min
            new Swimming(new DateTime(2025, 8, 12), 25, 30)   // 30 laps
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
