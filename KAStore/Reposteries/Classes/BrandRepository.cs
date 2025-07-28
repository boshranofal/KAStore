using KAStore.DAL.Data;
using KAStore.DAL.Model;
using KAStore.DAL.Reposteries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.DAL.Reposteries.Classes
{
    public class BrandRepository:GenericRepository<Brand>,IBrandRepository
    {

        private readonly ApplicationDbContext context;

        public BrandRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
