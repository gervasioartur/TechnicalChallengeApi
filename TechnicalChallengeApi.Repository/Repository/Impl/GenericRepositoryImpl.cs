using TechnicalChallengeApi.Repository.Data;
using TechnicalChallengeApi.Repository.Repository.Contract;

namespace TechnicalChallengeApi.Repository.Repository.Impl
{
    public class GenericRepositoryImpl<T> : GenericRepository<T> where T : class
    {
        private ApplicationDbContext dbContext;

        public GenericRepositoryImpl(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public T FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Save(T entity)
        {
           await dbContext.Set<T>().AddAsync(entity);
           await dbContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
