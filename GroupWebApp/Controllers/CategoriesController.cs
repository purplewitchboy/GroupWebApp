using Microsoft.AspNetCore.Mvc;
using GroupWebApp.Logic.Categories;
using GroupWebApp.Storage.Entities;

namespace GroupWebApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryManager _manager;

        public CategoriesController(ICategoryManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        [Route("categories")]
        public Task<IList<Category>> GetAll() => _manager.GetAll(); 
    }
}
