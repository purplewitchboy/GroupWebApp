using GroupWebApp.Storage.Entities;

namespace GroupWebApp.Logic.Recipes
{
    public interface IRecipeManager
    {
        Task<IList<Recipe>> GetAll(int id);
        Task Create(string name, int subcatId);
    }
}
