using System;
using System.Linq.Expressions;

namespace tmsang.domain
{
    public class R_AdminGetByIdSpec : SpecificationBase<R_Admin>
    {
        readonly string id;

        public R_AdminGetByIdSpec(string id)
        {
            this.id = id;
        }

        public override Expression<Func<R_Admin, bool>> SpecExpression
        {
            get {
                return p => p.AccountStatusId == (int)E_AccountStatus.Active 
                            && p.Id.ToString() == this.id;
            }
        }
    }
}
