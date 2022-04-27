using GroupWebApplication.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupWebApplication.Managers.Interfaces
{
    public interface IAllRecipes
    {
        IEnumerable<Recipe> Recipes { get; }
        IEnumerable<Recipe> getFavRecipes { get; set; }

        Recipe getObjectRecipe(int recipeid);
    }
}
