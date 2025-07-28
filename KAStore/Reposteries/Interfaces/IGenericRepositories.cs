using KAStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.DAL.Reposteries.Interfaces
{
    public interface IGenericRepositories<T> where T : BaseModel
    {
         int Add(T entity);
         T? GetById(int Id);
        IEnumerable<T> GetAll(bool withTracking = false);
        int Remove(T entity);
        int Update(T entity);
    }
}
