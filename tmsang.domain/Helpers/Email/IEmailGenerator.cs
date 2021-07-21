using System.Net.Mail;

namespace tmsang.domain
{
    public interface IEmailGenerator
    {
        MailMessage Generate(EmailHolder objHolder, E_AccountEmailTemplate emailTemplate);
    }

}
