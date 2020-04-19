namespace SuperComplex.TasksLibrary.Structure
{
    public class TaskGroup
    {
        public int TaskGroupId { get; set; }
        public string TaskGroupName { get; set; }
        public string Objective { get; set; }
        public User CreatedBy { get; set; }
    }
}
