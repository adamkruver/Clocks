namespace ConsoleApp9.Service.TimeService;

public class TimeService: Common.Service, ITimeService
{
    private readonly int _tickDelay = 1000;
    
    private bool _isEnabled;

    public event Action<long>? Ticked;

    public long Ticks { get; private set; }
    
    public void Reset() => 
        Ticks = 0;

    protected override void OnInitialize() => 
        Ticks = 0;

    protected override void OnEnable()
    {
        _isEnabled = true;
        
        Task.Run(Process);
    }
    
    protected override void OnDisable() => 
        _isEnabled = false;

    private async Task Process()
    {
        while (_isEnabled)
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