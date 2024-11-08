
using Bogus;
using TechnicalChallengeApi.Domain.Entity;


namespace TechnicalChallengeApi.ServiceTests.Mocks
{
    public class MocksFactory
    {
        public static Product ProductWithIdFactory()
        {
            var product = new Faker<Product>()
                 .RuleFor(p => p.Id, f => f.Database.Random.Guid())
                 .RuleFor(p => p.Name, f => f.Random.Word())
                 .RuleFor(p => p.Description, f => f.Random.Word())
                 .RuleFor(p => p.Price, f => f.Random.Number())
                 .RuleFor(p => p.Quantity, f => f.Random.Number())
                 .RuleFor(p => p.Active, f => true)
                 .RuleFor(p => p.CreatedAt, f => f.Date.Past());

            return product.Generate();
        }

        public static Product ProductWithNoIdFactory()
        {
            var product = new Faker<Product>()
                 .RuleFor(p => p.Name, f => f.Random.Word())
                 .RuleFor(p => p.Description, f => f.Random.Word())
                 .RuleFor(p => p.Price, f => f.Random.Number())
                 .RuleFor(p => p.Quantity, f => f.Random.Number())
                 .RuleFor(p => p.Active, f => false)
                 .RuleFor(p => p.CreatedAt, f => f.Date.Past());

            return product.Generate();
        }

        public static Product ProductWithIdFromProductFactory(Product planet)
        {
            planet.Id = new Guid();
            return planet;
        }
    }
}