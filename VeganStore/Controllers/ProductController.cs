using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganStore.Models;

namespace VeganStore.Controllers
{
    class ProductController
    {
        public static List<Product> GetAllProducts()
        {
            return DBSQL.Instance.GetData<Product>();
        }

        public static List<Product> GetAllProducts(long id)
        {
            return DBSQL.Instance.GetProductsBySuplierID(id);
        }

        public static long AddProduct(string name, string prodQuantity, string prodPrice, long suplier_id)
        {
            long result = -1;
            int quantity = 0;
            int price = 0;

            try
            {
                quantity = Convert.ToInt32(prodQuantity);
                price = Convert.ToInt32(prodPrice);
            }
            catch (System.FormatException e)
            {
                Console.Write(e.ToString());
            }

            Product product = new Product
            {
                Name = name,
                Quantity = quantity,
                Price = price,
                Suplier_id = suplier_id
            };

            DBSQL dBSQL = DBSQL.Instance;
            result = dBSQL.InsertProduct(product);

            return result;
        }

        public static long UpdateProduct(Product product)
        {
            return DBSQL.Instance.UpdateProduct(product);
        }

        public static long DeleteProduct(string id)
        {
            long result = -1;

            if (!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                DBSQL dBSQL = DBSQL.Instance;
                result = dBSQL.DeleteRow<Product>(Convert.ToInt32(id));
            }

            return result;
        }

        public static bool IsInputProductDataCorrect(string name, string prodQuantity, string prodPrice)
        {
            return !String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name) &&
                   !String.IsNullOrEmpty(prodQuantity) && !String.IsNullOrWhiteSpace(prodQuantity) && prodQuantity.All(char.IsDigit) &&
                   !String.IsNullOrEmpty(prodPrice) && !String.IsNullOrWhiteSpace(prodPrice) && prodQuantity.All(char.IsDigit);
        }


    }
}
