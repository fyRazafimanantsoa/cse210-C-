public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Calculate the speed in miles per hour
    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60;
    }

    // Calculate the pace in minutes per mile
    public override double GetPace()
    {
        return Minutes / _distance;
    }

    // Return the distance (already provided in the constructor)
    public override double GetDistance()
    {
        return _distance;
    }
}
