using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class TaskManagerSingleton : TaskManager
    {
        private static TaskManagerSingleton _instance;

        private TaskManagerSingleton() { }

        public static TaskManagerSingleton GetInstance()
        {
            return _instance ??= new TaskManagerSingleton();
        }

        public override void AddTask(Task task)
        {
            Array.Resize(ref Tasks, Tasks.Length + 1);
            Tasks[^1] = task;
        }
    }
}
