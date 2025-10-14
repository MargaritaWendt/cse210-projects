public class SwimmingActivity: Activity
{
    private double _laps;

    public SwimmingActivity(DateTime date, int lengthMinutes, int laps) : base("Swimming", date, lengthMinutes)
    {
        _laps = laps;
    }

    public double GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }

}