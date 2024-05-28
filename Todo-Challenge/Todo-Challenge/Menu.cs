using System;
using System.Collections.Generic;

namespace Todo_Challenge
{
    internal class Menu
    {
        private List<TodoListItem> todoList = new List<TodoListItem>();

        private void ShowCommands()
        {
            Console.WriteLine("\nThe following commands are available:\n");
            Console.WriteLine("0 - Exit.\n1 - View Todo List.\n2 - Create a Todo Item.\n3 - Remove a Todo Item.\n4 - Mark Todo Item as complete.\n");
        }

        private void ViewTodoList()
        {
            Console.WriteLine("\nTodo List:");
            if (todoList.Count < 1)
            {
                Console.WriteLine("\nTodo List is empty.\n");
            }

            foreach (var todo in todoList)
            {
                Console.WriteLine($"\nID: {todo.Id} \nTodo: {todo.Name} \nCompleted: {todo.Completed}\n");
            }
        }

        private void CreateTodoItem()
        {
            string? name;
            while (true)
            {
                Console.Write("\nEnter name of Todo to create: ");
                name = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    break;
                }
                Console.WriteLine("Name cannot be empty. Please enter a valid name.");
            }

            bool completed;
            while (true)
            {
                Console.Write("Is it completed? (y/n): ");
                string? completedInput = Console.ReadLine()?.Trim().ToLower();

                if (completedInput == "y")
                {
                    completed = true;
                    break;
                }
                else if (completedInput == "n")
                {
                    completed = false;
                    break;
                }

                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }

            TodoListItem newTodo = new(name, completed);
            todoList.Add(newTodo);

            Console.WriteLine($"\nCreated New Todo: \n\nID: {newTodo.Id} \nTodo: {newTodo.Name} \nCompleted: {newTodo.Completed}\n");
        }

        private void RemoveTodoItem()
        {
            Console.Write("\nEnter ID of Todo to remove: ");
            string? idInput = Console.ReadLine()?.Trim();

            if (int.TryParse(idInput, out int id))
            {
                TodoListItem? itemToRemove = todoList.Find(todo => todo.Id == id);

                if (itemToRemove != null)
                {
                    todoList.Remove(itemToRemove);
                    Console.WriteLine($"Removed Todo with ID: {id}\n");
                }
                else
                {
                    Console.WriteLine($"Todo Item with ID: {id} not found.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.\n");
            }
        }

        private void MarkTodoItemAsComplete()
        {
            int id;
            while (true)
            {
                Console.Write("Enter ID of the Todo to complete: ");
                string? idInput = Console.ReadLine()?.Trim();
                if (int.TryParse(idInput, out id))
                {
                    break;
                }
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }

            TodoListItem? todoToUpdate = todoList.Find(todo => todo.Id == id);

            if (todoToUpdate == null)
            {
                Console.WriteLine($"Todo Item with ID: {id} not found.\n");
                return;
            }

            while (true)
            {
                Console.Write("Mark as completed? (y/n): ");
                string? completedInput = Console.ReadLine()?.Trim().ToLower();

                if (completedInput == "y")
                {
                    todoToUpdate.Completed = true;
                    break;
                }
                else if (completedInput == "n")
                {
                    todoToUpdate.Completed = false;
                    break;
                }
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }

            Console.WriteLine($"\nUpdated Todo: \n\nID: {todoToUpdate.Id} \nTodo: {todoToUpdate.Name} \nCompleted: {todoToUpdate.Completed}\n");
        }

        public void HandleResponse()
        {
            while (true)
            { 
                string? command = Console.ReadLine()?.Trim();

                switch (command) 
                {
                    case "help":
                        ShowCommands();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        ViewTodoList();
                        break;

                    case "2":
                        CreateTodoItem();
                        break;

                    case "3":
                        RemoveTodoItem();
                        break;

                    case "4":
                        MarkTodoItemAsComplete();
                        break;

                    default:
                        Console.WriteLine("Unknown command. Type 'help' to see the list of commands.\n");
                        break;
                }
            }
        }
    }
}
