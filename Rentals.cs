//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KitapKurdu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rentals
    {
        public int Id { get; set; }
        public System.DateTime DateRented { get; set; }
        public Nullable<System.DateTime> DateReturned { get; set; }
        public int Customer_Id { get; set; }
        public int Book_Id { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
