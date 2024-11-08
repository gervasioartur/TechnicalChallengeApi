
using Microsoft.EntityFrameworkCore;
using Moq;
using TechnicalChallengeApi.Domain.Entity;
using TechnicalChallengeApi.Repository.Data;
using TechnicalChallengeApi.Repository.Repository.Contract;
using TechnicalChallengeApi.Repository.Repository.Impl;
using TechnicalChallengeApi.ServiceTests.Mocks;

namespace TechnicalChallengeApi.RepositoryTests.Impl
{
    public class GenericRepositoryImplTests
    {
        private readonly ApplicationDbContext context;
        private readonly GenericRepository<Product> repository;

        public GenericRepositoryImplTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase(databaseName: "TestDatabase")
               .Options;

            context = new ApplicationDbContext(options);
            repository = new GenericRepositoryImpl<Product>(context);
        }

        [Fact]
        public void ShouldSaveEntityToDbSet() {
            Product product = MocksFactory.ProductWithNoIdFactory();

            this.repository.Save(product);
            this.context.SaveChanges();

            var savedProduct = context.Set<Product>().Find(product.Id);

            Assert.NotNull(savedProduct);
            Assert.Equal(product.Name, savedProduct.Name);
            Assert.Equal(product.Price, savedProduct.Price);
        }
    }
}
