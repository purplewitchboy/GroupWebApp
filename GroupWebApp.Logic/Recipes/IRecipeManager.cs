using GroupWebApp.Storage.Entities;

namespace GroupWebApp.Logic.Recipes
{
    public interface IRecipeManager
    {
        Task<IList<Recipe>> GetAll(int id);
        Task<IList<Recipe>> GetInfo(int id);
        List<Recipe> SortByNationalKitchen(int id);
        List<Recipe> SortByTypeOfPreparation(int id);
        List<Recipe> SortByIngredient(int id);
        Task Create(string name, int subcatId, string desk, string image);
    }
}
