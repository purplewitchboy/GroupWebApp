using Microsoft.EntityFrameworkCore;

namespace GroupWebApp.Logic.SubCategories
{
    public class SubCategoryManager : ISubCategoryManager
    {
        private readonly RecipeContext _context;
        public SubCategoryManager(RecipeContext context)
        {
            _context = context;
        }

        public async Task<IList<SubCategory>> GetAll() => await _context.SubCategories.ToListAsync();

        public async Task Create(string name)
        {
            var subcategory = new SubCategory { NameSubCategory = name };
            _context.SubCategories.Add(subcategory);
            await _context.SaveChangesAsync();
        }
    }
}
