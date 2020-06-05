using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KitapKurdu.Models;

namespace KitapKurdu.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public int? Id { get; set; }

        public Customer Customer { get; set; }
    }
}