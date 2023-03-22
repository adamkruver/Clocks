namespace ConsoleApp9.Data.Formatter;

public class TimeFormatter : ITimeFormatter
{
    public string ToString(Domain.Time.Model.Time time)
    {
        string hour = time.Hour.ToString().PadLeft(2, '0');
        string minute = time.Minute.ToString().PadLeft(2, '0');
        string second = time.Second.ToString().PadLeft(2, '0');
        return $"{hour}:{minute}:{second}";
    }
}