namespace EventCore.Domain;

public record StateStopped(Guid AggregateId, DateTime OccurredOn)  : IDomainEvent;
