using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class ProductService : ServiceBase<Product,
        ViewProductModel,
        UpdateProductModel,
        NewProductModel>,
        IProductService
    {
        public ProductService(
            IRepositoryBase<Product> repository,
            IMapper mapper
        ):base(repository, mapper)
        {
            
        }
    }
}