using System.ComponentModel.Design;
using System.Text;
using Todo_Challenge;

class Program
{
    static void Main()
    {

        while(true)
        {
            new Menu();
            Menu.ShowOptions();

            int option = Menu.AskOption();

            Console.ReadLine();
        }
    }
}