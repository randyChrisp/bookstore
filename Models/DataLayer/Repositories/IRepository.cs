using System.Collections.Generic;

namespace Bookstore.Models
{
    // IRepository interface defines a contract for a generic repository
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options); /* Returns a collection of entities based on QueryOptions, 
                                                    allowing for flexible queries*/

        int Count { get; }

        // Get method overloads to retrieve a single entity by id, string id, or QueryOptions
        T Get(QueryOptions<T> options);
        T Get(int id);
        T Get(string id);

        // CRUD operations
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Save();
    }
}
