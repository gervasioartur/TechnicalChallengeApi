using TechnicalChallengeApi.Repository.Repository.Contract;

namespace TechnicalChallengeApi.Repository.Repository.Impl
{
    public class GenericRepositoryImpl<T> : GenericRepository<T> where T : class
    {
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

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
