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
    public class BrandServiece : GenericService<BrandRequest, BrandResponce, Brand>, IBrandServices
    {
        public BrandServiece(IBrandRepository repostery) : base(repostery)
        {
        }

    }
}
