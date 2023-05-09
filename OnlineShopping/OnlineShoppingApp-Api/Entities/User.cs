using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingApp.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string? UserName { get; set; }

        
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string? EmailAdd { get; set; }

        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string? PhNo { get; set; }

        //Required info -> non null able
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string? Password { get; set; }
    }
}
