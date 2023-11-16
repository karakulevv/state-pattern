using StatePattern.Models;
using StatePattern.States;

namespace StatePattern;

class Program
{
    public static void Main(string[] args)
    {
        // Create a package (context)
        Package package = new Package();

        // Simulate the package moving through different states
        Console.WriteLine("Current Package State:");
        package.ProcessPackage();

        package.ChangeState(new InTransitState());
        Console.WriteLine("\nPackage State Changed to In Transit:");
        package.ProcessPackage();

        package.ChangeState(new OutForDeliveryState());
        Console.WriteLine("\nPackage State Changed to Out For Delivery:");
        package.ProcessPackage();

        package.ChangeState(new DeliveredState());
        Console.WriteLine("\nPackage State Changed to Delivered:");
        package.ProcessPackage();
    }
}