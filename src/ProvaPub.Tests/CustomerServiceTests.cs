using ProvaPub.Services;
using ProvaPub.Tests.Mocks;

namespace ProvaPub.Tests
{
    public class CustomerServiceTests
    {

        [Fact]
        public async Task Can_Make_Purchase()
        {
            var mockCustomerRepository = new CustomRepositoryMocks();
            var service = new CustomerService(mockCustomerRepository.mock.Object);
            var response = await service.CanPurchase(1, 2);

            Assert.False(response);
        }

        [Fact]
        public async Task No_Can_Make_Purchase()
        {
            var mockCustomerRepository = new CustomRepositoryMocks();
            var service = new CustomerService(mockCustomerRepository.mock.Object);
            var response = await service.CanPurchase(1, 1);

            Assert.True(response);
        }
    }
}