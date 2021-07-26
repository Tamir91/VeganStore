using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    public class OrderProduct
    {
        private long id;
        private long cart_id;
        private long product_id;
        private int quantity;
        private string name;
        private int price;
        private int total_price;

        public OrderProduct()
        {
        }

        public OrderProduct(long id, long cart_id, long product_id, int quantity, string name, int price, int total_price)
        {
            this.Id = id;
            this.Cart_id = cart_id;
            this.Product_id = product_id;
            this.Quantity = quantity;
            this.Name = name;
            this.Price = price;
            this.Total_price = total_price;
        }

        public long Id { get => id; set => id = value; }
        public long Cart_id { get => cart_id; set => cart_id = value; }
        public long Product_id { get => product_id; set => product_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Total_price { get => total_price; set => total_price = value; }
    }
}
