namespace ConsoleApp9.Common.ServiceState;

public class EnableServiceState:IServiceState
{
    public void Enable(IService service) { }

    public void Disable(IService service) => 
        service.SetState(new DisableServiceState());

    public void Destroy(IService service) => 
        service.SetState(new DestroyServiceState());

    public void Accept(IServiceStateVisitor visitor) => 
        visitor.Visit(this);
}