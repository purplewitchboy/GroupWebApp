using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupWebApp.Storage.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public byte Image { set; get; }
        public string desc { set; get; }

        [Required]
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }


        [ForeignKey(nameof(SubCategoryId))]
        public virtual SubCategory SubCategory {get; set;}
        public virtual NationalKitchen NationalKitchen { get; set; }
        public virtual TypeOfPreparation TypeOfPreparation { get; set; }
        public virtual BySubIngredient BySubIngredient { get; set; }

    }

}
