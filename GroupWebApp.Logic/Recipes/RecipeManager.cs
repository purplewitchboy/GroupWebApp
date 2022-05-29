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

        public async Task Create(string name, int subcatId, string desk, byte[] image)
        {
            var recipe = new Recipe { Name = name, SubCategoryId = subcatId, desc = desk, Image = image };
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync();
        }

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
    }
}
