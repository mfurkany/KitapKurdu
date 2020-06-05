using KitapKurdu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitapKurdu.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }
    }
}