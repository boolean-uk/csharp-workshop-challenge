using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    internal class TodoList
    {
        public string Name;
        public TodoItem? FirstTodoItem { get; set; } = null;

        public TodoItem? LastTodoItem { get; set; } = null;
        public int NextId { get; set; } = 1;

        public TodoList(string name)
        {
            Name = name;
        }

        public void IncreaseId()
        {
            NextId++;
        }

        public bool DoesNotContainFirstTodoItem() { return FirstTodoItem == null; }
        public void ViewList()
        {
            var item = FirstTodoItem;
            while(item != null)
            {
                var isComplete = item.ReadCompletionStatus();
                Console.WriteLine(item.Name + " completion status: " + isComplete);
                item = item.NextTodoItem;

            }
        }
    }
}
