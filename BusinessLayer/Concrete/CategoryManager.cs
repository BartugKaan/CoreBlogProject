using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
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
        EFCategoryRepository eFCategoryRepository;

        public CategoryManager()
        {
            eFCategoryRepository = new EFCategoryRepository();
        }

        public void AddCategory(Category category)
        {
            eFCategoryRepository.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            eFCategoryRepository.Delete(category);
        }

        public Category GetById(int id)
        {
            return eFCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return eFCategoryRepository.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            eFCategoryRepository.Update(category);
        }
    }
}
