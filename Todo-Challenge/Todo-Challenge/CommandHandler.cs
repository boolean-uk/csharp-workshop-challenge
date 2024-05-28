using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Challenge
{
    internal class CommandHandler
    {
        public static char GetCommandRefNum(string line)
        {
            return line[0];
        }
        public static string GetTodoItemName(string line)
        {
            string lineWithoutRefNum = line.Remove(0, 1);
            string name = lineWithoutRefNum.Trim();
            return name;
        }
    }
}
