using ProvaPub.Models;
using ProvaPub.Models.Interfaces.Repositories;
using ProvaPub.Models.Interfaces.Services;

namespace ProvaPub.Services
{
    public class ProductService : IProductService
	{
        private readonly IProductRepository _repository;

		public ProductService(IProductRepository repository)
		{
			_repository= repository;
		}

		public ProductList ListProducts(ProductList filter)
		{
			filter.Datas = _repository.getPaginationList(filter.Page, filter.TotalCount);
            return filter;
		}

	}
}
