namespace tmsang.domain
{
    public class R_OrderPayment: R_Order
    {
        public virtual E_PaymentType Type { get; protected set; }
        public virtual bool Paid { get; protected set; }

    }
}
