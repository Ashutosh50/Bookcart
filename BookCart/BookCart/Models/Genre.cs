﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCart.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string GenreName { get; set; }
        public List<Books> Books { get; set; }
    }
}
