using KAStore.DAL.DTO.Request;
using KAStore.DAL.DTO.Responce;
using KAStore.DAL.Model;
using KAStore.DAL.Reposteries;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.BLL.Serviece
{
    public class CategoryServiece : ICategoryServiece
    {
        public readonly ICategoryRepository categoryRepository;
        public CategoryServiece(ICategoryRepository categoryRepository) {
            this.categoryRepository = categoryRepository;
        }
        public int CreateCategory(CategoryRequest request)
        {
            var category = request.Adapt<Category>();
            return categoryRepository.Add(category);
        }

        public int DeleteCategory(int Id)
        {
          var category=categoryRepository.GetById(Id);
            if(category is null)
            {
                return 0;

            }
          return categoryRepository.Remove(category);
        }

        public IEnumerable<CategoryResponce> GetAllCategories()
        {
           var categories=categoryRepository.GetAll();
            return categories.Adapt<IEnumerable<CategoryResponce>>();
        }

        public CategoryResponce? GetCategoryById(int id)
        {
            var category=categoryRepository.GetById(id);
            return category is null ? null : category.Adapt<CategoryResponce>();
        }

        public int Update(int Id, CategoryRequest request)
        {
            var category = categoryRepository.GetById(Id);
            if (category is null)
            {
                return 0;
            }
            category.Name=request.Name;
            return categoryRepository.Update(category);
        }
        public bool ToggleStatus(int Id)
        {
            var category = categoryRepository.GetById(Id);
            if (category is null)
            {
                return false;
            }
            category.Status = category.Status == Status.Active ? Status.InActive : Status.Active;
            categoryRepository.Update(category);
            return true;
        }
    }
}
