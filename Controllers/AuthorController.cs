using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    // Manages actions related to authors
    public class AuthorController : Controller
    {
        private Repository<Author> data { get; set; }
        /* Constructor takes a BookstoreContext parameter and initializes the data property with a new instance
        of Repository<Author>, allowing the controller to interact with the data layer*/
        public AuthorController(BookstoreContext ctx) => data = new Repository<Author>(ctx);

        public IActionResult Index() => RedirectToAction("List"); // Redirects to the List action method

        // Displays a list of authors
        public ViewResult List(GridDTO vals) // Accepts a GridDTO object as a parameter, which contains pagination and sorting values
        {
            string defaultSort = nameof(Author.FirstName);
            var builder = new GridBuilder(HttpContext.Session, vals, defaultSort);// Creates a GridBuilder object with the current session, GridDTO values, and the default sort field
            builder.SaveRouteSegments(); // Saves the current route segments and pagination state

            // Creates a QueryOptions object with the current route values
            var options = new QueryOptions<Author> {
                Include = "BookAuthors.Book",
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize,
                OrderByDirection = builder.CurrentRoute.SortDirection
            };
            if (builder.CurrentRoute.SortField.EqualsNoCase(defaultSort)) // Sets the OrderBy property based on the current sort field
                options.OrderBy = a => a.FirstName;
            else
                options.OrderBy = a => a.LastName;

            // Creates an AuthorListViewModel object with the list of authors, current route, and total pages
            var vm = new AuthorListViewModel {
                Authors = data.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Count)
            };

            return View(vm); // Passes the AuthorListViewModel object to the view
        }

        // Displays details for a specific author
        public IActionResult Details(int id)
        {
            // Creates a QueryOptions object with the specified author ID
            var author = data.Get(new QueryOptions<Author> {
                Include = "BookAuthors.Book",
                Where = a => a.AuthorId == id
            });
            return View(author); // Passes the author object to the view
        }
    }
}