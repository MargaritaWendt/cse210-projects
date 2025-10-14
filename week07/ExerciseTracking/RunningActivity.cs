using System.Runtime.CompilerServices;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, double lengthMinutes, double distance) : base("Running", date, lengthMinutes)
    {
        _distance = distance;
    }

    public double GetDistanceValue()
    {
        return _distance;
    }

    public void SetDistanceValue(double distance)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        
        return (_distance / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
}