using Microsoft.EntityFrameworkCore;
using ProvaPub.Repository;
using ProvaPub.Repository.Customer;

namespace ProvaPub.Tests
{
    public class CustomerRepositoryTests
    {

        public DbContextOptions<TestDbContext> _options = new DbContextOptionsBuilder<TestDbContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Teste;Trusted_Connection=True;")
                .Options;

        [Fact]
        public async Task Can_Make_Purchase()
        {
            using var context = new TestDbContext(_options);
            var customerRepository = new CustomerRepository(context);

            var response = await customerRepository.CanPurchase(1, 1);

            Assert.True(response);
        }

        [Fact]
        public async Task No_Can_Make_Purchase()
        {
            using var context = new TestDbContext(_options);
            var customerRepository = new CustomerRepository(context);

            var response = await customerRepository.CanPurchase(1, 348723847938274);

            Assert.False(response);
        }

        [Fact]
        public async Task CustomerId_Invalid()
        {
            using var context = new TestDbContext(_options);
            var customerRepository = new CustomerRepository(context);

            var response = await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => customerRepository.CanPurchase(0, 348723847938274));

            Assert.NotNull(response);
        }

        [Fact]
        public async Task PurchaseValue_Invalid()
        {
            using var context = new TestDbContext(_options);
            var customerRepository = new CustomerRepository(context);

            var response = await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => customerRepository.CanPurchase(1, 0));

            Assert.NotNull(response);
        }
    }
}
