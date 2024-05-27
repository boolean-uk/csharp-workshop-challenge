using Todo_Challenge;

class Program
{
    static void Main()
    {
        Console.WriteLine("Todo List v0.1\n");
        
        List<TodoListItem> todoList = [new("Water the plants")];

        Console.WriteLine("Type 'help' to see the list of commands.\n");

        while (true)
        {
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "help":
                    Console.WriteLine("\nThe following commands are available:\n");
                    Console.WriteLine("0 - Exit.\n1 - View Todo List.\n2 - Create a Todo Item.\n3 - Remove a Todo Item.\n4 - Mark Todo Item as complete.\n");
                    break;
                case "0": // Exit
                    Console.WriteLine("\nExiting...");
                    Environment.Exit(0);
                    break;
                case "1": // View TodoList
                    Console.WriteLine("\nTodo List:");
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
                case "2": // Create Todo
                    string? name;
                    while (true)
                    {
                        Console.Write("\nEnter Name: ");
                        name = Console.ReadLine()?.Trim();

                        if (!string.IsNullOrEmpty(name))
                        {
                            break;
                        }
                        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                    }

                    bool completed = false;
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
                    break;
                case "3": // Remove Todo
                    Console.Write("\nEnter ID: ");
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
                    break;
                default:
                    Console.WriteLine("Unknown command. Type 'help' to see the list of commands.");
                    break;
            }
        }
    }
}