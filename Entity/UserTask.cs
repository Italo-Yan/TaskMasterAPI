using static TaskMasterAPI.Enum.UserTaskEnum;

namespace TaskMasterAPI.Entity
{
    public class UserTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public TaskPriorityEnum Priority { get; set; }
        public TaskStatusEnum Status { get; set; }
    
    
        public UserTask()
        {
            Id = Guid.NewGuid();
            StartDate = DateTime.UtcNow;
            Status = TaskStatusEnum.Pending;
        }
    }
}
