namespace tmsang.domain
{
    public class R_Driver: R_Account
    {
        public virtual string FirstName { get; protected set; }
        public virtual string LastName { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Phone { get; protected set; }
        public virtual string PersonalId { get; protected set; }
        public virtual string PersonalImage { get; protected set; }
        public virtual string Address { get; protected set; }
        
    }
}
