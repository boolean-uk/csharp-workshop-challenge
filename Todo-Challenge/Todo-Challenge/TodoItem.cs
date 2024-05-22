using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    internal class TodoItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Completed { get; set; } = false;

        public TodoItem? NextTodoItem { get; set; } = null;

        public TodoItem(string name, TodoList todoList)
        {
            Id = todoList.NextId;
            Name = name;
            todoList.IncreaseId();
        }
    }
}
