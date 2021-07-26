using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    public class OrderTotal
    {
        private long cart_id;
        private string created_at;
        private string name;
        private int total;

        public OrderTotal() { }

        public OrderTotal(long cart_id, string created_at, string name, int total)
        {
            this.cart_id = cart_id;
            this.created_at = created_at;
            this.name = name;
            this.total = total;
        }

        public long Cart_id { get => cart_id; set => cart_id = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Name { get => name; set => name = value; }
        public int Total { get => total; set => total = value; }
    }
}
