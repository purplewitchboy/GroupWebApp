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

        public async Task<IList<Recipe>> GetAll() => await _context.Recipes.ToListAsync();

        public async Task Create(string name)
        {
            var recipe = new Recipe { Name = name };
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync();
        }
    }
}
