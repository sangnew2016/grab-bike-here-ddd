using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tmsang.domain;

namespace tmsang.infra
{
    public class Storage: IStorage
    {
        public string WebRootPath { get; set; }

        public Storage()
        {

        }

        private Dictionary<string, SmsVerification> SmsStorage = new Dictionary<string, SmsVerification>();

        public void SmsSet(string phone, string value) {
            // reset key if expired
            AutoResetKey();

            // reset key = email het
            SmsStorage.Remove(phone);

            SmsStorage.Add(phone, new SmsVerification {
                Value = value,
                Expired = DateTime.Now
            });

            // set event to send SMS here!!!! Event + Handle
            DomainEvents.Raise<R_AccountSmsVerificationEvent>(new R_AccountSmsVerificationEvent { Phone = phone, Code = value });

        }

        public string SmsGetCode(string phone) {
            var code = SmsStorage.Where(p => p.Key == phone).Select(p => p.Value.Value).FirstOrDefault();
            return code;
        }

        private void AutoResetKey() {
            var items = SmsStorage.Where(p => p.Value.Expired.AddHours(1) >= DateTime.Now).Select(p => p.Key).ToList();
            items.ForEach(key => {
                SmsStorage.Remove(key);
            });
        }

    }

    public class SmsVerification { 
        public DateTime Expired { get; set; }
        public string Value { get; set; }
    }
}
