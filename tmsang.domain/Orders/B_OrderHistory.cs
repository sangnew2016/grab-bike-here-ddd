using System;

namespace tmsang.domain
{
    public class B_OrderHistory: BaseEntity
    {
        public virtual long Id { get; protected set; }
        public virtual Guid OrderId { get; protected set; }
        public virtual int OrderTrackingTypeId { get; protected set; }
        public virtual DateTime HappenDate { get; protected set; }
    }

    public class B_OrderRequestHistory: B_OrderHistory 
    {
    }

    public class B_OrderResponseHistory : B_OrderHistory
    {
    }

    public class B_OrderPaymentHistory : B_OrderHistory
    {
    }

    public class B_OrderEvaluationHistory : B_OrderHistory
    {
    }
}
