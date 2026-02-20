# EventCore

EventCore is a .NET 8 Web API project that serves as the structural scaffold for an event-driven processor.

## Project Goal

The goal of this project is to provide a clean, domain-driven folder structure for building an event-driven state processing system.
## Folder Structure

```
EventCore/
├── Domain/             # Core domain abstractions and events
│   ├── IDomainEvent.cs
│   ├── StateStarted.cs
│   ├── StateStopped.cs
│   └── AggregateState.cs
├── Application/        # Application-layer services
│   └── StateProcessor.cs
├── Infrastructure/     # Infrastructure concerns (e.g., in-memory storage)
│   └── InMemoryEventStore.cs
├── Controllers/        # Web API controllers
│   └── StateController.cs
└── Tests/              # Test project placeholder
```

## Getting Started

```bash
cd EventCore
dotnet build
dotnet run
```
