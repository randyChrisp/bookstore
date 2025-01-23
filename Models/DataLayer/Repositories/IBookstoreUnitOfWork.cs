namespace Bookstore.Models
{
    // Defines a contract for a unit of work in a bookstore context
    public interface IBookstoreUnitOfWork
    {
        // Properties to access each repository
        Repository<Book> Books { get; }
        Repository<Author> Authors { get; }
        Repository<BookAuthor> BookAuthors { get; }
        Repository<Genre> Genres { get; }

        // Operations that can be performed on the repositories
        void DeleteCurrentBookAuthors(Book book);
        void LoadNewBookAuthors(Book book, int[] authorids);
        void Save();
    }
}
