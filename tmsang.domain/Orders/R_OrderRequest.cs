using System;

namespace tmsang.domain
{
    public class R_OrderRequest: R_Order
    {
        public virtual Guid GuestId { get; protected set; }
        public virtual long OrderRequestLocationId { get; protected set; }
        public virtual DateTime RequestDate { get; protected set; }
        public virtual int OrderTrackingTypeId { get; protected set; }
    }
}
