namespace tmsang.domain
{
    public class B_OrderPaymentMomo: R_OrderPayment
    {
        public virtual string FullName { get; protected set; }
        public virtual string PhoneNumber { get; protected set; }
    }
}
