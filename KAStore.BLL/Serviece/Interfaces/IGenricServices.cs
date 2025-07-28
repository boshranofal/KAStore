using KAStore.DAL.DTO.Request;
using KAStore.DAL.DTO.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.BLL.Serviece.Interfaces
{
    public interface IGenricServices<TRequest, TResponse,TEntity>
    {
        int Create(TRequest request);
        IEnumerable<TResponse> GetAll();
        TResponse? GetById(int id);
        int Update(int Id, TRequest request);
        int Delete(int Id);
        bool ToggleStatus(int Id);
    }
}
