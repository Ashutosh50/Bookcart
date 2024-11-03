using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCart.Models
{
    [Table("Books")]
    public class Books
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }

        [Required]
        [MaxLength(40)]
        public string? AuthorName { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetails> OrderDetail { get; set; }
        public List<CartDetails> CartDetail { get; set; }
        //public Stock Stock { get; set; }

        [NotMapped]
        public string GenreName { get; set; }
        [NotMapped]
        public int Quantity { get; set; }


    }
}
