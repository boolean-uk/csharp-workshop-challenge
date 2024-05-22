using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> todoList = new List<ToDoItem>();

            Console.WriteLine("Welcome to the To-Do List App!");
            while (true)
            {
                Console.WriteLine("\nPlease choose an action:");
                Console.WriteLine("1. Add todo item");
                Console.WriteLine("2. Complete todo item");
                Console.WriteLine("3. See all todo items");
                Console.WriteLine("4. Delete todo item");
                Console.WriteLine("5. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1: // Add a todo item
                            Console.Write("\nEnter todo: \n");
                            string description = Console.ReadLine();
                            ToDoItem newItem = new(description);
                            todoList.Add(newItem);
                            Console.WriteLine($"\nTodo item: '{description}' added.\n");
                            break;

                        case 2: // Complete specific todo items
                            Console.Write("\nEnter todo number to complete: \n");
                            if (int.TryParse(Console.ReadLine(), out int todoIndex) && todoIndex > 0 && todoIndex <= todoList.Count)
                            {
                                todoList[todoIndex - 1].IsCompleted = true;
                                Console.WriteLine($"\nTodo item '{todoList[todoIndex - 1].Description}' completed.\n");
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid todo number.\n");
                            }
                            break;

                        case 3: // View all todo items
                            if (todoList.Count == 0)
                            {
                                Console.WriteLine("\nYour todo list is empty.\n");
                            }
                            else
                            {
                                Console.WriteLine("\nYour To-Do List:");
                                for (int i = 0; i < todoList.Count; i++)
                                {
                                    string status = todoList[i].IsCompleted ? "[X]" : "[ ]"; 
                                    Console.WriteLine($"{i + 1}. {status} {todoList[i].Description}");
                                }
                            }
                            break;

                        case 4: // Delete a todo item
                            Console.Write("\nEnter todo number to delete: \n");
                            if (int.TryParse(Console.ReadLine(), out int todoremoveIndex) && todoremoveIndex > 0 && todoremoveIndex <= todoList.Count)
                            {
                                todoList.RemoveAt(todoremoveIndex - 1);
                                Console.WriteLine($"\nTodo number {todoremoveIndex} deleted.\n");
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid todo number.\n");
                            }
                            break;

                        case 5:
                            return;
                    }
                }
            }
        }
    }
}