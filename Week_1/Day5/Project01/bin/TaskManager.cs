using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManager
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        public void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("\n--- Task List ---");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        public void UpdateTaskStatus(int taskNumber, string newStatus)
        {
            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            tasks[taskNumber - 1].UpdateStatus(newStatus);
            Console.WriteLine("Task status updated successfully!");
        }

        public void DeleteTask(int taskNumber)
        {
            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            Console.WriteLine($"Are you sure you want to delete '{tasks[taskNumber - 1].Title}'? (y/n)");
            string confirm = Console.ReadLine();
            if (confirm.ToLower() == "y")
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task deleted.");
            }
            else
            {
                Console.WriteLine("Deletion cancelled.");
            }
        }

        // Optional: Search tasks
        public void SearchTasks(string keyword)
        {
            var results = tasks.Where(t => t.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) || 
                                    t.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Count == 0)
            {
                Console.WriteLine("No tasks found with that keyword.");
            }
            else
            {
                foreach (var task in results)
                    Console.WriteLine(task);
            }
        }
    }
}
