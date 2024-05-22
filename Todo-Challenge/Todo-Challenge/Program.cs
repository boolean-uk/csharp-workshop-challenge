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
    switch (refNum)
    {
        case '1':
            string itemName = CommandHandler.GetTodoItemName(line);
            new TodoItem(itemName, list);
            break;
        case '2':
            break;
        case '3':
            break;
    }
    list.ViewList();
    line = Console.ReadLine();
}
