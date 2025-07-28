using KAStore.BLL.Serviece.Interfaces;
using KAStore.DAL.DTO.Request;
using KAStore.DAL.DTO.Responce;
using KAStore.DAL.Model;
using KAStore.DAL.Reposteries.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.BLL.Serviece.Classes
{
    public class CategoryServiece : GenericService<CategoryRequest,CategoryResponce,Category>, ICategoryServiece
    {
        public CategoryServiece(ICategoryRepository repostery) : base(repostery)
        {
        }

    }
}
