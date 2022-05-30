﻿namespace GroupWebApp.Models
{
    public class CreateRecipeRequest
    {
        public string Name { set; get; }
        public string Image { set; get; }
        public string desc { set; get; }
        public int SubCategoryId { get; set; }

        public int NationalKitchenId { get; set; }
        public int TypeOfPreparationId { get; set; }
        public int IngredientId { get; set; }
    }
}
