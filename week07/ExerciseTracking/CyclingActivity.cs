public class CyclingActivity: Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int lengthMinutes, double speed) : base("Cycling", date, lengthMinutes)
    {
        _speed = speed;
    }

    public double GetSpeedValue()
    {
        return _speed;
    }

    public void SetSpeedValue(double speed)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLengthMinutes()) / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }


}