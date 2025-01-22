using System;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Book> data { get; set; }
        /* Constructor takes a BookstoreContext parameter and initializes the data property with a new instance
        of Repository<Book>, allowing the controller to interact with the data layer*/
        public HomeController(BookstoreContext ctx) => data = new Repository<Book>(ctx);

        // Index action method returns a ViewResult with a random book
        public ViewResult Index()
        {
            var random = data.Get(new QueryOptions<Book> {
                OrderBy = b => Guid.NewGuid()
            });

            return View(random);
        }
    }
}