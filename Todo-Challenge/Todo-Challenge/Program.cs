using System.ComponentModel.Design;
using System.Text;
using Todo_Challenge;

class Program
{
    static void Main()
    {
        List<TodoItem> todoList = new List<TodoItem>();

        todoList.Add(new TodoItem("Task 1", false));
        todoList.Add(new TodoItem("Task 2", true));

        while (true)
        {
            new Menu();
            Menu.ShowOptions();

            int option = Menu.AskOption();

            Menu.OptionResponse(todoList, option);
        }
    }
}