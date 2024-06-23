using IStorage.Application.Interfaces;
using IStorage.Application.Mapping;
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
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")
            ));

            // AutoMapper
            services.AddAutoMapper(typeof(DomainToModel));

            // Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<ISupplyRepository, SupplyRepository>();
            services.AddScoped<ISupplyProductRepository, SupplyProductRepository>();
            services.AddScoped<IMovementRepository, MovementRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductOrderRepository, ProductOrderRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();

            // Services
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<ISupplyService, SupplyService>();
            services.AddScoped<ISupplyProductService, SupplyProductService>();
            services.AddScoped<IMovementService, MovementService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductOrderService, ProductOrderService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWarehouseService, WarehouseService>();

            return services;
        }
    }
}