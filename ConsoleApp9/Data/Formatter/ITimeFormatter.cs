namespace ConsoleApp9.Data.Formatter;

public interface ITimeFormatter
{
    string ToString(Domain.Time.Model.Time time);
}