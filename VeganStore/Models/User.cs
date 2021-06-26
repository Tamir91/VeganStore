using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore
{
    public class User
    {
        private long id;
        private string name;
        private string role;

        public User()
        {
            id = -1;
            name = string.Empty;
            role = string.Empty;
        }

        public long Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Role
        {
            set { role = value; }
            get { return role; }
        }
    }
}
