using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    [Authorize] // Requires authorization for all actions in this controller
    // Manage shopping cart actions
    public class CartController : Controller
    {
        private Repository<Book> data { get; set; }
        /* Constructor takes a BookstoreContext parameter and initializes the data property with a new instance
        of Repository<Book>, allowing the controller to interact with the data layer*/
        public CartController(BookstoreContext ctx) => data = new Repository<Book>(ctx);


        // Helper method to get the cart from the session
        private Cart GetCart()
        {
            var cart = new Cart(HttpContext); // Creates a new Cart object with the current HttpContext
            cart.Load(data); // Loads the cart data from the repository
            return cart;
        }

        // Displays the contents of the shopping cart
        public ViewResult Index() 
        {
            var cart = GetCart(); // Gets the cart from the session
            var builder = new BooksGridBuilder(HttpContext.Session); // Creates a BooksGridBuilder object with the current session

            // Creates a CartViewModel object with the cart items, subtotal, and current route
            var vm = new CartViewModel {
                List = cart.List,
                Subtotal = cart.Subtotal,
                BookGridRoute = builder.CurrentRoute
            };
            return View(vm);
        }

        // Adds a book to the shopping cart
        [HttpPost]
        public RedirectToActionResult Add(int id)
        {
            // Creates a QueryOptions object with the specified book ID
            var book = data.Get(new QueryOptions<Book> {
                Include = "BookAuthors.Author, Genre",
                Where = b => b.BookId == id
            });
            if (book == null){
                TempData["message"] = "Unable to add book to cart.";   
            }
            else {
                var dto = new BookDTO(); // Creates a new BookDTO object
                dto.Load(book);
                CartItem item = new CartItem {
                    Book = dto,
                    Quantity = 1  // default value
                };

                Cart cart = GetCart();
                cart.Add(item);
                cart.Save();

                TempData["message"] = $"{book.Title} added to cart";
            }

            var builder = new BooksGridBuilder(HttpContext.Session); // Creates a BooksGridBuilder object with the current session
            return RedirectToAction("List", "Book", builder.CurrentRoute); // Redirects to the List action method in the Book controller with the current route
        }

        // Removes a book from the shopping cart
        [HttpPost]
        public RedirectToActionResult Remove(int id)
        {
            Cart cart = GetCart(); // Gets the cart from the session
            CartItem item = cart.GetById(id); // Gets the cart item with the specified ID
            cart.Remove(item); // Removes the item from the cart
            cart.Save();

            TempData["message"] = $"{item.Book.Title} removed from cart.";
            return RedirectToAction("Index"); // Redirects to the Index action method
        }
                
        // Clears the shopping cart
        [HttpPost]
        public RedirectToActionResult Clear()
        {
            Cart cart = GetCart();
            cart.Clear();
            cart.Save();

            TempData["message"] = "Cart cleared.";
            return RedirectToAction("Index");
        }


        // Displays the shopping cart for editing
        public IActionResult Edit(int id)
        {
            Cart cart = GetCart();
            CartItem item = cart.GetById(id);
            if (item == null)
            {
                TempData["message"] = "Unable to locate cart item";
                return RedirectToAction("List");
            }
            else
            {
                return View(item); 
            }
        }

        // Updates the shopping cart
        [HttpPost]
        public RedirectToActionResult Edit(CartItem item)
        {
            Cart cart = GetCart();
            cart.Edit(item);
            cart.Save();

            TempData["message"] = $"{item.Book.Title} updated";
            return RedirectToAction("Index");
        }

        public ViewResult Checkout() => View(); // Displays the Checkout view
    }
}