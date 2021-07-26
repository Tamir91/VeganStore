using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Controllers
{
    class UserController
    {
        public static List<User> GetAllUsers()
        {
            DBSQL dBSQL = DBSQL.Instance;
            List<User> users = dBSQL.GetData<User>();

            return users;
        }

        public static User GetUserByID(long userID)
        {
            DBSQL dBSQL = DBSQL.Instance;
            User user = dBSQL.GetUserByID(userID);

            return user;
        }

        /// <summary>
        /// This function add new User
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="role">User role Client or Admin</param>
        /// <returns></returns>
        public static long AddUser(string name, string role)
        {
            long result = -1;

            User user = new User
            {
                Name = name,
                Role = role
            };

            DBSQL dBSQL = DBSQL.Instance;
            result = dBSQL.InsertUser(user);

            return result;
        }

        public static long UpdateUser(User user)
        {
            long result = -1;

            DBSQL dBSQL = DBSQL.Instance;
            result = dBSQL.UpdateUser(user);
          

            return result;
        }

        public static long DeleteUser(string id)
        {
            long result = -1;

            if (!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                DBSQL dBSQL = DBSQL.Instance;
                result = dBSQL.DeleteRow<User>(Convert.ToInt32(id));
            }

            return result;
        }
    }
}
