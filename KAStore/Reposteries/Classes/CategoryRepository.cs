using KAStore.DAL.Data;
using KAStore.DAL.Model;
using KAStore.DAL.Reposteries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.DAL.Reposteries.Classes
{
    public class CategoryRepository:GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext context):base(context)
        {
           
        }

    


    }
}
