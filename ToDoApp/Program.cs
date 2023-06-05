using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tasks = new Task();
            tasks.Name = "Travel to paris";
            tasks.printTask();

            Task taskss = new Task();
            taskss.Name = "Building ahouse";
            taskss.printTask();

            Task tasksss = new Task();
            tasksss.Name = "Buy a live animal";
            tasksss.printTask();


            Task taskssss = new Task();
            taskssss.Name = "Going to Work";
            taskssss.printTask();


            TaskManager.AddTask(tasks);
            Console.WriteLine("Task Found at :" + TaskManager.SearchForTask(tasks));

            TaskManager.AddTask(taskss);
            Console.WriteLine("Task Found at :" + TaskManager.SearchForTask(taskss));

            TaskManager.AddTask(tasksss);
            Console.WriteLine("Task Found at :" + TaskManager.SearchForTask(tasksss));


            TaskManager.AddTask(taskssss);
            Console.WriteLine("Task Found at :" + TaskManager.SearchForTask(taskssss));
            TaskManager.AddTask(taskss);
            TaskManager.AddTask(taskssss);

        }
    }
}
