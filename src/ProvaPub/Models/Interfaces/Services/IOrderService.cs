namespace ProvaPub.Models.Interfaces.Services
{
    public interface IOrderService
    {
        Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId);
    }
}
