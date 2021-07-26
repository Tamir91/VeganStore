using System.Collections.Generic;
using VeganStore.Models;

namespace VeganStore.Controllers
{
    class OrderController
    {
        public static long AddOrder(long productID, int quantity, long cartID)
        {
            long result = -1;

            Order order = new Order
            {
                Product_id = productID,
                Quantity = quantity,
                Cart_id = cartID
            };

            DBSQL dBSQL = DBSQL.Instance;
            result = dBSQL.InsertOrder(order);

            return result;
        }

        public static List<OrderTotal> GetOrdersByUserID(long userID)
        {
            return DBSQL.Instance.GetOrdersByUserID(userID);
        }

        public static List<OrderProduct> GetOrderProductsByCartID(long cartID)
        {
            return DBSQL.Instance.GetOrderProducts(cartID);
        }
    }
}