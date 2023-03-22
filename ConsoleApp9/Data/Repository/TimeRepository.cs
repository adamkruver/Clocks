using ConsoleApp9.Data.DataSource.LocalDataSource;
using ConsoleApp9.Data.DataSource.RemoteDataSource;
using ConsoleApp9.Domain.Time;
using ConsoleApp9.Domain.Time.Model;

namespace ConsoleApp9.Data.Repository;

public class TimeRepository : ITimeRepository
{
    private readonly ITimeLocalDataSource _localDataSource;
    private readonly ITimeRemoteDataSource _remoteDataSource;

    public TimeRepository(ITimeLocalDataSource localDataSource, ITimeRemoteDataSource remoteDataSource)
    {
        _localDataSource = localDataSource;
        _remoteDataSource = remoteDataSource;
    }

    public Time GetCurrentTime() =>
        new Time(_localDataSource.Ticks + _remoteDataSource.Ticks);
}