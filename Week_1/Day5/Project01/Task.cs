using System;

namespace TaskManager
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime? DueDate { get; set; } 

        public Task(string title, string description, DateTime? dueDate = null)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }

        public override string ToString()
        {
            string due = DueDate.HasValue ? $" | Due: {DueDate.Value.ToShortDateString()}" : "";
            return $"Title: {Title} | Description: {Description} | Status: {Status}{due}";
        }
    }
}
