public class Cycling : Activity
{
    private double _speed; // in miles per hour

    public Cycling(DateTime date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Calculate the distance in miles
    public override double GetDistance()
    {
        return (_speed / 60) * Minutes;
    }

    // Return the speed
    public override double GetSpeed()
    {
        return _speed;
    }

    // Calculate the pace in minutes per mile
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
