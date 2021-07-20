namespace tmsang.domain
{
    public class R_GuestCreatedEvent : DomainEvent
    {
        public R_Guest R_Guest { get; set; } 
        public override void Flatten()
        {
            var name = "R_Guest";
            this.Args.Add(name + " Id", R_Guest.Id);
            this.Args.Add(name + " FullName", R_Guest.FullName);
            this.Args.Add(name + " Phone", R_Guest.Phone);
            this.Args.Add(name + " Email", R_Guest.Email);
        }
    }
}
