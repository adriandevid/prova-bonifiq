using ProvaPub.Models;
using ProvaPub.Models.Interfaces.PayOrderFactoryMethod;
using ProvaPub.Models.Interfaces.Services;

namespace ProvaPub.Services
{
	public class OrderService : IOrderService
	{
		private readonly ICreatorFactoryMethod _creatorFactoryMethod;

		public OrderService(ICreatorFactoryMethod creatorFactoryMethod)
		{
			_creatorFactoryMethod= creatorFactoryMethod;
		}

        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			_creatorFactoryMethod
				.CreatePayOrder(paymentMethod)
				.ExecuteOperation(paymentValue, customerId);

            return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}
}
