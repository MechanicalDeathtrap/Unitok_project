using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Common.Interfaces;

namespace Unitok.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T>
    where T : class //, IEntity
    {
		/*        IQueryable<T> Entities { get; }
				DbContext Context { get; }

				Task<T> GetByIdAsync(int id);
				Task<List<T>> GetAllAsync();
				Task<T> AddAsync(T entity);
				Task UpdateAsync(T entity);
				Task DeleteAsync(T entity);*/
		//IQueryable<T> Entities { get; }
		//DbContext Context { get; }
		Task<List<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
	}
}
