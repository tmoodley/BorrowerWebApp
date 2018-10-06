using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowerRegistrationApplication
{
	public static class ServiceExtensions
	{
		public static IServiceCollection RegisterServices(
			this IServiceCollection services)
		{
			//services.AddTransient<IBorrowerRepository, BorrowerRepository>();
			services.AddScoped<IBorrowerRepository, BorrowerRepository>();
			services.AddTransient<IBorrowerService, BorrowerService>();

			// Add all other services here.
			return services;
		}
	}
}
