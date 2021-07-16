using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganStore.Models;

namespace VeganStore.Controllers
{
    class SuplierController
    {
        /// <summary>
        /// This function add new Suplier
        /// </summary>
        /// <param name="name">Suplier name</param>
        /// <param name="phone">Suplier phone</param>
        /// <returns>>True if Suplier added otherwise false</returns>
        public static bool AddSuplier(string name, string phone)
        {
            bool result = false;

            if(IsPhoneNumber(phone) && !String.IsNullOrEmpty(name))
            {
                Suplier suplier = new Suplier
                {
                    Name = name,
                    Phone = phone
                };

                DBSQL dBSQL = DBSQL.Instance;
                result = dBSQL.InsertSuplier(suplier);
            }

            return result;
        }

        /// <summary>
        /// This function update Suplier By ID
        /// </summary>
        /// <param name="id">Suplier ID</param>
        /// <returns>True if Suplier updated otherwise false</returns>
        public static bool UpdateSuplierByID(string id)
        {
            bool result = false;

            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                // TODO: Implemet
            }
            return result;
        }

        /// <summary>
        /// This function delete Suplier by ID OR name OR phone
        /// </summary>
        /// <param name="id">Suplier ID</param>
        /// <param name="name">Suplier name</param>
        /// <param name="phone">Suplier phone</param>
        /// <returns>True if Suplier deleted otherwise false</returns>
        public static bool DeleteSuplier(string id, string name, string phone)
        {
            bool result = false;

            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                 // TODO: remove by ID
            }
            else if (!String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name))
            {
                // TODO: remove by name
            }
            else if(!String.IsNullOrEmpty(phone) && !String.IsNullOrWhiteSpace(phone))
            {
                // TODO: remove by phone
            }

            return result;
        }

        // Check if phone number is valid
        private static bool IsPhoneNumber(string number)
        {
            return number != null && number.All(char.IsDigit);
        }
    }
}
