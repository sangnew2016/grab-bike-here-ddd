using System;
using System.Collections.Generic;
using System.Linq;

namespace tmsang.domain
{
    public class R_Guest: R_Account
    {
        // =========================================
        // A. Design Entity + Properties
        // =========================================

        // this private variable is core of Entity
        private List<R_OrderRequest> _orderRequests = new List<R_OrderRequest>();
        public virtual IEnumerable<R_OrderRequest> OrderRequests
        {
            get
            {
                return this._orderRequests.Where(p => p.GuestId == this.Id);
            }
        }

        public virtual string FullName { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Phone { get; protected set; }

        // =========================================
        // B. Events of guest
        // =========================================
        // 0. Event Sourcing: this is technical
        // 1. Guest can create request From-To -> OrderRequest.Add
        // 2. Guest need to know Distance, Cost -> OrderRequest.Get
        // 3. Guest can cancel this trip (after 3 minutes without response | or manually cancel) -> OrderRequest.Update
        // 4. Guest need to know Driver take care this trip -> OrderResponse.Add
        // 5. Guest can vote|rate this trip -> OrderEvaluation.Add
        // 6. Guest can view History (trips) -> OrderHistory.Get

        // 0. Event Sourcing: this is technical
        public static R_Guest Create(string fullName, string phone, string email) {
            return Create(Guid.NewGuid(), fullName, phone, email);
        }
        public static R_Guest Create(Guid id, string fullName, string phone, string email) {
            var guest = new R_Guest {
                Id = id,
                FullName = fullName,
                Phone = phone,
                Email = email
            };
            // add event sourcing
            DomainEvents.Raise<R_GuestCreatedEvent>(new R_GuestCreatedEvent() { R_Guest = guest });

            return guest;
        }

        // 1. Guest can create request From-To -> OrderRequest.Add
        

        // 2. Guest need to know Distance, Cost -> OrderRequest.Get
        // -> this is _orderRequest list out

        // 3. Guest can cancel this trip (after 3 minutes without response | or manually cancel) -> OrderRequest.Update
        

        // 4. Guest need to know Driver take care this trip -> OrderResponse.Add
        // 5. Guest can vote|rate this trip -> OrderEvaluation.Add
        // 6. Guest can view History (trips) -> OrderHistory.Get


        // =========================================
        // C. Business & Logic
        // =========================================

    }
}
