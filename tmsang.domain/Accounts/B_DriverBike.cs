using System;

namespace tmsang.domain
{
    public class B_DriverBike : R_Driver
    {
        public virtual string PlateNo { get; protected set; }           // EX: 59C1 22983
        public virtual string BikeOwner { get; protected set; }         // EX: SANG THACH MINH
        public virtual string EngineNo { get; protected set; }          // EX: 21655
        public virtual string ChassisNo { get; protected set; }         // EX: 7232-1
        public virtual string BikeType { get; protected set; }          // EX: Vison
        public virtual string Brand { get; protected set; }             // EX: Honda
        public virtual DateTime RegistrationDate { get; protected set; }

    }
}
