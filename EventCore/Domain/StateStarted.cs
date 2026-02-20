namespace EventCore.Domain;

public record StateStarted(Guid AggregateId, DateTime OccurredOn) : IDomainEvent;
