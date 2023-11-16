# State Pattern Example: Package Delivery System

## Introduction

The State Pattern is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. It encapsulates states into separate classes and enables the object to switch between these classes as its state changes, without changing its interface.

In this example, we simulate a package delivery system where a package goes through different states during its journey, such as "Ordered," "In Transit," "Out for Delivery," and "Delivered."

## Real-world Analogy

Consider a package delivery system where a package goes through different states during its journey:

- **Context (Package):** Represents the package undergoing various stages of the delivery process. Its behavior changes as it transitions through different states.
  
- **State (DeliveryState):** The different states of the package during delivery, such as `OrderedState`, `InTransitState`, `OutForDeliveryState`, and `DeliveredState`. Each state class encapsulates behavior specific to that stage of the package's delivery process.

## Components

### State Interface (IDeliveryState)

- Defines the methods that concrete states (OrderedState, InTransitState, etc.) will implement.
  
### Concrete States (OrderedState, InTransitState, etc.)

- Classes representing different states of the package during delivery.
- Each state class encapsulates behavior specific to that state of the package.

### Context Class (Package)

- Represents the package.
- Maintains the current state and delegates state-specific behavior to the current state object.

## Usage

1. Instantiate the `Package` context.
2. Simulate the package moving through different states by changing its state using `ChangeState()` method.
3. Use the `ProcessPackage()` method to execute behavior associated with the current state.

## Implementation Notes

- Ensure proper state transitions and state-specific behaviors are defined in concrete state classes.
- Keep the context and state classes decoupled to allow easy addition or modification of states.