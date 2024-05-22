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

            int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter todo: ");
                            string description = Console.ReadLine();
                            ToDoItem newItem = new(description);
                            todoList.Add(newItem);
                            Console.WriteLine("Todo added.");
                            break;

                        case 2:
                            Console.Write("Enter todo number to complete: ");
                            if (int.TryParse(Console.ReadLine(), out int todoIndex) && todoIndex > 0 && todoIndex <= todoList.Count)
                            {
                                todoList[todoIndex - 1].IsCompleted = true;
                                Console.WriteLine("Todo completed.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid todo number.");
                            }
                            break;

                        case 3:
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

                        case 4:
                            Console.Write("Enter todo number to delete: ");
                            if (int.TryParse(Console.ReadLine(), out int todoremoveIndex) && todoremoveIndex > 0 && todoremoveIndex <= todoList.Count)
                            {
                                todoList.RemoveAt(todoremoveIndex - 1);
                                Console.WriteLine("Todo deleted.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid todo number.");
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