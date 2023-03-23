using ConsoleApp9.Common.ServiceState;

namespace ConsoleApp9.Service.TimeService;

public class TimeService: Common.Service, ITimeService
{
    private readonly int _tickDelay;
    
    public event Action<long>? Ticked;

    public TimeService():this(1000)
    {
    }

    public TimeService(int tickDelay) => 
        _tickDelay = tickDelay;

    public long Ticks { get; private set; }
    
    public void Reset() => 
        Ticks = 0;

    protected override void OnInitialize() =>
        Reset();

    protected override void OnEnable() => 
        Task.Run(Process);

    private async Task Process()
    {
        while (State is EnableServiceState)
        {
            Tick();
            await Task.Delay(_tickDelay);
        }
    }
    
    private void Tick()
    {
        Ticks++;
        Ticked?.Invoke(Ticks);
    }
}