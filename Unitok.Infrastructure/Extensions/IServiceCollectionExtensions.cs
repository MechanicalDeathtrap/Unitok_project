using Unitok_progect.Domain.Common;
using Unitok_progect.Domain.Common.Interfaces;
using Unitok_progect.Infrastructure.Services;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace Unitok_progect.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>()
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>()
/*                .AddTransient<IDateTimeService, DateTimeService>()
                .AddTransient<IEmailService, EmailService>()*/;
        }
    }
}
