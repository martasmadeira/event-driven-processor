namespace EventCore.Domain;

public class AggregateState
{
    public Guid AggregateId { get; private set; }

    // Prevent external mutation – state changes only via events.
    public ProcessorStatus CurrentStatus { get; private set; }

    public DateTime LastUpdated { get; private set; }

    public AggregateState(Guid id)
    {
        AggregateId = id;
        CurrentStatus = ProcessorStatus.Idle; // initial state
        LastUpdated = DateTime.UtcNow;
    }

    public void Apply(IDomainEvent domainEvent)
    {
        switch (domainEvent)
        {
            case StateStarted:
                CurrentStatus = ProcessorStatus.Running;
                break;

            case StateStopped:
                CurrentStatus = ProcessorStatus.Stopped;
                break;
        }

        LastUpdated = domainEvent.OccurredOn;
    }
}