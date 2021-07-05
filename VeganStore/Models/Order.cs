using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    public class Order
    {
        private long id;
        private long product_id;
        private int quantity;
        private long cart_id;

        public Order() { }

        public Order(long id, long product_id, int quantity, long cart_id, string created_time)
        {
            this.Id = id;
            this.Product_id = product_id;
            this.Quantity = quantity;
            this.Cart_id = cart_id;

        }

        public long Id { get => id; set => id = value; }
        public long Product_id { get => product_id; set => product_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public long Cart_id { get => cart_id; set => cart_id = value; }
    }
}
