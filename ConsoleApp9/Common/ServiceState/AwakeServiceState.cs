namespace ConsoleApp9.Common.ServiceState;

public class AwakeServiceState: IServiceState
{
    public void Enable(IService service)
    {
        service.SetState(new InitializeServiceState());
        service.SetState(new EnableServiceState());
    }

    public void Disable(IService service) { }

    public void Destroy(IService service) { }
    
    public void Accept(IServiceStateVisitor visitor)
    {
    }
}