using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03ToDoList
{
    internal class ToDoList
    {
        private List<Task> tasks;
        private string filePath;

        public ToDoList(string filePath)
        {
            tasks = new List<Task>();
            this.filePath = filePath;
           // Load
        }

        private void SaveTasksToFile()
        {
            try
            {
                List<string> lines = new List<string>();
                foreach (Task task in tasks)
                {
                    string line = $"{task.Description},{task.IsDone}";
                    lines.Add(line);
                }
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while saving tasks to file: " + ex.Message);
            }
        }


        private void LoadTasksFromFile() {

            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string description = parts[0].Trim();
                            bool isDone = bool.Parse(parts[1].Trim());
                            Task task = new Task(description)
                            {
                                IsDone = isDone
                            };
                            tasks.Add(task);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while loading tasks from file: " + ex.Message);
                }
            }

        }

        public void AddTask(string description)
        {
            Task task = new Task(description);
            tasks.Add(task);
            Console.WriteLine("Task added");
            SaveTasksToFile();
        }

        public void EditTask(int index,  string newDescription)
        {
            if (index>= 0 && index<tasks.Count) {
                tasks[index].Description = newDescription;
                Console.WriteLine("Task Edited");
                SaveTasksToFile();
            }
            else
            { Console.WriteLine("Invalid index"); }
        }

        public void DeleteTask(int index) {

            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                Console.WriteLine("Task removed");
                SaveTasksToFile();
            }
            else
            { Console.WriteLine("Invalid index"); }
        }

        public void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No Tasks");
                return;
            }
            
            Console.WriteLine("Tasks:");

            for (int i=0; i<tasks.Count; i++)
            {
                string checkmark = tasks[i].IsDone ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {checkmark} {tasks[i].Description}");
            }

        }

        public void MarkTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsDone = true;
                Console.WriteLine("Task marked as done");
                SaveTasksToFile();
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

        }

    }
}
