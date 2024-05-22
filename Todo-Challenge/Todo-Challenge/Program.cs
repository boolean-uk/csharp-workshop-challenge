using System.Text;
using Todo_Challenge;

new Menu();
Menu.DisplayOptions();

string? line = Console.ReadLine();

while (line != "exit")
{
    if (line == null) break;
    char refNum = CommandHandler.GetCommandRefNum(line);
    switch (refNum)
    {
        case '1':
            break;
        case '2':
            break;
        case '3':
            break;
    }
    line = Console.ReadLine();
}
