using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    protected Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    public int LengthMinutes => _lengthMinutes;

    // Abstract methods to be implemented in derived classes
    public abstract double GetDistance(); // km or miles
    public abstract double GetSpeed();    // kph or mph
    public abstract double GetPace();     // min per km or mile

    // Virtual method for summary
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({LengthMinutes} min) - " +
               $"Distance: {GetDistance():0.00}, Speed: {GetSpeed():0.00}, Pace: {GetPace():0.00}";
    }
}