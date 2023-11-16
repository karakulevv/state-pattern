using StatePattern.Interfaces;
using StatePattern.States;

namespace StatePattern.Models;

// Context class representing the package
public class Package
{
    private IDeliveryState currentState;

    public Package()
    {
        // Set an initial state
        currentState = new OrderedState();
    }

    public void ChangeState(IDeliveryState newState)
    {
        currentState = newState;
    }

    public void ProcessPackage()
    {
        currentState.Process();
    }
}