using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    internal class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; } = false;

        public TodoItem? NewTodoItem { get; set; } = null;

        public TodoItem(int id, string name)
        {
            Id = id;
            Name = name;
            Completed = false;
        }
        
    }
}