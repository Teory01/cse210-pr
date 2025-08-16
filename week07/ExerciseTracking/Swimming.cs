using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance (km) = laps * 50m / 1000
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        return (GetDistance() / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per km) = minutes / distance
        return LengthMinutes / GetDistance();
    }
}
