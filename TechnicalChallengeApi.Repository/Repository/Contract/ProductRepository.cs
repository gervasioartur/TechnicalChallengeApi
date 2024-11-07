

using TechnicalChallengeApi.Domain.Entity;

namespace TechnicalChallengeApi.Repository.Repository.Contract
{
    public interface ProductRepository
    {
        Product Create(Product product);
        Product FindByName(string name);
    }
}
