using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    class Product
    {
        private long id;
        private string name;
        private int quantity;
        private int price;
        private long suplier_id;

        public Product(long id, string name, int quantity, int price, long suplier_id)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Suplier_id = suplier_id;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public long Suplier_id { get => suplier_id; set => suplier_id = value; }
    }
}
