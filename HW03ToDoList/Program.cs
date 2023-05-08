using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = "todo.txt";
            ToDoList toDoList = new ToDoList(filePath);

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("To-Do List");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Edit Task");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Mark Task as Done");
                Console.WriteLine("5. View Tasks");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        toDoList.AddTask(description);
                        break;
                    case "2":
                        Console.Write("Enter task index: ");
                        if (int.TryParse(Console.ReadLine(), out int editIndex))
                        {
                            Console.Write("Enter new task description: ");
                            string newDescription = Console.ReadLine();
                            toDoList.EditTask(editIndex - 1, newDescription);
                        }
                        else
                        {
                            Console.WriteLine("Invalid task index!");
                        }
                        break;
                    case "3":
                        Console.Write("Enter task index: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteIndex))
                        {
                            toDoList.DeleteTask(deleteIndex - 1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid task index!");
                        }
                        break;
                    case "4":
                        Console.Write("Enter task index: ");
                        if (int.TryParse(Console.ReadLine(), out int doneIndex))
                        {
                            toDoList.MarkTask(doneIndex - 1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid task index!");
                        }
                        break;
                    case "5":
                        toDoList.ViewTasks();
                        break;
                    case "6":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            }
        }
    }
}
