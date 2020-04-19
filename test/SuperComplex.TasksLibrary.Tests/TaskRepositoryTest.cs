
namespace SuperComplex.TasksLibrary.Tests
{
    using System;
    using SuperComplex.TasksLibrary.Implementation;
    using Xunit;
    public class TaskRepositoryTest
    {
        [Fact]
        public void TaskRepositoryTest_When_GetById_ThenThrow_NotImplementedException()
        {
            var taskRepo = new TaskRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskRepo.GetById(1));
        }

        [Fact]
        public void TaskRepositoryTest_When_GetAll_ThenThrow_NotImplementedException()
        {
            var taskRepo = new TaskRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskRepo.GetAll());
        }

        [Fact]
        public void TaskRepositoryTest_When_Create_ThenThrow_NotImplementedException()
        {
            var taskRepo = new TaskRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskRepo.Create(new Structure.Task()));
        }

        [Fact]
        public void TaskRepositoryTest_When_Update_ThenThrow_NotImplementedException()
        {
            var taskRepo = new TaskRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskRepo.Update(new Structure.Task()));
        }

        [Fact]
        public void TaskRepositoryTest_When_DeleteObject_ThenThrow_NotImplementedException()
        {
            var taskRepo = new TaskRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskRepo.Delete(new Structure.Task()));
        }

        [Fact]
        public void TaskRepositoryTest_When_DeleteId_ThenThrow_NotImplementedException()
        {
            var taskRepo = new TaskRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskRepo.Delete(1));
        }
    }
}
