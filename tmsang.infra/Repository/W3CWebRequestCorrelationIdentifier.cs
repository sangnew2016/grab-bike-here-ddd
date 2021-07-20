using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tmsang.domain;

namespace tmsang.infra
{
    public class W3CWebRequestCorrelationIdentifier : IRequestCorrelationIdentifier
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public string CorrelationID { get; private set; }

        public W3CWebRequestCorrelationIdentifier(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            /* #Customise your correlation ID here
             * More request identification variables you add easier 
             * it's going to be to find the relevant W3C request when you hash it
             * 
             * Below is just an example of variables and hash algorithm that you can use:
             */
            string rawCorrelationID = string.Join("_",
                    //HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"],
                    //HttpContext.Current.Request.Params["LOGON_USER"],
                    //HttpContext.Current.Request.UserAgent != null ?
                    //    HttpContext.Current.Request.UserAgent.ToString().Replace(" ", "+") : "-",
                    //HttpContext.Current.Request.Path,
                    //HttpContext.Current.Request.QueryString.ToString() ?? "-",
                    //new DateTime(HttpContext.Current.Timestamp.Ticks).ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")
                    ""
                );

            StringBuilder hashBuilder = new StringBuilder();
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(rawCorrelationID));
                for (int i = 0; i < hash.Length; i++)
                    hashBuilder.Append(hash[i].ToString("X2"));
            }

            this.CorrelationID = hashBuilder.ToString();
        }
    }
}
