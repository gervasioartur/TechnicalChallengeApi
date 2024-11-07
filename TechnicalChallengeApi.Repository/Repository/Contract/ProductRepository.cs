

using TechnicalChallengeApi.Domain.Entity;

namespace TechnicalChallengeApi.Repository.Repository.Contract
{
    public interface ProductRepository : GenericRepository<Product>
    {
        Product FindByName(string name);
    }
}
