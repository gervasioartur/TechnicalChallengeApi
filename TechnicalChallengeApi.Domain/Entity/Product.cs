
namespace TechnicalChallengeApi.Domain.Entity
{
    public class Product
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
