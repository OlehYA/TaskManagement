using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class UserManagerSingleton
    {
        private static UserManagerSingleton _instance;
        private IUser[] Users = new IUser[0];

        private UserManagerSingleton() { }

        public static UserManagerSingleton GetInstance()
        {
            return _instance ??= new UserManagerSingleton();
        }

        public void AddUser(string name, UserRole role)
        {
            var user = new User(name, role);
            Array.Resize(ref Users, Users.Length + 1);
            Users[^1] = user;
        }

        public IUser GetUserByName(string name)
        {
            return Users.FirstOrDefault(u => u.Name == name);
        }
    }
}
