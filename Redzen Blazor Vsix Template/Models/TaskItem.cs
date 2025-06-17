namespace Redzen_Blazor_Vsix_Template.Models
{
        public enum TaskStatus { Pending, InProgress, Completed }

        public class TaskItem
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Title { get; set; } = string.Empty;
            public string AssignedTo { get; set; } = string.Empty;
            public TaskStatus Status { get; set; } = TaskStatus.Pending;
        }
}
