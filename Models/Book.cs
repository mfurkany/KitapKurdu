using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitapKurdu.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "İsim")]
        public string Name { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Tür")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        [Display(Name = "Çıkış Tarihi")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Stokta bulunan miktar")]
        [Range(1, 10)]
        public byte NumberInStock { get; set; }

    }
}