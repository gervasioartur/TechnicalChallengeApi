using TechnicalChallengeApi.Domain.Entity;
using TechnicalChallengeApi.Domain.Exceptions;
using TechnicalChallengeApi.Repository.Repository.Contract;
using TechnicalChallengeApi.Service.Contract;

namespace TechnicalChallengeApi.Service.Impl
{
    public class ProductServiceImpl : ProductService
    {
        private readonly ProductRepository repository;

        public ProductServiceImpl(ProductRepository repository) 
        {
            this.repository = repository;       
        }

        public void Create(Product product)
        {
            Product savedProduct =  this.repository.FindByName(product.Name);
            if (savedProduct != null) throw new ConflictException("Product alredy registered!");
        }
    }
}
