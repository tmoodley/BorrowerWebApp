using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services;

namespace BorrowerRegistrationApplication
{
	public static class ServiceExtensions
	{
		public static IServiceCollection RegisterServices(
			this IServiceCollection services)
		{
			services.AddScoped<IBorrowerRepository, BorrowerRepository>();
			services.AddTransient<IBorrowerService, BorrowerService>();

			return services;
		}
	}
}
