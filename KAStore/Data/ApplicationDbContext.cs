﻿using KAStore.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category>Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }
    }
}
