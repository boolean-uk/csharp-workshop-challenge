using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    class Menu
    {
        public static void ShowOptions()
        {
            Console.WriteLine("Here are the options you can select:");
            Console.WriteLine();
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - view TODO list");
            Console.WriteLine("2 - add new item into TODO list");
            Console.WriteLine("3 - remove item from TODO list\n");
        }

        public static int AskOption()
        {
            while (true)
            {
                Console.Write("Select Option: ");
                string userInput = Console.ReadLine();

                bool optionRes = int.TryParse(userInput, out int option);

                if (!optionRes)
                {
                    Console.WriteLine("\nInput was not an integer :(\n");
                    continue;
                }

                if (option < 0 || option > 3)
                {
                    Console.WriteLine($"\nOption {option} unavaliable :(\n");
                    continue;
                }

                return option;
            }
        }

        public static void OptionResponse(List<TodoItem> todoList, int option)
        {
            switch (option)
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 1:
                    ShowTodoItems(todoList);

                    AskToContinue();
                    break;

                case 2:
                    Console.Write("\nEnter name of the Todo Item: ");
                    string name = Console.ReadLine();
                    Console.Write("Is this Todo completed? y/n: ");
                    string completedInput = Console.ReadLine();

                    bool completed = false;

                    switch (completedInput)
                    {
                        case "y":
                            completed = true;
                            break;

                        case "n":
                            completed = false;
                            break;

                        default:
                            Console.WriteLine("\nInvalid option.\n");
                            AskToContinue();
                            break;
                    }

                    todoList.Add(new TodoItem(name, completed));

                    Console.WriteLine("\nTodo Item have been added to the Todo List successfully :)\n");

                    AskToContinue();
                    break;

                case 3:
                    Console.Write("\nEnter name of the Todo Item which you would lite to remove: ");
                    string nameToRemove = Console.ReadLine();

                    var itemToRemove = todoList.Single(item => item.Name == nameToRemove);

                    if (itemToRemove != null)
                    {
                        todoList.Remove(itemToRemove);

                        Console.WriteLine("\nTodo Item have been removed from the Todo List successfully :)\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nItem with name {nameToRemove} doesn't exist :(\n");
                    }

                    AskToContinue();
                    break;
            }
        }

        private static void AskToContinue()
        {
            Console.Write("Press Enter to continue: ");
            Console.ReadLine();
            Console.Clear();
        }

        private static void ShowTodoItems(List<TodoItem> todoList)
        {
            if (todoList.Count > 0)
            {
                foreach (var item in todoList)
                {
                    Console.WriteLine($"\nName: {item.Name}\n Completed: {item.Completed}\n");
                }
            }
            else
            {
                Console.WriteLine("\nYour TodoList is empty :(\n");
            }
        }

    }
}