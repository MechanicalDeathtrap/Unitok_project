using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok.Application.Interfaces;
using Unitok.Infrastructure.Services;

namespace Unitok.Infrastructure
{
	public static class Entry
	{
		public static void AddInfrastructure(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddHttpContextAccessor();
			serviceCollection.AddScoped<IUserContext, UserContext>();
		}
	}
}
