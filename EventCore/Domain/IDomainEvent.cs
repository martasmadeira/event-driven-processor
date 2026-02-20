namespace EventCore.Domain;

public interface IDomainEvent
{
    
    public Guid AggregateId { get; } // The ID of the aggregate that produced this event
    public DateTime OccurredOn { get; }
}
