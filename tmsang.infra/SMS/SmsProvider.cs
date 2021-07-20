using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using tmsang.domain;

namespace tmsang.infra
{
    public class SmsProvider : ISmsProvider
    {
        private string accountSid;
        private string authToken;
        private string myPhoneForTwilio;

        public SmsProvider()
        {
            this.accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            this.authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
            this.myPhoneForTwilio = Environment.GetEnvironmentVariable("TWILIO_MY_PHONE");
        }

        public void Send(string phone, string code)
        {
            TwilioClient.Init(this.accountSid, this.authToken);

            var message = MessageResource.Create(
                body: code,
                from: new Twilio.Types.PhoneNumber(this.myPhoneForTwilio),
                to: new Twilio.Types.PhoneNumber(phone)
            );

            Console.WriteLine(message.Sid);
        }
    }
}
