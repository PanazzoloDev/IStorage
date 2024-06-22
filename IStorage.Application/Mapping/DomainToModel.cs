using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Mapping
{
    public class DomainToModel
    {
        public class DomainToDTOMapping : Profile
        {
            public DomainToDTOMapping()
            {
                CreateMap<Customer, ViewCustomerModel>().ReverseMap();
                CreateMap<Customer, UpdateCustomerModel>().ReverseMap();
                CreateMap<Customer, NewCustomerModel>().ReverseMap();

                CreateMap<Inventory, ViewInventoryModel>().ReverseMap();
                CreateMap<Inventory, UpdateInventoryModel>().ReverseMap();
                CreateMap<Inventory, NewInventoryModel>().ReverseMap();

                CreateMap<Material, ViewMaterialModel>().ReverseMap();
                CreateMap<Material, UpdateMaterialModel>().ReverseMap();
                CreateMap<Material, NewMaterialModel>().ReverseMap();

                CreateMap<MaterialProduct, ViewMaterialProductModel>().ReverseMap();
                CreateMap<MaterialProduct, UpdateMaterialProductModel>().ReverseMap();
                CreateMap<MaterialProduct, NewMaterialProductModel>().ReverseMap();

                CreateMap<Movement, ViewMovementModel>().ReverseMap();
                CreateMap<Movement, UpdateMovementModel>().ReverseMap();
                CreateMap<Movement, NewMovementModel>().ReverseMap();

                CreateMap<Order, ViewOrderModel>().ReverseMap();
                CreateMap<Order, UpdateOrderModel>().ReverseMap();
                CreateMap<Order, NewOrderModel>().ReverseMap();

                CreateMap<Product, ViewProductModel>().ReverseMap();
                CreateMap<Product, UpdateProductModel>().ReverseMap();
                CreateMap<Product, NewProductModel>().ReverseMap();

                CreateMap<ProductOrder, ViewProductOrderModel>().ReverseMap();
                CreateMap<ProductOrder, UpdateProductOrderModel>().ReverseMap();
                CreateMap<ProductOrder, NewProductOrderModel>().ReverseMap();

                CreateMap<User, ViewUserModel>().ReverseMap();
                CreateMap<User, UpdateUserModel>().ReverseMap();
                CreateMap<User, NewUserModel>().ReverseMap();

                CreateMap<Warehouse, ViewWarehouseModel>().ReverseMap();
                CreateMap<Warehouse, UpdateWarehouseModel>().ReverseMap();
                CreateMap<Warehouse, NewWarehouseModel>().ReverseMap();
            }
        }
    }
}