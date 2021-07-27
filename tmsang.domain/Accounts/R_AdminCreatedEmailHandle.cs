using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace tmsang.domain
{
    public class R_AdminCreatedEmailHandle : Handles<R_AdminCreatedEvent>
    {
        readonly IAuth auth;
        readonly IEmailDispatcher emailDispatcher;
        readonly IEmailGenerator emailGenerator;

        public R_AdminCreatedEmailHandle(IAuth auth, IEmailGenerator emailGenerator, IEmailDispatcher emailDispatcher)
        {
            this.auth = auth;
            this.emailGenerator = emailGenerator;
            this.emailDispatcher = emailDispatcher;
        }

        public void Handle(R_AdminCreatedEvent args)
        {
            var mixInfo = args.R_Admin.Id.ToString() + ";" + args.R_Admin.Email + ";" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var activeAccountTokenLink = Singleton.Instance.UrlApi + "?token=" + auth.GenerateToken(mixInfo, E_AccountType.Admin.ToString());

            var holder = new EmailHolder {
                From = "sangnew2021@gmail.com",
                To = args.R_Admin.Email,
                Subject = "Active Account for Registration - GRAB BIKE",
                Parameters = new List<string> { args.R_Admin.FullName, activeAccountTokenLink }
            };

            var message = this.emailGenerator.Generate(holder, E_AccountEmailTemplate.ActivateAccount);
            this.emailDispatcher.Dispatch(message);
        }
    }
}
