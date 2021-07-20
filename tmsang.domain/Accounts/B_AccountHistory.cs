using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace tmsang.domain
{
    public class B_AccountHistory: BaseEntity
    {
        public virtual int Id { get; protected set; }
        public virtual Guid AccountId { get; protected set; }
        public virtual int AccountTrackingTypeId { get; protected set; }
        public virtual DateTime HappenDate { get; protected set; }

        // Events

        private List<B_AccountHistory> _histories = new List<B_AccountHistory>();
        
    }

    public class B_AdminHistory : B_AccountHistory
    {
    }

    public class B_DriverHistory : B_AccountHistory
    {
    }

    public class B_GuestHistory : B_AccountHistory
    {
        
    }

}
