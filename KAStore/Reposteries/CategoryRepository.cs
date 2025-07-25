﻿using KAStore.DAL.Data;
using KAStore.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAStore.DAL.Reposteries
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext context) {
            this.context=context;
        }

        public int Add(Category category)
        {
           context.Categories.Add(category);
            return context.SaveChanges();
        }

        public IEnumerable<Category> GetAll(bool withTracking = false)
        {
            if(withTracking)
           return context.Categories.ToList();

            return context.Categories.AsNoTracking().ToList();
        }

        public Category? GetById(int Id)
        {
            return context.Categories.Find(Id);
        }

        public int Remove(Category category)
        {
            context.Categories.Remove(category);
            return context.SaveChanges();   
        }

        public int Update(Category category)
        {
            context.Categories.Update(category);
            return context.SaveChanges();
        }
    }
}
