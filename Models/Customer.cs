using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitapKurdu.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage ="İsim alanı boş bırakılamaz")]
        [Display(Name = "İsim")]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name = "Kullanıcı Tipi")]
        public byte MembershipTypeId { get; set; }



    }
}