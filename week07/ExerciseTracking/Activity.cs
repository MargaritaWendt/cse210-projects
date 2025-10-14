using System.IO.Pipes;

public class Activity
{
    private DateTime _date;
    private double _lengthMinutes;

    private string _activityName;

    public Activity(string name, DateTime date, double lengthMinutes)
    {
        _activityName = name;
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public double GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public void SetLengthMinutes(double lengthMinutes)
    {
        _lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {_activityName} ({_lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace()} min per km";
    }
}