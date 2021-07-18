using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganStore.Models;

namespace VeganStore.Controllers
{
    class CartController
    {

        public static List<Cart> GetAllCarts()
        {
            DBSQL dBSQL = DBSQL.Instance;
            List<Cart> carts = dBSQL.GetData<Cart>();

            return carts;
        }

        /// <summary>
        /// This function add new User
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="role">User role Client or Admin</param>
        /// <returns></returns>
        public static long AddCart(long user_id)
        {
            long result = -1;

            Cart cart = new Cart
            {
                User_id = user_id
            };

            DBSQL dBSQL = DBSQL.Instance;
            result = dBSQL.InsertCart(cart);

            return result;
        }

    }

}

