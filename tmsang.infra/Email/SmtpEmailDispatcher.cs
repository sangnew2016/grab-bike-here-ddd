using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using tmsang.domain;

namespace tmsang.infra
{
    public class SmtpEmailDispatcher : IEmailDispatcher
    {
        private readonly IConfiguration _config;
        public SmtpEmailDispatcher(IConfiguration config)
        {
            _config = config;
        }

        public void Dispatch(MailMessage mailMessage)
        {
            // cau hinh gmail nhe
            var temp = _config.GetSection("Email:Host").Value;

            var host = "smtp.gmail.com";  
            var port = 587;
            var username = "sangnew2021@gmail.com";
            var password = "yukvcjyavaplidej";

            var smtp = new SmtpClient
            {
                Host = host,
                Port = port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(username, password)
            };
            smtp.Send(mailMessage);
        }
    }
}
