using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace tmsang.domain
{
    public class R_AdminCreatedEmailHandle : Handles<R_AdminCreatedEvent>
    {
        readonly IEmailDispatcher emailDispatcher;

        public R_AdminCreatedEmailHandle(IEmailDispatcher emailDispatcher)
        {
            this.emailDispatcher = emailDispatcher;
        }

        public void Handle(R_AdminCreatedEvent args)
        {
            this.emailDispatcher.Dispatch(new MailMessage());
        }
    }
}
