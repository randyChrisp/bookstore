using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    // Manages actions related to books
    public class BookController : Controller
    {
        private BookstoreUnitOfWork data { get; set; }
        /* Constructor takes a BookstoreContext parameter and initializes the data property with a new instance
        of BookstoreUnitOfWork, allowing the controller to interact with the data layer*/
        public BookController(BookstoreContext ctx) => data = new BookstoreUnitOfWork(ctx);

        public RedirectToActionResult Index() => RedirectToAction("List"); // Redirects to the List action method

        // Displays a list of books
        public ViewResult List(BooksGridDTO values) // Accepts a BooksGridDTO object as a parameter, which contains pagination and sorting values
        {
            var builder = new BooksGridBuilder(HttpContext.Session, values, 
                defaultSortField: nameof(Book.Title)); // Creates a BooksGridBuilder object with the current session, BooksGridDTO values, and the default sort field(Book.Title)

            // Saves the current route segments and pagination state
            var options = new BookQueryOptions {
                Include = "BookAuthors.Author, Genre",
                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };
            options.SortFilter(builder); // Calls the SortFilter method to set the Where and OrderBy properties based on the current route values

            // Creates a BookListViewModel object with the list of books, authors, genres, current route, and total pages
            var vm = new BookListViewModel {
                Books = data.Books.List(options),
                Authors = data.Authors.List(new QueryOptions<Author> {
                    OrderBy = a => a.FirstName }),
                Genres = data.Genres.List(new QueryOptions<Genre> {
                    OrderBy = g => g.Name }),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Books.Count)
            };

            return View(vm); // Passes the BookListViewModel object to the view
        }

        // Displays details for a specific book
        public ViewResult Details(int id)
        {
            // Creates a QueryOptions object with the specified book ID
            var book = data.Books.Get(new QueryOptions<Book> {
                Include = "BookAuthors.Author, Genre",
                Where = b => b.BookId == id
            }); // Gets the book with the specified ID, including related authors and genre
            return View(book); // Passes the book object to the view
        }

        // Displays a list of books filtered by author, genre, or price
        [HttpPost]
        public RedirectToActionResult Filter(string[] filter, bool clear = false)
        {
            var builder = new BooksGridBuilder(HttpContext.Session); // Creates a BooksGridBuilder object with the current session

            if (clear) {
                builder.ClearFilterSegments(); // Clears the filter segments
            }
            else {
                var author = data.Authors.Get(filter[0].ToInt()); // Gets the author with the specified ID
                builder.LoadFilterSegments(filter, author); // Loads the filter segments with the specified values
            }

            builder.SaveRouteSegments(); // Saves the current route segments
            return RedirectToAction("List", builder.CurrentRoute); // Redirects to the List action method with the current route
        }
    }   
}