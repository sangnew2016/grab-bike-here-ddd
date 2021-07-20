using System.Net.Mail;
using tmsang.domain;

namespace tmsang.infra
{
    public class EmailGenerator : IEmailGenerator
    {
        public MailMessage Generate(object objHolder, E_AccountEmailTemplate emailTemplate)
        {
            // generate your email here...!!!!

            return new MailMessage();
        }
    }
}
