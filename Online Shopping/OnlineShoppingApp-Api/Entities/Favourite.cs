using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingApp.Entities
{
    [Table("Favourite")]
    public class Favourite
    {
        [Key]
        public int FavId { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }

        [ForeignKey("Products")]
        public int ProductId { get; set; }

        public User? Users { get; set; }
        public Product? Products { get; set; }
    }
}
