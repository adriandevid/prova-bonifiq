namespace ProvaPub.Models.Interfaces.Services
{
    public interface ICustomerService
    {
        CustomerList ListCustomers(CustomerList filter);
        Task<bool> CanPurchase(int customerId, decimal purchaseValue);
    }
}
