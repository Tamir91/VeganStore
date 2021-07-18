using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganStore.Models;

namespace VeganStore.Controllers
{
    class SuplierController
    {
        public static List<Suplier> GetAllSupliers()
        {
            return DBSQL.Instance.GetData<Suplier>();
        }

        /// <summary>
        /// This function add new Suplier
        /// </summary>
        /// <param name="name">Suplier name</param>
        /// <param name="phone">Suplier phone</param>
        /// <returns>>True if Suplier added otherwise false</returns>
        public static long AddSuplier(string name, string phone)
        {
            Suplier suplier = new Suplier
            {
                Name = name,
                Phone = phone
            };

            return DBSQL.Instance.InsertSuplier(suplier);
        }

        /// <summary>
        /// This function update Suplier By ID
        /// </summary>
        /// <param name="suplier">suplier object</param>
        /// <returns>True if Suplier updated otherwise false</returns>
        public static long UpdateSuplier(Suplier suplier)
        {
            return DBSQL.Instance.UpdateSuplier(suplier);
        }

        /// <summary>
        /// This function delete Suplier by ID OR name OR phone
        /// </summary>
        /// <param name="id">Suplier ID</param>
        /// <returns>True if Suplier deleted otherwise false</returns>
        public static long DeleteSuplier(string id)
        {
            long result = -1;

            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                DBSQL dBSQL = DBSQL.Instance;
                result = dBSQL.DeleteRow<Suplier>(Convert.ToInt32(id));
            }

            return result;
        }

        public static bool IsInputSuplierDataCorrect(string name, string phone)
        {
            return !String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name) &&
                   !String.IsNullOrEmpty(phone) && !String.IsNullOrWhiteSpace(phone) && phone.All(char.IsDigit);
        }
    }
}
