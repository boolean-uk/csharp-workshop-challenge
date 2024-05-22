using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> todoList = new List<ToDoItem>();

            while (true)
            {
                Console.WriteLine("Welcome to the To-Do List App!");
                Console.WriteLine("\nPlease choose an action:");
                Console.WriteLine("1. Add todo item");
                Console.WriteLine("2. Complete todo item");
                Console.WriteLine("3. See all todo items");
                Console.WriteLine("4. Delete todo item");
                Console.WriteLine("5. Exit");

            int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter task: ");
                            string description = Console.ReadLine();
                            ToDoItem newItem = new(description);
                            todoList.Add(newItem);
                            Console.WriteLine("Task added.");
                            break;
                    }
                }
            }
        }
    }
}