using ProvaPub.Models.Interfaces.Repositories;
using ProvaPub.Repository.Base;
using Models = ProvaPub.Models;

namespace ProvaPub.Repository.Product
{
    public class ProductRepository : BaseRepository<Models.Product>, IProductRepository
    {
        public ProductRepository(TestDbContext applicationContext) : base(applicationContext)
        {
        }
    }
}
