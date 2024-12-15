public abstract class Activity
{
    // Encapsulated fields for shared attributes
    private DateTime _date;
    private double _minutes;

    public DateTime Date { get { return _date; } }
    public double Minutes { get { return _minutes; } }

    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to generate the summary
    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Minutes} min) - " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
