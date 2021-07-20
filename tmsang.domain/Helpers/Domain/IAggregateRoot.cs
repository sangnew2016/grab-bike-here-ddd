using System;

namespace tmsang.domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
