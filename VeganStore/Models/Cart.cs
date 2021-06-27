using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    public class Cart
    {
        private long id;
        private long user_id;
        private string created_at;

        public Cart() { }

        public Cart(long id, long user_id, string created_at)
        {
            this.Id = id;
            this.User_id = user_id;
            this.created_at = created_at;
        }

        public string Created_at { get => created_at; set => created_at = value; }
        public long Id { get => id; set => id = value; }
        public long User_id { get => user_id; set => user_id = value; }
    }
}
