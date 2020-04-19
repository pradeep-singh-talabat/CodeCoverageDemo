
namespace SuperComplex.TasksLibrary.Implementation
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class TaskRepository : Contract.ITaskRepository
    {
        public System.Threading.Tasks.Task Create(Structure.Task @object)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(int key)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(Structure.Task @object)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Structure.Task>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Structure.Task> GetById(int key)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task Update(Structure.Task @object)
        {
            throw new System.NotImplementedException();
        }
    }
}
