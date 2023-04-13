using Microsoft.EntityFrameworkCore;
using ProvaPub.Models.Interfaces.Repositories;

namespace ProvaPub.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly TestDbContext _applicationContext;
        public DbSet<TEntity> _dataSet;

        public BaseRepository(TestDbContext applicationContext)
        {
            _applicationContext = applicationContext;
            _dataSet = applicationContext.Set<TEntity>();
        }

        public List<TEntity> getPaginationList(int page, int totalPage)
        {
            return _dataSet.Skip((page == 0 || page == 1 ? 0 : page - 1) * totalPage).Take(totalPage).ToList();
        }
    }
}
