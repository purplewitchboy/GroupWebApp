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
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category {get; set;}
    }

}
