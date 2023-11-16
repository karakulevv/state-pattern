using StatePattern.Interfaces;

namespace StatePattern.States;

// Concrete State class
public class InTransitState : IDeliveryState
{
    public void Process()
    {
        Console.WriteLine("Package is in transit. Tracking the package's location.");
    }
}