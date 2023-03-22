using ConsoleApp9.Data.Formatter;
using ConsoleApp9.Domain.Time.Model;
using ConsoleApp9.Domain.Time.UseCase;
using ConsoleApp9.Service;

namespace ConsoleApp9.Presentation.ViewModel;

public class ClockViewModel
{
    private readonly ITimeService _timeService;
    private readonly GetCurrentTimeUseCase _getCurrentTimeUseCase;
    private readonly ITimeFormatter _timeFormatter = new TimeFormatter();

    public ClockViewModel(ITimeService timeService, GetCurrentTimeUseCase getCurrentTimeUseCase)
    {
        _timeService = timeService;
        _getCurrentTimeUseCase = getCurrentTimeUseCase;
    }

    public event Action<string>? TimeChanged;

    public void Enable() => 
        _timeService.Ticked += OnTimeTicked;

    public void Disable()
    {
    }

    private string ConvertTimeToString(Time time) =>
        _timeFormatter.ToString(time);

    private void OnTimeTicked(long time)
    {
        Time currentTime = _getCurrentTimeUseCase.Invoke();
        TimeChanged?.Invoke(ConvertTimeToString(currentTime));
    }
}