using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    class Suplier
    {
        private long id;
        private string name;
        private string phone;

        public Suplier(long id, string name, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public long Id { get => id; set => id = value; }
    }
}
