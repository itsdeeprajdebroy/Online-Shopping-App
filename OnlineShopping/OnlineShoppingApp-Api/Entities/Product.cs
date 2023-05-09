using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingApp.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(100)]
        [Column(TypeName = "varchar")]
        public string? ProductName { get; set; }

        public double? price { get; set; }

        [StringLength(8000)]
        [Column(TypeName = "varchar")]
        public string? DescriptionOfProd { get; set; }

        [StringLength(8000)]
        [Column(TypeName = "varchar")]
        public string? Image { get; set; }

        public int Quantity { get; set; }
    }
}
