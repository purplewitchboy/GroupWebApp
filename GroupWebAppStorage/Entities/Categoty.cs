using System.Collections.Generic;

namespace GroupWebApp.Storage.Entities
{
    public class Category
    {
        [Key]
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }
    }

}
