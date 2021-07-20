namespace tmsang.domain
{
    public class R_AccountSmsVerificationHandle : Handles<R_AccountSmsVerificationEvent>
    {
        readonly ISmsProvider _smsProvider;

        public R_AccountSmsVerificationHandle(ISmsProvider smsProvider)
        {
            this._smsProvider = smsProvider;
        }
        public void Handle(R_AccountSmsVerificationEvent args)
        {
            // send SMS
            this._smsProvider.Send(args.Phone, args.Code);
        }
    }
}
