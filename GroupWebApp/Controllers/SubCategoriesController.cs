using Microsoft.AspNetCore.Mvc;
using GroupWebApp.Logic.SubCategories;
using GroupWebApp.Storage.Entities;
using GroupWebApp.Models;

namespace GroupWebApp.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly ISubCategoryManager _manager;

        public SubCategoriesController(ISubCategoryManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Main()
        {
            var subcategories = await _manager.GetAll();

            return View(subcategories);
        }

        [HttpGet]
        [Route("subcategories")]
        public Task<IList<SubCategory>> GetAll() => _manager.GetAll();

        [HttpPut]
        [Route("subcategories")]
        public Task Create([FromBody] CreateSubCategoryRequest request) => _manager.Create(request.Name);
    }
}
