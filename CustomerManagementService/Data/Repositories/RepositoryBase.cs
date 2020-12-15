using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementService.Data.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext RepositoryContext { get; set; }

        protected RepositoryBase(AppDbContext dbContext)
        {
            RepositoryContext = dbContext;
        }

        public IQueryable<T> FindAll()
        {
            return RepositoryContext
                .Set<T>()
                .AsNoTracking();
        }
    }

    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
    }
}
