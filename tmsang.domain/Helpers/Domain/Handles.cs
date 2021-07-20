namespace tmsang.domain
{
    public interface Handles<T> where T: DomainEvent
    {
        void Handle(T args);
    }
}
