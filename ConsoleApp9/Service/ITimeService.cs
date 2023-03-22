using ConsoleApp9.Common;

namespace ConsoleApp9.Service;

public interface ITimeService : IService
{
    event Action<long>? Ticked;

    long Ticks { get; }

    void Reset();
}