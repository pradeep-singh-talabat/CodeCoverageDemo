
namespace SuperComplex.TasksLibrary.Contract
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IRepository<TObject,TKey> where TKey: struct
    {
        Task<TObject> GetById(TKey key);
        Task<IEnumerable<TObject>> GetAll();
        Task Create(TObject @object);
        Task Update(TObject @object);
        Task Delete(TKey key);
        Task Delete(TObject @object);
    }
}
