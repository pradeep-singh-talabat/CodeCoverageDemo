namespace SuperComplex.TasksLibrary.Tests
{
    using System;
    using SuperComplex.TasksLibrary.Implementation;
    using Xunit;
    public class UserRepositoryTest
    {
        [Fact]
        public void UserRepositoryTest_When_GetById_ThenThrow_NotImplementedException()
        {
            var userRepo = new UserRepository();
            Assert.ThrowsAsync<NotImplementedException>(async() => await userRepo.GetById(Guid.Empty));
        }

        [Fact]
        public void UserRepositoryTest_When_GetAll_ThenThrow_NotImplementedException()
        {
            var userRepo = new UserRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await userRepo.GetAll());
        }

        [Fact]
        public void UserRepositoryTest_When_Create_ThenThrow_NotImplementedException()
        {
            var userRepo = new UserRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await userRepo.Create(new Structure.User()));
        }

        [Fact]
        public void UserRepositoryTest_When_Update_ThenThrow_NotImplementedException()
        {
            var userRepo = new UserRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await userRepo.Update(new Structure.User()));
        }

        [Fact]
        public void UserRepositoryTest_When_DeleteObject_ThenThrow_NotImplementedException()
        {
            var userRepo = new UserRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await userRepo.Delete(new Structure.User()));
        }

        [Fact]
        public void UserRepositoryTest_When_DeleteId_ThenThrow_NotImplementedException()
        {
            var userRepo = new UserRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await userRepo.Delete(Guid.Empty));
        }
    }
}
