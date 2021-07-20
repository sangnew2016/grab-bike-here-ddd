namespace tmsang.domain
{
    public class DomainEventHandle<T>: Handles<T> where T: DomainEvent
    {
        IDomainEventRepository domainEventRepository;
        IRequestCorrelationIdentifier requestCorrelationIdentifier;

        public DomainEventHandle(
            IDomainEventRepository domainEventRepository,
            IRequestCorrelationIdentifier requestCorrelationIdentifier
            )
        {
            this.domainEventRepository = domainEventRepository;
            this.requestCorrelationIdentifier = requestCorrelationIdentifier;
        }

        public void Handle(T @event) {
            @event.Flatten();
            @event.CorrelationID = this.requestCorrelationIdentifier.CorrelationID;
            this.domainEventRepository.Add(@event);
        }
    }
}
