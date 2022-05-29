using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupWebApp.Storage.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public byte[] Image { set; get; }
        public string desc { set; get; }
        public int NationalKitchenId { get; set; }
        public int TypeOfPreparationId { get; set; }
        public int ByIngredientId { get; set; }
        public int BySubIngredientId { get; set; }

        [Required]
        public int SubCategoryId { get; set; }


        [ForeignKey(nameof(SubCategoryId))]
        public virtual SubCategory SubCategory {get; set;}
        public virtual NationalKitchen NationalKitchen { get; set; }
        public virtual TypeOfPreparation TypeOfPreparation { get; set; }
        public virtual BySubIngredient BySubIngredient { get; set; }

    }

}
