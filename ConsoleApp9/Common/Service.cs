using ConsoleApp9.Common.ServiceState;

namespace ConsoleApp9.Common;

public abstract class Service: IService, IServiceStateVisitor
{
    protected Service() => 
        SetState(new AwakeServiceState());

    public IServiceState State { get; private set; }

    public void SetState(IServiceState state)
    {
        State = state;
        state.Accept(this);
    }

    public void Enable() => 
        State.Enable(this);

    public void Disable() => 
        State.Disable(this);

    public void Destroy() => 
        State.Destroy(this);

    public void Visit(InitializeServiceState state) => 
        OnInitialize();

    public void Visit(EnableServiceState state) => 
        OnEnable();

    public void Visit(DisableServiceState state) => 
        OnDisable();

    public void Visit(DestroyServiceState state) => 
        OnDestroy();

    protected virtual void OnInitialize()
    {
    }

    protected virtual void OnEnable()
    {
    }

    protected virtual void OnDisable()
    {
    }

    protected virtual void OnDestroy()
    {
    }
}