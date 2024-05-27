using Todo_Challenge;

class Program
{
    static void Main()
    {
        Console.WriteLine("Todo List v0.1\n");
        
        List<TodoListItem> todoList = [new(0, "Water the plants")];

        Console.WriteLine("Type 'help' to see the list of commands.\n");

        while (true)
        {
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "help":
                    Console.WriteLine("\nThe following commands are available:\n");
                    Console.WriteLine("0 - Exit.\n1 - View Todo List.\n2 - Create a Todo Item.\n3 - Remove a Todo Item.\n4 - Mark Todo Item as complete.\n\n");
                    break;
                case "0":
                    Console.WriteLine("\nExiting...");
                    Environment.Exit(0);
                    break;
                case "1":
                    if (todoList.Count < 1)
                    {
                        Console.WriteLine("Todo List is empty.\n");
                        break;
                    }

                    foreach (var todo in todoList)
                    {
                        Console.WriteLine($"\nID: {todo.Id} \nTodo: {todo.Name} \nCompleted: {todo.Completed}\n");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown command. Type 'help' to see the list of commands.");
                    break;
            }
        }
    }
}