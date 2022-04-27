using GroupWebApp.Managers.Interfaces;
using GroupWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace GroupWebApp.Managers.Mocks
{
    public class MockRecipes : IAllRecipes
    {
        private readonly IRecipesCategory _categoryReceipts = new MockCategory();

        public IEnumerable<Recipe> Recipes {
            get
            {
                return new List<Recipe>
                {
                    new Recipe { name = "Айсберг", shortDesc = "", longDesc="", img = "",IsFavourite = true, Category = _categoryReceipts.AllCategories.First() },
                };

            }
        }
        public IEnumerable<Recipe> getFavRecipes { get ; set ; }

        public Recipe getObjectRecipe(int recipeid)
        {
            throw new System.NotImplementedException();
        }
    }
}
