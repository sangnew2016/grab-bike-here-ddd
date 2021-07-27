using System;
using System.Linq.Expressions;

namespace tmsang.domain
{
    public class R_DriverGetByIdSpec : SpecificationBase<R_Driver>
    {
        readonly string id;

        public R_DriverGetByIdSpec(string id)
        {
            this.id = id;
        }

        public override Expression<Func<R_Driver, bool>> SpecExpression
        {
            get {
                return p => p.AccountStatusId == (int)E_AccountStatus.Active 
                            && p.Id.ToString() == this.id;
            }
        }
    }
}
