
namespace SuperComplex.TasksLibrary.Structure
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public TaskGroup Group { get; set; }
        public User Owner { get; set; }
        public User AssignedTo { get; set; }
    }
}
