using Microsoft.Extensions.DependencyInjection;

namespace Unitok_project
{
	public static class Entry
	{
		public static void AddApplicationLayer(this IServiceCollection services)
		{
			services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(Entry).Assembly));

		}
	}
}
