﻿using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            if(category.CategoryID != 0)
            {
                repo.Delete(category);
            }
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
