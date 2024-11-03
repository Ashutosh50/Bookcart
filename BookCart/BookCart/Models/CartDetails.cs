using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCart.Models
{
    [Table("CartDetails")]
    public class CartDetails
    {
            public int Id { get; set; }
            [Required]
            public int ShoppingCartId { get; set; }
            [Required]
            public int BookId { get; set; }
            [Required]
            public int Quantity { get; set; }
            [Required]
            public double UnitPrice { get; set; }
            public Books Book { get; set; }
            public ShopingCart ShoppingCart { get; set; }

        }
    }

