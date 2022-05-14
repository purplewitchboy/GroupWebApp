using GroupWebApp.Storage.Entities;

namespace GroupWebApp.Logic.SubCategories
{
    public interface ISubCategoryManager
    {
        Task<IList<SubCategory>> GetAll();
        Task Create(string name,int id);
    }
}
