using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CanWeFixItApplication.Contracts.Persistence
{
    /// <summary>
    /// Implemented relative to a class specified in T
    /// Has common actions performed on database
    /// Anyone of the entity objects can be used to access database related functionalities through this interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        //Get record by id
        Task<T> GetAsync(int id);

        //Get all records as readonly
        Task<IEnumerable<T>> GetAllAsync();

        //Add record
        Task<T> AddAsync(T entity);

        //Update record
        Task UpdateAsync(T entity);

        //Delete record
        Task DeleteAsync(T entity);
    }
}
