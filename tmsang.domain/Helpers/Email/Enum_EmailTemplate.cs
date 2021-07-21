using System.Collections.Generic;

namespace tmsang.domain
{
    public enum E_AccountEmailTemplate
    {
        PurchaseMade,
        ActivateAccount,
        ResetPassword
    }

    public static class EnumExtension
    {
        public static string GetName(this E_AccountEmailTemplate value) {
            var result = (E_AccountEmailTemplate)value;
            return result.ToString();
        }
    }

    public class EmailHolder
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> Parameters { get; set; }
       
    }

    
}
