using ProvaPub.Models.Interfaces.PayOrderFactoryMethod;

namespace ProvaPub.Models.OrderFactoryMethod
{
    public class PayOrderPaypalConcretFactoryMethod : IOrderConcretFactoryMethod
    {
        public void ExecuteOperation(decimal paymentValue, int customerId)
        {
            //
        }
    }
}
