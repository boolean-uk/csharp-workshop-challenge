using System.Text;
using Todo_Challenge;

new Menu();
Menu.DisplayOptions();

string? line = Console.ReadLine();

var list = new TodoList("Todo list");

while (line != "exit")
{
    if (line == null) break;
    char refNum = CommandHandler.GetCommandRefNum(line);
    string itemName = CommandHandler.GetTodoItemName(line);
    switch (refNum)
    {
        case '1':
            new TodoItem(itemName, list);
            break;
        case '2':
            list.DeleteItemWhereNameIs(itemName);
            break;
        case '3':
            break;
    }
    list.ViewList();
    line = Console.ReadLine();
}
