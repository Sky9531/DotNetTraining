using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2.Repository
{
    public interface IMovieRepository<T> where T : class
    {
        IEnumerable<T> GetAll();  // Retrieve all movies
        T GetById(object id);     // Retrieve a specific movie by ID
        void Insert(T entity);    // Insert a new movie
        void Update(T entity);    // Update an existing movie
        void Delete(object id);   // Delete a movie by ID
        void Save();              // Save changes to the database
    }
}
