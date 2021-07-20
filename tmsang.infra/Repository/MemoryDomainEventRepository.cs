using System.Collections.Generic;
using System.Linq;
using tmsang.domain;

namespace tmsang.infra
{
    public class MemoryDomainEventRepository : IDomainEventRepository
    {
        // su dung mot List<DomainEventRecord> luu tru toan cuc Memory
        private List<DomainEventRecord> domainEvents = new List<DomainEventRecord>();

        public void Add<T>(T domainEvent) where T : DomainEvent
        {
            domainEvents.Add(new DomainEventRecord { 
                Type = domainEvent.Type,
                Args = domainEvent.Args.Select(p => new KeyValuePair<string, string>(p.Key, p.Value.ToString())).ToList(),
                CorrelationID = domainEvent.CorrelationID,
                Created = domainEvent.Created
            });
        }

        public IEnumerable<DomainEventRecord> FindAll()
        {
            return this.domainEvents;
        }
    }
}
