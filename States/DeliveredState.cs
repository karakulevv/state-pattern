using StatePattern.Interfaces;

namespace StatePattern.States;

// Concrete State class
public class DeliveredState : IDeliveryState
{
    public void Process()
    {
        Console.WriteLine("Package is delivered. Updating delivery status.");
    }
}