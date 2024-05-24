using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    internal class TodoItem
    {
        public string Name { get; set; }
        public bool Completed { get; set; } = false;

        public TodoItem(string name, bool completed)
        {
            Name = name;
            Completed = completed;
        }
        
    }
}