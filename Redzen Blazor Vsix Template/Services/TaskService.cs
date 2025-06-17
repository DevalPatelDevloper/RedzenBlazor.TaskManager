using Redzen_Blazor_Vsix_Template.Models;

namespace Redzen_Blazor_Vsix_Template.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private readonly Random _rand = new();

        public TaskService()
        {
            // Seed with sample tasks
            _tasks.Add(new TaskItem { Title = "Setup Database", AssignedTo = "Deval" , Status = Models.TaskStatus.Completed });
            _tasks.Add(new TaskItem { Title = "Design UI", AssignedTo = "Gaurav" });
            _tasks.Add(new TaskItem { Title = "Write Documentation", AssignedTo = "Saurav", Status = Models.TaskStatus.Completed });
            _tasks.Add(new TaskItem { Title = "Implement Authentication", AssignedTo = "Sarvesh" });
            _tasks.Add(new TaskItem { Title = "Optimize Performance", AssignedTo = "Rikesh" });
        }

        public List<TaskItem> GetTasks() => _tasks;

        public void AddTask(TaskItem task) => _tasks.Add(task);

        // Simulate real-time status changes
        public void UpdateRandomTaskStatus()
        {
            if (_tasks.Count == 0) return;

            var index = _rand.Next(_tasks.Count);
            var task = _tasks[index];

            task.Status = task.Status switch
            {
                Models.TaskStatus.Pending => Models.TaskStatus.InProgress,
                Models.TaskStatus.InProgress => Models.TaskStatus.Completed,
                _ => Models.TaskStatus.Completed
            };
        }

    }
}
