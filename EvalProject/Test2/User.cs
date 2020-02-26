using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class User
    {
        private static List<string> _users;
        public User()
        {
            if (_users == null)
                _users = new List<string>();
        }

        public void Add(string userName)
        {
            _users.Add(userName);
        }

        public int GetUsersCount()
        {
            return _users.Count;
        }
    }
}
