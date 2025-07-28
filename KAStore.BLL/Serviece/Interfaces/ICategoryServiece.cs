using KAStore.DAL.DTO.Request;
using KAStore.DAL.DTO.Responce;
using KAStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.BLL.Serviece.Interfaces
{
    public interface ICategoryServiece: IGenricServices<CategoryRequest,CategoryResponce,Category>
    {

    }
}
