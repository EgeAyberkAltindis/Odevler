using API.Models.ContextClasses;
using API.Models.Entities;
using API.Models.ViewModels.Categories.RequestModels;
using API.Models.ViewModels.Categories.ResponseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        MyContext _db;
        public CategoryController(MyContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetCategoies()
        {
            List<CategoryResponseModel> categories = _db.Categories.Select(x => new CategoryResponseModel
            {
                Id = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description

            }).ToList();
            
            return Ok(categories);
            
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetCategories(int Id) 
        {
            //Category c = await _db.Categories.FindAsync(Id);
            //CategoryResponseModel crm = new CategoryResponseModel()
            //{
            //    Id = c.ID,
            //    CategoryName = c.CategoryName,
            //    Description = c.Description
            //};
            //return Ok(crm); 

            CategoryResponseModel? crm = await _db.Categories.Where(x => x.ID == Id).Select(x => new CategoryResponseModel
            {
                Id = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).FirstOrDefaultAsync();
            return Ok(crm);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategories(CreateCategoryReguestModel createCategoryReguestModel)
        {
            //Category c = new Category();
            // c.CategoryName= createCategoryReguestModel.CategoryName;    
            // c.Description= createCategoryReguestModel.Description;
            // _db.Categories.Add(c);
            // _db.SaveChanges();
            // return Ok("EKleme basarılıdır");
            Category c = new()
            {
                CategoryName = createCategoryReguestModel.CategoryName,
                Description = createCategoryReguestModel.Description
            };
             await _db.Categories.AddAsync(c);
            _db.SaveChangesAsync();
            return Ok("EKleme basarılıdır");

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategories(int Id)
        {
            //_db.Categories.Remove(_db.Categories.Find(Id));
            _db.Categories.Remove( await _db.Categories.FindAsync(Id));
             await _db.SaveChangesAsync();
            return Ok("silme işlemi başarılı");


        }
        [HttpPut]
        public async Task<IActionResult> UpdatedCategory(UpdateCategoryRequestModel updateCategoryRequestModel)
        {
            Category c = await _db.Categories.FindAsync(updateCategoryRequestModel.Id);
            c.CategoryName = updateCategoryRequestModel.CategoryName;
            c.Description  = updateCategoryRequestModel.Description;
            _db.SaveChangesAsync();
            return Ok("güncelleme başarılı");
        }
    }
}
