
namespace SuperComplex.TasksLibrary.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SuperComplex.TasksLibrary.Structure;
    public class UserRepository : Contract.IUserRepository
    {
        public System.Threading.Tasks.Task Create(User @object)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(Guid key)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(User @object)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(Guid key)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Update(User @object)
        {
            throw new NotImplementedException();
        }
    }
}
