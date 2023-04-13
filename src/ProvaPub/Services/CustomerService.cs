using ProvaPub.Models;
using ProvaPub.Models.Interfaces.Repositories;
using ProvaPub.Models.Interfaces.Services;

namespace ProvaPub.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public CustomerList ListCustomers(CustomerList filter)
        {
            filter.Datas = _repository.getPaginationList(filter.Page, filter.TotalCount);
            return filter;
        }

        public async Task<bool> CanPurchase(int customerId, decimal purchaseValue)
         => await _repository.CanPurchase(customerId, purchaseValue);

    }
}
