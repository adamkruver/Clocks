using ConsoleApp9.Service;

namespace ConsoleApp9.Data.DataSource.LocalDataSource;

public class TimeLocalDataSource : ITimeLocalDataSource
{
    private readonly ITimeService _timeService;

    public TimeLocalDataSource(ITimeService timeService) =>
        _timeService = timeService;

    public long Ticks => new TimeSpan(0, 0, (int)_timeService.Ticks).Ticks;
}