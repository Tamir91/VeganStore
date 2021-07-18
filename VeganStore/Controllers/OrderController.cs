using VeganStore.Models;

namespace VeganStore
{
    internal class OrderController
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
    }
}