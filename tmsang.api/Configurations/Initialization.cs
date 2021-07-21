using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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

            logger.LogInformation("Logged in Configure");

            var storage = app.ApplicationServices.GetRequiredService<IStorage>();
            storage.WebRootPath = env.WebRootPath;
        }
    }
}
