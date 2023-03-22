namespace ConsoleApp9.Common.ServiceState;

public interface IServiceState
{
    void Enable(IService service);
    void Disable(IService service);
    void Destroy(IService service);
    void Accept(IServiceStateVisitor visitor);
}