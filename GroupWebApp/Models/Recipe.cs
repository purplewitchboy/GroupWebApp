namespace GroupWebApplication.Models
{
    public class Recipe
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public bool IsFavourite { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
