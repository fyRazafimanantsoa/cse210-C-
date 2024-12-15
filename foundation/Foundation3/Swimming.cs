public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Calculate the distance in miles (based on lap length of 50 meters)
    public override double GetDistance()
    {
        return (_laps * 50 / 1000) * 0.62; // converting meters to miles
    }

    // Calculate the speed in miles per hour
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    // Calculate the pace in minutes per mile
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}
