namespace tmsang.domain
{
    public class R_GuestRequestedEvent : DomainEvent
    {
        public R_OrderRequest R_OrderRequest { get; set; }
        public override void Flatten()
        {
            var name = "R_OrderRequest";
            this.Args.Add(name + " Id", this.R_OrderRequest.Id);
            this.Args.Add(name + " LocationId", this.R_OrderRequest.OrderRequestLocationId);
            this.Args.Add(name + " GuestId", this.R_OrderRequest.GuestId);
            this.Args.Add(name + " RequestDate", this.R_OrderRequest.RequestDate);
            
        }
    }
}
