using System;

namespace tmsang.domain
{
    public class B_OrderPaymentCreditCard: R_OrderPayment
    {
        public virtual string FullName { get; protected set; }
        public virtual string Number { get; protected set; }
        public virtual string Code { get; protected set; }
        public virtual DateTime ExpiredDate { get; protected set; }
    }
}
