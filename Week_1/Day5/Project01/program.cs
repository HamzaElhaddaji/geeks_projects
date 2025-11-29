using System;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("\n--- Personal Task Manager ---");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Update Task Status");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter task description: ");
                        string desc = Console.ReadLine();
                        manager.AddTask(new Task(title, desc));
                        break;

                    case 2:
                        manager.ViewTasks();
                        break;

                    case 3:
                        manager.ViewTasks();
                        Console.Write("Enter task number to update: ");
                        int updateNum = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new status (Pending/Completed): ");
                        string status = Console.ReadLine();
                        manager.UpdateTaskStatus(updateNum, status);
                        break;

                    case 4:
                        manager.ViewTasks();
                        Console.Write("Enter task number to delete: ");
                        int deleteNum = Convert.ToInt32(Console.ReadLine());
                        manager.DeleteTask(deleteNum);
                        break;

                    case 5:
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }
    }
}
