using Microsoft.EntityFrameworkCore;


namespace GroupWebApp.Logic.Recipes
{
    public class RecipeManager : IRecipeManager
    {
        private readonly RecipeContext _context;
        public RecipeManager(RecipeContext context)
        {
            _context = context;
        }
        public async Task<IList<Recipe>> GetAll(int id) => await _context.Recipes.Where(x => x.SubCategoryId==id).ToListAsync();

        public async Task<IList<Recipe>> GetInfo(int id) => await _context.Recipes.Where(y => y.Id==id).ToListAsync();


        public List<Recipe> SortByNationalKitchen(int id)
        {
            var rec = _context.Recipes;

            List<Recipe> recipes = new List<Recipe>();
            var nkId = new Recipe { NationalKitchenId = id };
            foreach (var oneRecipe in rec.ToList())
            {
                recipes.Add(oneRecipe);
            }
            
            return recipes;
        }

        public List<Recipe> SortByTypeOfPreparation(int id)
        {
            var rec = _context.Recipes;

            List<Recipe> recipes = new List<Recipe>();
            var topId = new Recipe { TypeOfPreparationId = id };
            foreach (var oneRecipe in rec.ToList())
            {
                recipes.Add(oneRecipe);
            }

            return recipes;
        }

        public List<Recipe> SortByIngredient(int id)
        {
            var rec = _context.Recipes;

            List<Recipe> recipes = new List<Recipe>();
            var ingredientId = new Recipe { ByIngredientId = id };
            foreach (var oneRecipe in rec.ToList())
            {
                recipes.Add(oneRecipe);
            }

            return recipes;
        }
    }
}
