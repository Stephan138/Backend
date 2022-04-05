using System.Collections.Generic;

namespace ScrumBoard.Body
{
    public interface ColumnI
    {
        public string Title { get; set; }

        public void Add_task(TaskI task);
        public void Delete_task_by_title(string title);
        public TaskI Find_task_by_title(string title);
        public IReadOnlyCollection<TaskI> Find_tasks();
    }
}