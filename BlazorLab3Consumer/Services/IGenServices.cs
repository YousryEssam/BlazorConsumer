namespace BlazorLab3Consumer.Models
{
    public interface IGenServices<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task Insert(T obj);
        Task Update(int id, T obj);
        Task Delete(int id);
    }
}
