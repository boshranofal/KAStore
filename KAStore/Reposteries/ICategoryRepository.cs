using KAStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.DAL.Reposteries
{
    public interface ICategoryRepository
    {
        public int Add(Category category);
        public Category? GetById(int Id);
        IEnumerable<Category> GetAll(bool withTracking=false);
        int Remove(Category category);
        int Update(Category category);
    }
}
