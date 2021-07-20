using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tmsang.application;
using tmsang.domain;
using tmsang.infra;

namespace tmsang.api
{
    public static class AddGrabCustomServicesExtension
    {
        public static IServiceCollection AddGrabCustomServices(
             this IServiceCollection services, 
             IConfiguration config
        )
        {
            // DI: Infra Layer (infra truoc nhe!!!)
            services.AddScoped<IEmailDispatcher, SmtpEmailDispatcher>();
            services.AddScoped<IEmailGenerator, EmailGenerator>();
            services.AddScoped<IRequestCorrelationIdentifier, W3CWebRequestCorrelationIdentifier>();
            services.AddScoped<IDomainEventRepository, MemoryDomainEventRepository>();
            services.AddSingleton<ISmsProvider, SmsProvider>();

            services.AddSingleton<IStorage, Storage>();
            services.AddSingleton<IAuth, Auth>();

            services.AddScoped<IRepository<R_Admin>, MemoryRepository<R_Admin>>();
            services.AddScoped<IRepository<R_Driver>, MemoryRepository<R_Driver>>();
            services.AddScoped<IRepository<R_Guest>, MemoryRepository<R_Guest>>();
            services.AddScoped<IUnitOfWork, MemoryUnitOfWork>();

            // DI: Application
            services.AddScoped<AccountDomainService, AccountDomainService>();
            services.AddScoped<IAccountService, AccountService>();

            //// DI: Domain
            services.AddScoped<Handles<R_GuestCreatedEvent>, DomainEventHandle<R_GuestCreatedEvent>>();
            services.AddScoped<Handles<R_GuestRequestedEvent>, DomainEventHandle<R_GuestRequestedEvent>>();
            services.AddScoped<Handles<R_AdminCreatedEvent>, DomainEventHandle<R_AdminCreatedEvent>>();
            services.AddScoped<Handles<R_AccountSmsVerificationEvent>, DomainEventHandle<R_AccountSmsVerificationEvent>>();

            services.AddScoped<Handles<R_AccountSmsVerificationEvent>, R_AccountSmsVerificationHandle>();
            services.AddScoped<Handles<R_AdminCreatedEvent>, R_AdminCreatedEmailHandle>();

            var serviceProvider = services.BuildServiceProvider();
            DomainEvents.Init(serviceProvider);

            return services;
        }
    }
}
