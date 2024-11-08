namespace TechnicalChallengeApi.Repository.Repository.Contract
{
    public interface  GenericRepository<T> where T : class
    {
        T FindById(Guid id);
        IEnumerable<T> GetAll();
        Task Save(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
