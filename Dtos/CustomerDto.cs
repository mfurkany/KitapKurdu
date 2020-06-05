using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using KitapKurdu.Models;

namespace KitapKurdu.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public string PhoneNumber { get; set; }
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

    }
}