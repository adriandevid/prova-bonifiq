using Moq;
using ProvaPub.Models.Interfaces.Repositories;

namespace ProvaPub.Tests.Mocks
{
    public class CustomRepositoryMocks
    {
        public Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();

        public CustomRepositoryMocks() {
            mock.Setup(x => x.CanPurchase(1, 1)).Returns(Task.Run(() => true));
            mock.Setup(x => x.CanPurchase(1, 2)).Returns(Task.Run(() => false));
        }
    }
}
