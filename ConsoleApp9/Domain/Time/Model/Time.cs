namespace ConsoleApp9.Domain.Time.Model;

public class Time
{
    private readonly DateTime _dateTime;

    public Time(long time) => 
        _dateTime = new DateTime(time);

    public int Hour => _dateTime.Hour;
    public int Minute => _dateTime.Minute;
    public int Second => _dateTime.Second;
}