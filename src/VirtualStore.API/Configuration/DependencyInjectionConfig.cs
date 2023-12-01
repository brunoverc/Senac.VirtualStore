using System;
using MediatR;
using VirtualStore.Application.Interfaces;
using VirtualStore.Application.Services;
using VirtualStore.Core.UoW;
using VirtualStore.Domain.Interfaces;
using VirtualStore.Infra.Data.Context;
using VirtualStore.Infra.Data.Repositories;
using VirtualStore.Infra.Data.UoW;

namespace VirtualStore.API.Configuration
{
	public static class DependencyInjectionConfig
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			services.AddMediatr();
			services.AddRepositories();
			services.AddServices();
		}

		public static void AddMediatr(this IServiceCollection services)
		{
			services.AddMediatR(AppDomain.CurrentDomain.Load("VirtualStore.Domain"));
		}

		public static void AddRepositories(this IServiceCollection services)
		{
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<VirtualStoreDbContext>();

			services.AddScoped<IProductRepository, ProductRepository>();
		}

		public static void AddServices(this IServiceCollection services)
		{
			services.AddScoped<IProductAppService, ProductAppService>();
		}


	}
}

