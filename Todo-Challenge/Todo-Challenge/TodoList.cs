using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Console.WriteLine();
            Console.WriteLine("TODO LIST");
            Console.WriteLine();
            var item = FirstTodoItem;
            while (item != null)
            {
                var isComplete = item.ReadCompletionStatus();
                Console.WriteLine(item.Name + " completion status: " + isComplete);
                item = item.NextTodoItem;

            }
        }

        private TodoItem GetTodoItemByName(string name)
        {
            var item = FirstTodoItem;
            while (item != null && item.Name != name)
            {
                item = item.NextTodoItem;
                continue;
            }
            return item;
        }

        private TodoItem? GetPreviousTodoItemByName(string name)
        {
            var item = FirstTodoItem;
            if (FirstTodoItem != null &&  FirstTodoItem.Name == name)
            {
                return null;
            }

            while (item != null && item.NextTodoItem != null && item.NextTodoItem.Name != name)
            {
                item = item.NextTodoItem;
                continue;
            }
            return item;
        }

        public void DeleteItemWhereNameIs(string name)
        {
            var item = GetTodoItemByName(name);
            var previousItem = GetPreviousTodoItemByName(name);
            if (previousItem == null)
            {
                FirstTodoItem = item.NextTodoItem;
                return;
            }
            else
            {
                // if I got this right redirecting the pointer is enough to remove 
                // any references to said item, and set it up for garbage collection (since it becomes unreachable)
                previousItem.NextTodoItem = item.NextTodoItem;
            }
        }
        public void ToggleItemCompletionStatusWhereNameIs(string name)
        {
            var item = GetTodoItemByName(name);
            item.Completed = !item.Completed;
        }
    }
}
