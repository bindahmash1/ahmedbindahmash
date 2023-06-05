using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Task
    {
        public string Name
        {
            get;
            set;
        }
        public void printTask()
        { Console.WriteLine("Name  =" + Name); }

    }
}
