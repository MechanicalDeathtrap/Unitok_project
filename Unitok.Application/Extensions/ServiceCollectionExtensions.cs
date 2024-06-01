using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Unitok.Application.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
		{
			services.AddAutoMapper();
			services.AddMediator();
			return services;
		}

		private static void AddCustomIdentity(this IServiceCollection services)
		{
		}

		private static void AddAutoMapper(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);
		}

		private static void AddMediator(this IServiceCollection services)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		}
	}
}
