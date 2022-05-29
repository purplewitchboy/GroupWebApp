using GroupWebApp.Storage.Entities;

namespace GroupWebApp.Logic.Recipes
{
    public interface IRecipeManager
    {
        Task<IList<Recipe>> GetAll(int id);
        List<Recipe> SortByNationalKitchen(int id);
        Task Create(string name, int subcatId, string desk, byte[] image);
    }
}
