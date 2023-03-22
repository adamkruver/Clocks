using ConsoleApp9.Common.ServiceState;

namespace ConsoleApp9.Common;

public interface IService
{
    public IServiceState State { get; }
    
    void SetState(IServiceState state);
    void Enable();
    void Disable();
    void Destroy();
}