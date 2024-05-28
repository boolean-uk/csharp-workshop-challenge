using System;
using Todo_Challenge;

class Program
{
    static void Main()
    {
        Console.WriteLine("Todo List v0.1\n");
        Console.WriteLine("Type 'help' to see the list of commands.\n");

        while (true)
        {
            var todoList = new Menu();

            todoList.HandleResponse();
        }
        
    }
}