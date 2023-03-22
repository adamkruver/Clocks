namespace ConsoleApp9.Common.ServiceState;

public class DisableServiceState : IServiceState
{
    public void Enable(IService service) => 
        service.SetState(new EnableServiceState());

    public void Disable(IService service) { }

    public void Destroy(IService service) => 
        service.SetState(new DestroyServiceState());

    public void Accept(IServiceStateVisitor visitor) => 
        visitor.Visit(this);
}