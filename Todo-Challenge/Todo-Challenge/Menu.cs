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
                    if (todoList.Count > 0)
                    {
                        foreach (var item in todoList)
                        {
                            Console.WriteLine($"\nName: {item.Name}\n Completed: {item.Completed}\n");
                        }

                        AskToContinue();
                    }
                    else
                    {
                        Console.WriteLine("\nYour TodoList is empty :(\n");
                        AskToContinue();
                    }

                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        private static void AskToContinue()
        {
            Console.Write("Press Enter to continue: ");
            Console.ReadLine();
            Console.Clear();
        }

    }
}