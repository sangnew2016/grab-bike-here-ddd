using System;

namespace tmsang.domain
{
    public class B_OrderRequestLocation : BaseEntity
    {
        public virtual long Id { get; protected set; }
        public virtual long FromLocationId { get; protected set; }
        public virtual long ToLocationId { get; protected set; }

        public virtual Guid OrderRequestId { get; protected set; }
    }
}
