using System;

namespace tmsang.domain
{
    public class R_OrderResponse: R_Order
    {
        public virtual Guid DriverId { get; protected set; }
        public virtual DateTime Start { get; protected set; }
        public virtual DateTime End { get; protected set; }
        // public virtual double A_Fee { get; protected set; }         // tien to A_ mang y nghia la cot tinh toan -> nguyen tac: khong dua cot tinh toan de luu tru
        // public virtual double A_Tax { get; protected set; }         // tien to A_ mang y nghia la cot tinh toan -> nguyen tac: khong dua cot tinh toan vao luu tru
    }
}
