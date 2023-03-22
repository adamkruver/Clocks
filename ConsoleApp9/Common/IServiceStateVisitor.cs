using ConsoleApp9.Common.ServiceState;

namespace ConsoleApp9.Common;

public interface IServiceStateVisitor
{
    void Visit(InitializeServiceState state);
    void Visit(EnableServiceState state);
    void Visit(DisableServiceState state);
    void Visit(DestroyServiceState state);
}