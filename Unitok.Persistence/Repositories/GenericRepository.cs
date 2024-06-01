using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok.Application.Interfaces.Repositories;
using Unitok_progect.Domain.Common.Interfaces;
using Unitok_progect.Persistence.Contexts;

namespace Unitok.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
    where T : class, IEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Entities => _context.Set<T>();
        public DbContext Context => _context;

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>()
                .ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
