using StatePattern.Interfaces;

namespace StatePattern.States;

// Concrete State class
public class OrderedState : IDeliveryState
{
    public void Process()
    {
        Console.WriteLine("Package is ordered. Preparing the package for shipping.");
    }
}