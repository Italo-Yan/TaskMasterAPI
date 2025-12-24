using static TaskMasterAPI.Enum.UserTaskEnum;

namespace TaskMasterAPI.Model
{
    public class UpdateUserTask
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public TaskPriorityEnum Priority { get; set; }
        public TaskStatusEnum Status { get; set; }
    }
}
