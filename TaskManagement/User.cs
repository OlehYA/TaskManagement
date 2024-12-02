using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public interface IUser
    {
        string Name { get; }
        UserRole Role { get; }
        void AssignTask(Task task);
    }

    public class User : IUser
    {
        public string Name { get; private set; }
        public UserRole Role { get; private set; }

        public User(string name, UserRole role)
        {
            Name = name;
            Role = role;
        }

        public void AssignTask(Task task)
        {
            task.Assignee = this;
            Console.WriteLine($"{Name} ({Role}) отримав завдання: {task.Title}");
        }
    }
}
