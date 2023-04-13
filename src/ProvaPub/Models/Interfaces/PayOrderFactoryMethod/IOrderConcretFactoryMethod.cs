namespace ProvaPub.Models.Interfaces.PayOrderFactoryMethod
{
    public interface IOrderConcretFactoryMethod
    {
        public void ExecuteOperation(decimal paymentValue, int customerId);
    }
}
