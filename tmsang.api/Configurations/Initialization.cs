using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using tmsang.domain;

namespace tmsang.api
{
    public class Initialization
    {
        public Initialization(IApplicationBuilder app)
        {
            var loggerFactory = app.ApplicationServices.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger<Program>();
            var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
            var config = app.ApplicationServices.GetRequiredService<IConfiguration>();
            var http = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();

            
            logger.LogInformation("Logged in Configure");

            Singleton.Instance.RootPath = env.ContentRootPath;

            Singleton.Instance.UrlApi = "https://localhost:44301/";
            //Singleton.Instance.UrlApi = $"{http.HttpContext.Request.Scheme}://{http.HttpContext.Request.Host}{http.HttpContext.Request.PathBase}";
        }
    }
}
