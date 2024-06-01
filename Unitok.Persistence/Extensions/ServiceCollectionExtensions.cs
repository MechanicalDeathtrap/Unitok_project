using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Unitok.Application.Interfaces.Repositories;
using Unitok.Persistence.Repositories;
using Unitok_progect.Application.Interfaces.Repositories;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;
using Unitok.Persistence.Repositories;

namespace Unitok.Persistence.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext(configuration);
			//services.AddRepositories();
/*			services.AddIdentity<UserMain, IdentityRole<int>>()   //ok
				.AddEntityFrameworkStores<ApplicationDbContext>()
			.AddDefaultTokenProviders();
*/
			services.AddIdentity<UserMain, IdentityRole<int>>(options =>
			{
				options.SignIn.RequireConfirmedAccount = true;
			
			})
			.AddEntityFrameworkStores<ApplicationDbContext>()
			.AddDefaultTokenProviders();


			return services;
		}

		private static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			Console.WriteLine(configuration);
			services.AddDbContext<ApplicationDbContext>(opt =>
				opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
				.EnableSensitiveDataLogging()
				.LogTo(Console.WriteLine, LogLevel.Information));
		}

/*		private static void AddRepositories(this IServiceCollection services)
		{
			services
				.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork))
				.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
				.AddScoped<ICardRepository, CardRepository>();
		}*/
	}
}
