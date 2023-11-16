using StatePattern.Interfaces;

namespace StatePattern.States;

// Concrete State class
public class OutForDeliveryState : IDeliveryState
{
    public void Process()
    {
        Console.WriteLine("Package is out for delivery. Notifying the recipient.");
    }
}