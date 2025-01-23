using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected BookstoreContext context { get; set; } 
        private DbSet<T> dbset { get; set; }
        // Constructor initializes context and dbset
        public Repository(BookstoreContext ctx) {
            context = ctx;
            dbset = context.Set<T>();
        }

        private int? count;
        public int Count => count ?? dbset.Count(); // get total count

        // List method returns a collection of entities based on QueryOptions
        public virtual IEnumerable<T> List(QueryOptions<T> options) {
            IQueryable<T> query = BuildQuery(options); // build query based on options
            return query.ToList();
        }

        // Get method overloads to retrieve a single entity by id, string id, or QueryOptions
        public virtual T Get(int id) => dbset.Find(id);
        public virtual T Get(string id) => dbset.Find(id);
        public virtual T Get(QueryOptions<T> options) {
            IQueryable<T> query = BuildQuery(options);
            return query.FirstOrDefault();
        }

        // CRUD operations
        public virtual void Insert(T entity) => dbset.Add(entity);
        public virtual void Update(T entity) => dbset.Update(entity);
        public virtual void Delete(T entity) => dbset.Remove(entity);
        public virtual void Save() => context.SaveChanges();

        // BuildQuery method constructs a query based on QueryOptions
        private IQueryable<T> BuildQuery(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            // Include any related entities
            foreach (string include in options.GetIncludes()) {
                query = query.Include(include);
            }
            // Apply Where
            if (options.HasWhere) { 
                foreach (var clause in options.WhereClauses) {
                    query = query.Where(clause);
                }
                count = query.Count(); // get filtered count
            }
            // Apply OrderBy
            if (options.HasOrderBy){
                if (options.OrderByDirection == "asc")
                    query = query.OrderBy(options.OrderBy);
                else
                    query = query.OrderByDescending(options.OrderBy);
            }
            // Apply Paging
            if (options.HasPaging)
                query = query.PageBy(options.PageNumber, options.PageSize);

            return query;
        }
    }
}
