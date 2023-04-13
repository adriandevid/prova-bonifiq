namespace ProvaPub.Models.Interfaces.PayOrderFactoryMethod
{
    public interface ICreatorFactoryMethod
    {
        public IOrderConcretFactoryMethod CreatePayOrder(string paymentMethod);
    }
}
