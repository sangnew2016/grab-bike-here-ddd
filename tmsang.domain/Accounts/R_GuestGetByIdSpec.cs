using System;
using System.Linq.Expressions;

namespace tmsang.domain
{
    public class R_GuestGetByIdSpec : SpecificationBase<R_Guest>
    {
        readonly string id;

        public R_GuestGetByIdSpec(string id)
        {
            this.id = id;
        }

        public override Expression<Func<R_Guest, bool>> SpecExpression
        {
            get {
                return p => p.AccountStatusId == (int)E_AccountStatus.Active 
                            && p.Id.ToString() == this.id;
            }
        }
    }
}
