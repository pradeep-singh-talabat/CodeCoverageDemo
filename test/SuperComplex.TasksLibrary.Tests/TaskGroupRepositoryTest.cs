
namespace SuperComplex.TasksLibrary.Tests
{
    using System;
    using SuperComplex.TasksLibrary.Implementation;
    using Xunit;
    public class TaskGroupRepositoryTest
    {
        [Fact]
        public void TaskGroupRepositoryTest_When_GetById_ThenThrow_NotImplementedException()
        {
            var taskGroupRepo = new TaskGroupRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskGroupRepo.GetById(1));
        }

        [Fact]
        public void TaskGroupRepositoryTest_When_GetAll_ThenThrow_NotImplementedException()
        {
            var taskGroupRepo = new TaskGroupRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskGroupRepo.GetAll());
        }

        [Fact]
        public void TaskGroupRepositoryTest_When_Create_ThenThrow_NotImplementedException()
        {
            var taskGroupRepo = new TaskGroupRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskGroupRepo.Create(new Structure.TaskGroup()));
        }

        [Fact]
        public void TaskGroupRepositoryTest_When_Update_ThenThrow_NotImplementedException()
        {
            var taskGroupRepo = new TaskGroupRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskGroupRepo.Update(new Structure.TaskGroup()));
        }

        [Fact]
        public void TaskGroupRepositoryTest_When_DeleteObject_ThenThrow_NotImplementedException()
        {
            var taskGroupRepo = new TaskGroupRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskGroupRepo.Delete(new Structure.TaskGroup()));
        }

        [Fact]
        public void TaskGroupRepositoryTest_When_DeleteId_ThenThrow_NotImplementedException()
        {
            var taskGroupRepo = new TaskGroupRepository();
            Assert.ThrowsAsync<NotImplementedException>(async () => await taskGroupRepo.Delete(1));
        }
    }
}
