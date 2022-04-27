using GroupWebApp.Managers.Interfaces;
using GroupWebApp.Models;
using System.Collections.Generic;

namespace GroupWebApp.Managers.Mocks
{
    public class MockCategory : IRecipesCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Салаты", desc = "Салаты" },
                    new Category { categoryName = "Горячие блюда", desc = "Горячее" }
                };

            }
        }
    }
}
