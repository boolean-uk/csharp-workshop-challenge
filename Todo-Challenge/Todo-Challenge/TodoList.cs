using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Todo_Challenge
{
    internal class TodoList : IEnumerable
    {
        public string Name;
        public TodoItem? Head { get; set; }
        public TodoItem? Tail { get; set; }
        public TodoItem? Current { get; set; }
        public int NextId { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Current = Head;

            while (Current != null)
            {
                yield return Current;
                Current = Current.NextTodoItem;
            }
        }


        // private retrieval operations executed prior to modifying the list
        private static TodoItem? GetTodoItemByName(string name, TodoList todoList)
        {
            foreach (TodoItem item in todoList)
            {
                if (item != null && item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        private static TodoItem? GetPreviousTodoItemByName(string name, TodoList todoList)
        {
            if (todoList.Head != null && todoList.Head.Name == name)
            {
                return null;
            }

            foreach (TodoItem item in todoList)
            {
                if (item != null && item.NextTodoItem != null && item.NextTodoItem.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        // is ran upon the start of the application
        public TodoList(string name)
        {
            Name = name;
            Head = null;
            Tail = null;
            Current = null;
            NextId = 1;
        }

        // methods ran when a todo item is created
        public void IncreaseNextIdByOne()
        {
            NextId++;
        }

        public bool DoesNotContainFirstTodoItem() { return Head == null; }

        // method ran after each list modification so the user may visualise the result
        public static void View(TodoList todoList)
        {
            Console.WriteLine();
            Console.WriteLine("TODO LIST");
            Console.WriteLine();

            foreach (TodoItem item in todoList)
            {
                var isComplete = item.ReadCompletionStatus();
                Console.WriteLine(item.Name + " completion status: " + isComplete);
            }
        }

        // list modification operations triggered by commands
        public static void DeleteItemWhereNameIs(string name, TodoList todoList)
        {
            var item = GetTodoItemByName(name, todoList);
            if (item == null)
            {
                Console.WriteLine($"failed to delete ${name}, no such item found");
                return;
            }
            var previousItem = GetPreviousTodoItemByName(name, todoList);
            if (previousItem == null)
            {
                todoList.Head = item.NextTodoItem;
                return;
            }
            else
            {
                // if I got this right redirecting the pointer is enough to remove 
                // any references to said item, and set it up for garbage collection (since it becomes unreachable)
                previousItem.NextTodoItem = item.NextTodoItem;
            }
        }

        public static void ToggleItemCompletionStatusWhereNameIs(string name, TodoList todoList)
        {
            var item = GetTodoItemByName(name, todoList);
            if (item == null)
            {
                Console.WriteLine($"failed to toggle completion status of {name}, no such item found");
                return;
            }
            item.Completed = !item.Completed;
        }

    }
}
