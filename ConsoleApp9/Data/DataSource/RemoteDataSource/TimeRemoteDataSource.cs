using ConsoleApp9.Service;

namespace ConsoleApp9.Data.DataSource.RemoteDataSource;

public class TimeRemoteDataSource : ITimeRemoteDataSource
{
    public TimeRemoteDataSource(ITimeService timeService)
    {
    }

    public long Ticks { get; } = DateTime.Now.Ticks;
}