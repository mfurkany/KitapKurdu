using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using KitapKurdu.Dtos;
using KitapKurdu.Models;


namespace KitapKurdu.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
           
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var books = _context.Books.Where(
                b => newRental.BookIds.Contains(b.Id)).ToList();

            foreach (var book in books)
            {
                if (book.NumberInStock == 0)
                    return BadRequest("Kitap mevcut değil");

                book.NumberInStock--;

                var rental = new Rental
                {
                    Customer = customer,
                    Book = book,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
