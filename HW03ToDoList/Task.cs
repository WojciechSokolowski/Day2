using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03ToDoList
{
    internal class Task
    {
        public string Description { get; set; }
        public bool IsDone { get;set; }
        public Task(string description) 
        {
            Description = description;
            IsDone = false;
        }
    }
}
