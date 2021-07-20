using System.Net.Mail;

namespace tmsang.domain
{
    public interface IEmailDispatcher
    {
        void Dispatch(MailMessage mailMessage);
    }
}
