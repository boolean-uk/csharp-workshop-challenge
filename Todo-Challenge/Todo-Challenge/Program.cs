using Todo_Challenge;

class Program
{
    static void Main()
    {

        int lastId = 1;
        List<TodoItem> itemList = [new(1, "feed the ducks", false)];

        while (true)
        {
            Console.WriteLine("Available commands:\ncreate\nview\nremove\ncomplete\n\n");

            switch (Console.ReadLine())
            {
                case "create":
                    Console.WriteLine("Enter task description:\n");
                    string? descriptionInput = Console.ReadLine();

                    string description;
                    if (descriptionInput == null)
                    {
                        description = "";
                    }
                    else
                    {
                        description = descriptionInput;
                    }

                    Console.WriteLine("Set as complete?[y/n]:\n");
                    string? completeInput = Console.ReadLine();

                    var complete = completeInput switch
                    {
                        "y" => true,
                        "n" => false,
                        _ => false,
                    };
                    TodoItem newItem = new(lastId++, description, complete);

                    itemList.Add(newItem);

                    Console.WriteLine("New item added\n\n");

                    break;

                case "view":
                    foreach (var item in itemList)
                    {
                        Console.WriteLine($"Id: {item.id}, Description: {item.description}, Complete: {item.complete}");
                    }
                    Console.WriteLine("\n\n");
                    break;

                case "remove":
                    Console.WriteLine("Enter id to remove");
                    string? idRemoveInput = Console.ReadLine();

                    if (int.TryParse(idRemoveInput, out int idRemove))
                    {
                        TodoItem foundItem = itemList.Find(item => item.id == idRemove);

                        if (foundItem != null)
                        {
                            itemList.Remove(foundItem);
                            Console.WriteLine("item removed\n");
                        }
                        else
                        {
                            Console.WriteLine($"No item with id: {idRemove} was found.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid id\n");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid command\n\n");
                    break;
            }
        }
    }
}