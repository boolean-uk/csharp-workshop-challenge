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
                            Console.Write("Enter task: ");
                            string description = Console.ReadLine();
                            ToDoItem newItem = new(description);
                            todoList.Add(newItem);
                            Console.WriteLine("Task added.");
                            break;

                        case 2:
                            Console.Write("Enter task number to complete: ");
                            if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= todoList.Count)
                            {
                                todoList[taskIndex - 1].IsCompleted = true;
                                Console.WriteLine("Task completed.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid task number.");
                            }
                            break;

                        case 3:
                            if (todoList.Count == 0)
                            {
                                Console.WriteLine("\nYour to-do list is empty.\n");
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
                            Console.WriteLine("Section 4 not completed");
                            break;

                        case 5:
                            Console.WriteLine("Section 5 not completed");
                            break;
                    }
                }
            }
        }
    }
}