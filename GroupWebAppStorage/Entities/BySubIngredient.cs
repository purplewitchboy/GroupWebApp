using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace GroupWebApp.Storage.Entities
{
    public class BySubIngredient
    {
        [Key]
        public int Id { get; set; }
        public string SubIngredient { get; set; }

        [Required]
        public int ByIngredientId { get; set; }

        [ForeignKey(nameof(ByIngredientId))]
        public virtual ByIngredient ByIngredient { get; set; }
    }
}
