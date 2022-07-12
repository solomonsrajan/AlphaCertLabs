using CanWeFixItApplication.Contracts;
using CanWeFixItApplication.Contracts.Persistence;
using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CanWeFixItPersistence.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private SqliteConnection _connection;

        public GenericRepository(IDatabaseService databaseService)
        {
            _connection = databaseService.GetConnection();
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
