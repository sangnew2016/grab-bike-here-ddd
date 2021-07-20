using System;
using System.Net.Mail;
using MailKit.Net.Smtp;
using MimeKit;
using tmsang.domain;

namespace tmsang.infra
{
    public class SmtpEmailDispatcher : IEmailDispatcher
    {
        public void Dispatch(MailMessage mailMessage)
        {
            // do something
            // ...

            //MimeMessage message = new MimeMessage();

            //MailboxAddress from = new MailboxAddress("Admin", "admin@example.com");
            //message.From.Add(from);

            //MailboxAddress to = new MailboxAddress("User", "user@example.com");
            //message.To.Add(to);

            //message.Subject = "This is email subject";
            //BodyBuilder bodyBuilder = new BodyBuilder();
            //bodyBuilder.HtmlBody = "<h1>Hello World!</h1>";
            //bodyBuilder.TextBody = "Hello World!";

            //SmtpClient client = new SmtpClient();
            //client.Connect("smtp_address_here", port_here, true);
            //client.Authenticate("user_name_here", "pwd_here");
            //client.Send(message);
            //client.Disconnect(true);
            //client.Dispose();
        }
    }
}
