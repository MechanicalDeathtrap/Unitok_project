

using Unitok.Application.Interfaces.Repositories;
using Unitok_progect.Domain.Common;

namespace Unitok_progect.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
		IGenericRepository<T> Repository<T>()
		where T : BaseAuditableEntity;

		Task<int> Save(CancellationToken cancellationToken);

		Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

		Task Rollback();
	}
}
