using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using tmsang.domain;

namespace tmsang.infra
{
    public class EmailGenerator : IEmailGenerator
    {
        private IStorage _storage;
        public EmailGenerator(IStorage storage)
        {
            _storage = storage;
        }

        public MailMessage Generate(EmailHolder holder, E_AccountEmailTemplate emailTemplate)
        {
            // tu emailTemplate -> lay ra "template content"
            var filePath = _storage.RootFolder + @"\Files\Templates\" + emailTemplate.GetName() + ".txt";
            string content = File.ReadAllText(filePath);

            // tu parameterEmailTemplate -> do tham so vao "template content" | theo dang {0}, {1}, {2}, ...
            var parameterExtra = holder.Parameters.Select((p, i) => 
                Tuple.Create("{" + i + "}", p)
            );
            var body = content.ReplaceExtra(parameterExtra);
            
            // return email -> email(from, to, subject, body)
            var mail = new MailMessage(holder.From, holder.To, holder.Subject, body);

            return mail;
        }

    }

    
}
