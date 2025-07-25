using KAStore.DAL.DTO.Request;
using KAStore.DAL.DTO.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.BLL.Serviece
{
    public interface ICategoryServiece
    {

        int CreateCategory(CategoryRequest request);
        IEnumerable<CategoryResponce> GetAllCategories();
        CategoryResponce? GetCategoryById(int id);

        int Update(int Id,CategoryRequest request);
        int DeleteCategory(int Id);
        bool ToggleStatus(int Id);
    }
}
