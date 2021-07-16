using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Controllers
{
    class UserController
    {
        /// <summary>
        /// This function add new User
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="role">User role Client or Admin</param>
        /// <returns></returns>
        public static bool AddUser(string name, string role)
        {
            bool result = false;

            User user = new User
            {
                Name = name,
                Role = role
            };

            DBSQL dBSQL = DBSQL.Instance;
            result = dBSQL.InsertUser(user);

            return result;
        }

        public static bool UpdateUser(string id)
        {
            bool result = false;

            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                // TODO: Implemet
            }

            return result;
        }

        public static bool DeleteUser(string id)
        {
            bool result = false;

            if (!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                // TODO: remove by ID
            }

            return result;
        }

    }
}
