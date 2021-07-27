namespace tmsang.domain
{
    public class R_DriverCreatedEvent : DomainEvent
    {
        public R_Driver R_Driver { get; set; }
        public override void Flatten()
        {
            var name = "R_Driver";
            this.Args.Add(name + " Id", R_Driver.Id);
            this.Args.Add(name + " FullName", R_Driver.FirstName + " " + R_Driver.LastName);
            this.Args.Add(name + " Phone", R_Driver.Phone);
            this.Args.Add(name + " Email", R_Driver.Email);
        }
    }
}
