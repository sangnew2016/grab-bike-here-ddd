using System.Net.Mail;

namespace tmsang.domain
{
    public interface IEmailGenerator
    {
        MailMessage Generate(object objHolder, E_AccountEmailTemplate emailTemplate);
    }
}
