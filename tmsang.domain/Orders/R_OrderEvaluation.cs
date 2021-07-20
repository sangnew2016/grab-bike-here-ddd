namespace tmsang.domain
{
    public class R_OrderEvaluation: R_Order
    {
        public virtual string Note { get; protected set; }
        public virtual int Rating { get; protected set; }
    }
}
