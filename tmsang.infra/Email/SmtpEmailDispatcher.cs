using System.Net;
using System.Net.Mail;
using tmsang.domain;

namespace tmsang.infra
{
    public class SmtpEmailDispatcher : IEmailDispatcher
    {
        public void Dispatch(MailMessage mailMessage)
        {
            // cau hinh gmail nhe
            var host = "smtp.gmail.com";
            var port = 587;
            var username = "sangnew2021@gmail.com";
            var password = "yukvcjyavaplidej";

            using (var smtp = new SmtpClient())
            {
                smtp.Host = host;
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(username, password);
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = port;
                smtp.Send(mailMessage);
            }
        }
    }
}
