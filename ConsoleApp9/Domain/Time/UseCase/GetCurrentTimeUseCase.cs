namespace ConsoleApp9.Domain.Time.UseCase;

public class GetCurrentTimeUseCase
{
    private readonly ITimeRepository _timeRepository;

    public GetCurrentTimeUseCase(ITimeRepository timeRepository) => 
        _timeRepository = timeRepository;

    public Model.Time Invoke() =>
        _timeRepository.GetCurrentTime();
}