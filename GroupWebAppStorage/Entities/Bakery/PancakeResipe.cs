using System.ComponentModel.DataAnnotations.Schema;

namespace GroupWebApp.Storage.Entities
{
    public class PancakeResipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Steps { get; set; }
        public int BakeryId { get; set; }

        [ForeignKey(nameof(BakeryId))]

        public virtual Bakery Bakery { get; set; }

    }
}
