
namespace SuperComplex.TasksLibrary.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SuperComplex.TasksLibrary.Structure;
    public class TaskGroupRepository : Contract.ITaskGroupRepository
    {
        public System.Threading.Tasks.Task Create(TaskGroup @object)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(int key)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(TaskGroup @object)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskGroup>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TaskGroup> GetById(int key)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Update(TaskGroup @object)
        {
            throw new NotImplementedException();
        }
    }
}
