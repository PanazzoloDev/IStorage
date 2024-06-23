using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class ServiceBase<Entity, View, Update, New> : IServiceBase<Entity, View, Update, New>
        where Entity : class
        where View : class
        where Update : class
        where New : class
    {
        protected readonly IRepositoryBase<Entity> _repo;
        protected readonly IMapper _mapper;
        //protected readonly IUnityOfWork _uow;

        public ServiceBase(
            IRepositoryBase<Entity> repository,
            IMapper mapper
            //IUnityOfWork uow,
        )
        {
            _repo = repository;
            _mapper = mapper;
            //_uow = uow;
        }

        public async Task CreateAsync(New product)
        {
            var entity = _mapper.Map<Entity>(product);
            await _repo.CreateAsync(entity);
        }

        public async Task DeleteAsync(long? id)
        {
            var entity = _repo.GetByIdAsync(id).Result;
            await _repo.DeleteAsync(entity);
        }

        public async Task<IEnumerable<View>> GetAllAsync()
        {
            var entities = await _repo.GetAll();
            return _mapper.Map<IEnumerable<View>>(entities);
        }

        public async Task<View> GetByIdAsync(long? id)
        {
            var entity = await _repo.GetByIdAsync(id);
            return _mapper.Map<View>(entity);
        }

        public async Task UpdateAsync(Update product)
        {
            var entity = _mapper.Map<Entity>(product);
            await _repo.UpdateAsync(entity);
        }

    }
}