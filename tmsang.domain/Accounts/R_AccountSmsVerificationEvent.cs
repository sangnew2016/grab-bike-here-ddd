namespace tmsang.domain
{
    public class R_AccountSmsVerificationEvent : DomainEvent
    {
        public string Phone { get; set; }
        public string Code { get; set; }

        public override void Flatten()
        {
            var name = "SMS";
            this.Args.Add(name + " Phone", this.Phone);
            this.Args.Add(name + " Code", this.Code);
        }
    }
}
