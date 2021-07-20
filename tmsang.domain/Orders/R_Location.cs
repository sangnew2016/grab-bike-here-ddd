namespace tmsang.domain
{
    public class R_Location: BaseEntity
    {
        public virtual long Id { get; protected set; }
        public virtual string Address { get; protected set; }
        public virtual string Latitude { get; protected set; }
        public virtual string Longtitude { get; protected set; }

    }
}
