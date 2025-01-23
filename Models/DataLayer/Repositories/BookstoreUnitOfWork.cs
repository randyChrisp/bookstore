using System.Linq;

namespace Bookstore.Models
{
    // BookstoreUnitOfWork class serves as a unit of work for managing various reopsitories within a bookstore context
    public class BookstoreUnitOfWork : IBookstoreUnitOfWork
    {
        private BookstoreContext context { get; set; }

        /* Encapsulates the BookstoreContext and provides access to the Books, Authors, BookAuthors,
        and Genres repositories*/
        public BookstoreUnitOfWork(BookstoreContext ctx) => context = ctx;

        private Repository<Book> bookData; // Repository for Book objects

        // Books property returns the Book repository, creating it if it doesn't already exist (lazy loading)
        public Repository<Book> Books {
            get {
                if (bookData == null)
                    bookData = new Repository<Book>(context);
                return bookData;
            }
        }

        private Repository<Author> authorData; // Repository for Author objects

        // Authors property returns the Author repository, creating it if it doesn't already exist
        public Repository<Author> Authors {
            get {
                if (authorData == null)
                    authorData = new Repository<Author>(context);
                return authorData;
            }
        }

        private Repository<BookAuthor> bookauthorData; // Repository for BookAuthor objects

        // BookAuthors property returns the BookAuthor repository, creating it if it doesn't already exist
        public Repository<BookAuthor> BookAuthors {
            get {
                if (bookauthorData == null)
                    bookauthorData = new Repository<BookAuthor>(context);
                return bookauthorData;
            }
        }

        private Repository<Genre> genreData; // Repository for Genre objects

        // Genres property returns the Genre repository, creating it if it doesn't already exist
        public Repository<Genre> Genres
        {
            get {
                if (genreData == null)
                    genreData = new Repository<Genre>(context);
                return genreData;
            }
        }

        // Deletes all BookAuthor objects associated with a given Book object
        public void DeleteCurrentBookAuthors(Book book)
        {
            // Query the BookAuthors repository for all BookAuthor objects associated with the given Book object
            var currentAuthors = BookAuthors.List(new QueryOptions<BookAuthor> {
                Where = ba => ba.BookId == book.BookId
            });
            // Delete each BookAuthor object associated with the given Book object
            foreach (BookAuthor ba in currentAuthors) {
                BookAuthors.Delete(ba);
            }
        }

        // Associates a given Book object with a new set of Author objects
        public void LoadNewBookAuthors(Book book, int[] authorids)
        {
            // Create a new BookAuthor object for each Author object in the given set of Author objects
            book.BookAuthors = authorids.Select(i =>
                new BookAuthor { Book = book, AuthorId = i })
                .ToList();
        }

        public void Save() => context.SaveChanges(); // Save changes to the BookstoreContext
    }
}