namespace ProvaPub.Models.Interfaces.Repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Task<bool> CanPurchase(int customerId, decimal purchaseValue);
    }
}
