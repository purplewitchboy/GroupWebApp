﻿using System.Collections.Generic;

namespace GroupWebApp.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }

        public List<Recipe> receips { set; get; }
    }

}
