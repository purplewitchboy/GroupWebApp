using Microsoft.AspNetCore.Mvc;
using GroupWebApp.Logic.Recipes;
using GroupWebApp.Storage.Entities;
using GroupWebApp.Models;

namespace GroupWebApp.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IRecipeManager _manager;

        public RecipesController(IRecipeManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Main(int id)
        {
            var recipes = await _manager.GetAll(id);

            return View(recipes);
        }

        [HttpGet]
        [Route("recipes")]
        public Task<IList<Recipe>> GetAll(CreateRecipeRequest request) => _manager.GetAll(request.SubCategoryId);

        [HttpPut]
        [Route("recipes")]
        public Task Create([FromBody] CreateRecipeRequest request) => _manager.Create(request.Name, request.SubCategoryId, request.desc, request.Image);
    }
}
