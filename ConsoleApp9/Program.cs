using ConsoleApp9.Data.DataSource.LocalDataSource;
using ConsoleApp9.Data.DataSource.RemoteDataSource;
using ConsoleApp9.Data.Repository;
using ConsoleApp9.Domain.Time;
using ConsoleApp9.Domain.Time.UseCase;
using ConsoleApp9.Presentation.View;
using ConsoleApp9.Presentation.ViewModel;
using ConsoleApp9.Service;
using ConsoleApp9.Service.TimeService;

namespace ConsoleApp9;

internal class Program
{
    public static void Main(string[] args)
    {
        ITimeService timeService = new TimeService();
        ITimeLocalDataSource localDataSource = new TimeLocalDataSource(timeService);
        ITimeRemoteDataSource remoteDataSource = new TimeRemoteDataSource(timeService);
        ITimeRepository timeRepository = new TimeRepository(localDataSource, remoteDataSource);
        GetCurrentTimeUseCase getCurrentTimeUseCase = new GetCurrentTimeUseCase(timeRepository);
        ClockViewModel clockViewModel = new ClockViewModel(timeService, getCurrentTimeUseCase);
        ClockView clockView = new ClockView(clockViewModel);

        clockView.Enable();
        timeService.Enable();

        Console.ReadKey();
    }
}