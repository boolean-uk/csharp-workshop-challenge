using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    class Menu
    {
        public static void ShowOptions()
        {
            Console.WriteLine("Here are the options you can select:");
            Console.WriteLine();
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - view TODO list");
            Console.WriteLine("2 - add new item into TODO list");
            Console.WriteLine("3 - remove item from TODO list\n");
        }
    }
}