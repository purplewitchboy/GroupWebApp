using GroupWebApp.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupWebApp.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IAllRecipes _allRecipes;
        private readonly IRecipesCategory _allCategories;

        public RecipesController(IAllRecipes iAllRecipes, IRecipesCategory iRecipesCat)
        {
            _allRecipes = iAllRecipes;
            _allCategories = iRecipesCat;
        }

        public ViewResult list()
        {
            var recipes = _allRecipes.Recipes;
            return View(recipes);
        }
    }
}
