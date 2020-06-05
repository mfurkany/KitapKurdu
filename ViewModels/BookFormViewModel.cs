using KitapKurdu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace KitapKurdu.ViewModels
{
    public class BookFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Display(Name = "Tür")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Çıkış Tarihi")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Stoktaki miktar")]
        [Range(1, 10)]
        [Required]
        public byte? NumberInStock { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Kitabı Düzenle" : "Yeni Kitap";
            }
        }

        public BookFormViewModel()
        {
            Id = 0;
        }

        public BookFormViewModel(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            ReleaseDate = book.ReleaseDate;
            NumberInStock = book.NumberInStock;
            GenreId = book.GenreId;
        }
    }
}
