using KAStore.BLL.Serviece.Interfaces;
using KAStore.DAL.DTO.Request;
using KAStore.DAL.DTO.Responce;
using KAStore.DAL.Model;
using KAStore.DAL.Reposteries.Classes;
using KAStore.DAL.Reposteries.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.BLL.Serviece.Classes
{
    public class GenericService<TRequest, TResponse, TEntity> :IGenricServices<TRequest,TResponse,TEntity>
        where TEntity:BaseModel
    {

        public readonly IGenericRepositories<TEntity> _GenericRepository;
        public GenericService(IGenericRepositories<TEntity> GenericRepository)
        {
            _GenericRepository = GenericRepository;
        }
        public int Create(TRequest request)
        {
            var entity = request.Adapt<TEntity>();
            return _GenericRepository.Add(entity);
        }

        public int Delete(int Id)
        {
            var entity = _GenericRepository.GetById(Id);
            if (entity is null)
            {
                return 0;

            }
            return _GenericRepository.Remove(entity);
        
    }

        public IEnumerable<TResponse> GetAll()
        {
            var entities = _GenericRepository.GetAll();
            return entities.Adapt<IEnumerable<TResponse>>();
        }

        public TResponse? GetById(int id)
        {
            var entity = _GenericRepository.GetById(id);
            return entity is null ? default : entity.Adapt<TResponse>();
        }

        public bool ToggleStatus(int Id)
        {
            var entity = _GenericRepository.GetById(Id);
            if (entity is null)
            {
                return false;
            }
            entity.Status = entity.Status == Status.Active ? Status.InActive : Status.Active;
            _GenericRepository.Update(entity);
            return true;
        }

     

        public int Update(int Id, TRequest request)
        {
            var entity = _GenericRepository.GetById(Id);
            if (entity is null)
            {
                return 0;
            }
           var updateEntity= request.Adapt(entity);
            return _GenericRepository.Update(updateEntity);
        }
    }
}
