using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using tmsang.application;
using tmsang.domain;
using tmsang.infra;

namespace tmsang.api
{
    public static class CustomServicesExtension
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
            services.AddScoped<ISmsProvider, SmsProvider>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IStorage, Storage>();
            services.AddScoped<IAuth, Auth>();
            services.AddScoped<IUtil, Util>();

            services.AddScoped<IRepository<R_Admin>, MyRepository<R_Admin>>();
            services.AddScoped<IRepository<R_Driver>, MyRepository<R_Driver>>();
            services.AddScoped<IRepository<R_Guest>, MyRepository<R_Guest>>();

            // DI: Application
            services.AddScoped<AccountDomainService>();
            services.AddScoped<IAccountService, AccountService>();

            // DI: Domain
            services.AddScoped<Handles<R_GuestCreatedEvent>, DomainEventHandle<R_GuestCreatedEvent>>();
            services.AddScoped<Handles<R_GuestRequestedEvent>, DomainEventHandle<R_GuestRequestedEvent>>();
            services.AddScoped<Handles<R_AdminCreatedEvent>, DomainEventHandle<R_AdminCreatedEvent>>();
            services.AddScoped<Handles<R_AccountSmsVerificationEvent>, DomainEventHandle<R_AccountSmsVerificationEvent>>();

            services.AddScoped<Handles<R_AccountSmsVerificationEvent>, R_AccountSmsVerificationHandle>();
            services.AddScoped<Handles<R_AdminCreatedEvent>, R_AdminCreatedEmailHandle>();

            // Resolve cac service manual
            var serviceProvider = services.BuildServiceProvider();
            DomainEvents.Init(serviceProvider);

            return services;
        }

        public static void AddUnitOfWork<T>(this IServiceCollection services) where T : DbContext
        {
            services.AddScoped<IUnitOfWork<T>, DbUnitOfWork<T>>();           // do xai memory, nen rem dong nay
            services.AddScoped<IUnitOfWork>(provider => provider.GetService<IUnitOfWork<T>>());
            // services.AddScoped<IUnitOfWork, MemoryUnitOfWork>();
            
        }

        public static void AddUnitOfWorkPool(this IServiceCollection services, Action<UnitOfWorkPoolOptionsBuilder> optionsAction)
        {
            var optionsBuilder = new UnitOfWorkPoolOptionsBuilder();
            optionsAction.Invoke(optionsBuilder);

            services.AddScoped(typeof(IUnitOfWork<>), typeof(DbUnitOfWork<>));
            services.AddSingleton(typeof(UnitOfWorkPoolOptions), optionsBuilder.Options);
            services.AddScoped<IUnitOfWorkPool, DbUnitOfWorkPool>();
        }
    }
}
