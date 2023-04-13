using ProvaPub.Models.Interfaces.PayOrderFactoryMethod;

namespace ProvaPub.Models.OrderFactoryMethod
{
    public class CreatePayOrderFactoryMethod : ICreatorFactoryMethod
    {
        public IOrderConcretFactoryMethod CreatePayOrder(string paymentMethod)
        {   
            if (paymentMethod == "pix")
            {
                return new PayOrderPixConcretFactoryMethod();
            }
            else if (paymentMethod == "creditcard")
            {
                return new PayOrderCreditCardConcretFactoryMethod();
            }
            else if (paymentMethod == "paypal")
            {
                return new PayOrderPaypalConcretFactoryMethod();
            }

            throw new Exception("paymentMethod not exists");
        }
    }
}
