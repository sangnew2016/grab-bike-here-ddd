using System;
using System.Linq.Expressions;

namespace tmsang.domain
{
    public class R_AdminCheckRegisterAccountSpec : SpecificationBase<R_Admin>
    {
        readonly string email;
        readonly string phone;

        public R_AdminCheckRegisterAccountSpec(string email, string phone)
        {
            this.email = email;
            this.phone = phone;
        }

        public override Expression<Func<R_Admin, bool>> SpecExpression
        {
            get {
                return p => p.AccountStatusId == (int)E_AccountStatus.Active 
                            && (p.Email == this.email || p.Phone == this.phone);
            }
        }
    }
}
