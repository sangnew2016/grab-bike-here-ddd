namespace tmsang.domain
{
    public class R_AdminCreatedEvent : DomainEvent
    {
        public R_Admin R_Admin { get; set; }
        public override void Flatten()
        {
            var name = "R_Admin";
            this.Args.Add(name + " Id", R_Admin.Id);
            this.Args.Add(name + " FullName", R_Admin.FullName);
            this.Args.Add(name + " Phone", R_Admin.Phone);
            this.Args.Add(name + " Email", R_Admin.Email);
        }
    }
}
