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

        EFCategoryRepo eFCategoryRepo;

        public CategoryManager()
        {
            eFCategoryRepo = new EFCategoryRepo();
        }

        public void CategoryAdd(Category category)
        {
            eFCategoryRepo.Insert(category);

            //if (category.CategoryName != "" && category.CategoryDescription != "" && category.CategoryName.Length>= 5 && category.CategoryStatus== true)
            //{
            //    categoryRepository.AddCategory(category);
            //}
            //else
            //{
            //    //hata mesajı , fluent validation

            //}
        }

        public void CategoryDelete(Category category)
        {
            eFCategoryRepo.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            eFCategoryRepo.Update(category);
        }

        public Category GetById(int id)
        {
            return eFCategoryRepo.GetById(id);
        }

        public List<Category> GetList()
        {
            return eFCategoryRepo.GetListAll();
        }
    }
}
