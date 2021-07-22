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
            var host = _config.GetSection("Email:Host").Value;  
            var port = int.Parse(_config.GetSection("Email:Port").Value);
            var username = _config.GetSection("Email:Username").Value;
            var password = _config.GetSection("Email:Password").Value;

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
