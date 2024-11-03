using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BookCart.Models.CartDetails;

namespace BookCart.Models
{
    [Table("ShopingCart")]
    public class ShopingCart
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CartDetails> CartDetails { get; set; }



    }
}
