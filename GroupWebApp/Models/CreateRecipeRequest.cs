namespace GroupWebApp.Models
{
    public class CreateRecipeRequest
    {
        public string Name { set; get; }
        public byte[] Image { set; get; }
        public string desc { set; get; }
        public int SubCategoryId { get; set; }

        public int NationalKitchenId { get; set; }
        public int TypeOfPreparationId { get; set; }
    }
}
