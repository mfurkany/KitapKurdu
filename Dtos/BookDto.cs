using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KitapKurdu.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 10)]
        public byte NumberInStock { get; set; }
    }
}
