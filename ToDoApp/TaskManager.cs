using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ToDoApp
{
    static class TaskManager
    {
        static ArrayList arrayList = new ArrayList();
        public static void AddTask(Task tasks)
        { arrayList.Add(tasks); }

        public static void DeleteTask(Task tasks)
        { arrayList.Remove(tasks); }

        public static int SearchForTask(Task tasks)
        { return arrayList.IndexOf(tasks); }

    }
}
