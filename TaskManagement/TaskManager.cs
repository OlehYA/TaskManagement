using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public abstract class TaskManager
    {
        protected Task[] Tasks = new Task[0];

        public abstract void AddTask(Task task);

        public void RemoveTask(Task task)
        {
            Tasks = Tasks.Where(t=> t != task).ToArray();
        }

        public void RemoveTask(int taskId) 
        {
            Tasks = Tasks.Where(t => t.Id !=taskId).ToArray();
        }

        public void RemoveTask(string title)
        {
            Tasks = Tasks.Where(t => t.Title != title).ToArray();
        }

        public Task[] GetActiveTasks()
        {
            return Tasks.Where(t => t.Status == TaskStatus.New || t.Status == TaskStatus.InProgress).ToArray();
        }

        public Task[] GetTasksByAssignee(IUser user)
        {
            return Tasks.Where(t => t.Assignee == user).ToArray();
        }
    }
}
