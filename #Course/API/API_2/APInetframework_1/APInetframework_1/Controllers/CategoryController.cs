using APInetframework_1.DesignPatterns.SingletonPattern;
using APInetframework_1.Models;
using APInetframework_1.ViewModels.RequestModels;
using APInetframework_1.ViewModels.ResponseModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APInetframework_1.Controllers
{
    public class CategoryController : ApiController
    {
        NorthwindEntities _db;
        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }

        List<CategoryResponseModel> ListCategories()
        {
            return _db.Categories.Select(x => new CategoryResponseModel
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.CategoryID
            }).ToList();
        }

        [HttpGet]
        public List<CategoryResponseModel> GetCategories()
        {
            return ListCategories();
        }
        [HttpGet]
        public CategoryResponseModel GetCategory(int id)
        {
            return _db.Categories.Where(x => x.CategoryID == id).Select(x => new CategoryResponseModel
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.CategoryID
            }).FirstOrDefault();
        }
        [HttpDelete]
        public List<CategoryResponseModel> DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return ListCategories();
        }
        [HttpPut]
        public List<CategoryResponseModel> UpdatedCategory(CategoryResponseModel category)
        {
            Category c = _db.Categories.Find(category.Id);
            c.Description = category.Description;
            c.CategoryName = category.CategoryName;
            _db.SaveChanges();
            return ListCategories();

        }
        [HttpPost]
        public List<CategoryResponseModel> AddCategory(CreateCategoryRequestModel category)
        {
            Category c = new Category()
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
            };
            _db.Categories.Add(c);
            _db.SaveChanges();
            return ListCategories();
        }


        [HttpGet]
        public List<CategoryResponseModel> SearchCategory(string item)
        {
            return _db.Categories.Where(x => x.CategoryName.Contains(item)).Select(x => new CategoryResponseModel
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.CategoryID
            }).ToList();

        }

    }
}
