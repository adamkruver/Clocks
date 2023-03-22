namespace ConsoleApp9.Common.ServiceState;

public class InitializeServiceState: IServiceState
{
    public void Enable(IService service) { }

    public void Disable(IService service) { }

    public void Destroy(IService service) { }
    
    public void Accept(IServiceStateVisitor visitor) => 
        visitor.Visit(this);
}