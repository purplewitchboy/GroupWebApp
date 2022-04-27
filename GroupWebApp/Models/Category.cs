using System.Collections.Generic;

namespace GroupWebApplication.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }

        public List<Recipe> receips { set; get; }
    }

}
