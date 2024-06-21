using IStorage.Application.Interfaces;
using IStorage.Application.Services;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;
using IStorage.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IStorage.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(
            this IServiceCollection services,
            IConfiguration config
        ) 
        {
            // Contexto
            services.AddDbContext<IStorageDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(IStorageDbContext).Assembly.FullName)
            ));

            // AutoMapper
            //services.AddAutoMapper(typeof(DomainToDTOMapping));

            // Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IMaterialProductRepository, MaterialProductRepository>();
            services.AddScoped<IMovementRepository, MovementRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductOrderRepository, ProductOrderRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();

            // Services
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}