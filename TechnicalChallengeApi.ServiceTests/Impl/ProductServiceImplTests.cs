using Moq;
using TechnicalChallengeApi.Domain.Entity;
using TechnicalChallengeApi.Domain.Exceptions;
using TechnicalChallengeApi.Repository.Repository.Contract;
using TechnicalChallengeApi.Service.Contract;
using TechnicalChallengeApi.Service.Impl;
using TechnicalChallengeApi.ServiceTests.Mocks;

namespace TechnicalChallengeApi.ServiceTests.Impl
{
    public class ProductServiceImplTests
    {
        private readonly Mock<ProductRepository> repository;
        private readonly ProductService sut;

        public ProductServiceImplTests() { 
            repository = new Mock<ProductRepository>();
            sut =  new ProductServiceImpl(this.repository.Object);
        }

        [Fact]
        public void ShouldThrowConflictExceptionIfProductIsAlreadyRegistered() {
            Product product = MocksFactory.ProductWithIdFactory();

            this.repository.Setup(repo => repo.FindByName(product.Name)).Returns(product);

            var exception = Assert.Throws<ConflictException>(() => this.sut.Create(product));

            Assert.Equal("Product alredy registered!", exception.Message);
            repository.Verify(repo => repo.FindByName(product.Name), Times.Once);
        }
    }
}
