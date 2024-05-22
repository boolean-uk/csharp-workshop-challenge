using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    class Menu
    {
        public static void DisplayOptions()
        {
            Console.WriteLine("Your current todo list is:");
            Console.WriteLine();
            Console.WriteLine("To edit it, use the options below");
            Console.WriteLine();
            Console.WriteLine("OPTIONS");
            Console.WriteLine("input:         action:");
            Console.WriteLine("1 <todo name>  create a new todo");
            Console.WriteLine("2 <todo name>  delete a todo");
            Console.WriteLine("3 <todo name>  set a todo's completion status to true or false");
        }
    }
}
