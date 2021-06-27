using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using VeganStore.Models;

namespace VeganStore
{
    public class DBSQL : DBConnection
    {
        readonly private string DATA_BASE_NAME = "finalCSharp";

        private static DBSQL instance;

        private DBSQL()
        {
            databaseName = DATA_BASE_NAME;
            userName = "root";
            password = string.Empty;
            //password = "4652581";
        }

        public static DBSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBSQL();
                    DBConnection.Instance();
                }
                return instance;
            }
        }


        protected Cart DataSetRowToCartObject(DataRow row)
        {
            Cart cart = new Cart
            {
                Id = Convert.ToInt32(row["id"]),
                User_id = Convert.ToInt32(row["user_id"]),
                Created_at = row["created_at"].ToString() // What is correct type or name?
            };
            return cart;
        }

        protected Order DataSetRowToOrderObject(DataRow row)
        {
            Order order = new Order
            {
                Id = Convert.ToInt32(row["id"]),
                Product_id = Convert.ToInt32(row["product_id"]),
                Quantity = Convert.ToInt32(row["quantity"]),
                Cart_id = Convert.ToInt32(row["cart_id"])
            };
            return order;
        }

        protected Product DataSetRowToProductObject(DataRow row)
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(row["id"].ToString());
            product.Name = row["name"].ToString();
            product.Quantity = Convert.ToInt32(row["quantity"]);
            product.Price = Convert.ToInt32(row["price"]);
            product.Suplier_id = Convert.ToInt32(row["suplier_id"]);

            return product;
        }

        protected Suplier DataSetRowToSuplierObject(DataRow row)
        {
            Suplier suplier = new Suplier
            {
                Id = Convert.ToInt32(row["id"]), // Is convertion correct to long?
                Name = row["name"].ToString(),
                Phone = row["phone"].ToString()
            };
            return suplier;
        }

        protected User DataSetRowToUserObject(DataRow row)
        {
            User user = new User
            {
                Id = Convert.ToInt32(row["id"]), // Is convertion correct to long?
                Name = row["name"].ToString(),
                Role = row["role"].ToString()
            };
            return user;
        }

        /*
                protected Cart[] GetCarts(DataSet dataSet)
                {
                    DataRowCollection data = dataSet.Tables[0].Rows;
                    Cart[] carts = new Cart[data.Count];

                    for (int i = 0; i < data.Count; i++)
                        carts[i] = DataSetRowToCartObject(data[i]);

                    return carts;
                }

                protected Order[] GetOrders(DataSet dataSet)
                {
                    DataRowCollection data = dataSet.Tables[0].Rows;
                    Order[] orders = new Order[data.Count];

                    for (int i = 0; i < data.Count; i++)
                        orders[i] = DataSetRowToOrderObject(data[i]);

                    return orders;
                }

                protected Product[] GetProducts(DataSet dataSet)
                {
                    DataRowCollection data = dataSet.Tables[0].Rows;
                    Product[] products = new Product[data.Count];

                    for (int i = 0; i < data.Count; i++)
                        products[i] = DataSetRowToProductObject(data[i]);

                    return products;
                }

                protected Suplier[] GetSupliers(DataSet dataSet)
                {
                    DataRowCollection data = dataSet.Tables[0].Rows;
                    Suplier[] supliers = new Suplier[data.Count];

                    for (int i = 0; i < data.Count; i++)
                        supliers[i] = DataSetRowToSuplierObject(data[i]);

                    return supliers;
                }

                protected User[] GetUsers(DataSet dataSet)
                {
                    DataRowCollection data = dataSet.Tables[0].Rows;
                    User[] users = new User[data.Count];

                    for (int i = 0; i < data.Count; i++)
                        users[i] = DataSetRowToUserObject(data[i]);

                    return users;
                }


                public Cart[] GetCarts()
                {
                    DataSet result;
                    string cmdStr = "SELECT * FROM carts";

                    using (MySqlCommand command = new MySqlCommand(cmdStr))
                    {
                        result = GetMultipleQuery(command);
                    }

                    return GetCarts(result);
                }

                public Order[] GetOrders()
                {
                    DataSet result;
                    string cmdStr = "SELECT * from orders";

                    using (MySqlCommand command = new MySqlCommand(cmdStr))
                    {
                        result = GetMultipleQuery(command);
                    }

                    return GetOrders(result);
                }

                public Product[] GetProducts()
                {
                    DataSet result;
                    string cmdStr = "SELECT * FROM products";

                    using (MySqlCommand command = new MySqlCommand(cmdStr))
                    {
                        result = GetMultipleQuery(command);
                    }

                    return GetProducts(result);
                }

                public Suplier[] GetSupliers()
                {
                    DataSet result;
                    string cmdStr = "SELECT * FROM supliers";

                    using (MySqlCommand command = new MySqlCommand(cmdStr))
                    {
                        result = GetMultipleQuery(command);
                    }

                    return GetSupliers(result);
                }

                public User[] GetUsers()
                {
                    DataSet result;
                    string cmdStr = "SELECT * FROM users";

                    using (MySqlCommand command = new MySqlCommand(cmdStr))
                    {
                        result = GetMultipleQuery(command);
                    }

                    return GetUsers(result);
                }

        */

        //Test Generic function
        public T[] GetData<T>()
        {
            string cmdStr = "SELECT * FROM ";

            switch (typeof(T).Name)
            {
                case "Cart":
                    cmdStr += " carts";
                    break;
                case "Order":
                    cmdStr += " orders";
                    break;
                case "Product":
                    cmdStr += " products";
                    break;
                case "Suplier":
                    cmdStr += " suplier";
                    break;
                case "User":
                    cmdStr += " user";
                    break;
                default:
                    cmdStr = "";
                    break;

            }
            DataSet result;

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = GetMultipleQuery(command);
            }

            return GetData<T>(result);
        }

        //Test Generic function
        protected T[] GetData<T>(DataSet dataSet)
        {
            DataRowCollection data = dataSet.Tables[0].Rows;
            T[] t = new T[data.Count];

            for (int i = 0; i < data.Count; i++)
            {
                switch (typeof(T).Name)
                {
                    case "Cart":
                        t[i] = (T)(object)DataSetRowToCartObject(data[i]);
                        break;
                    case "Order":
                        t[i] = (T)(object)DataSetRowToOrderObject(data[i]);
                        break;
                    case "Product":
                        t[i] = (T)(object)DataSetRowToProductObject(data[i]);
                        break;
                    case "Suplier":
                        t[i] = (T)(object)DataSetRowToSuplierObject(data[i]);
                        break;
                    case "User":
                        t[i] = (T)(object)DataSetRowToUserObject(data[i]);
                        break;
                    default:
                        t[i] = (T)(object)null;
                        break;
                }
            }
            return t;
        }


        public DataSet GetCart(string cartName)
        {
            DataSet result;
            string cmdStr = "SELECT * FROM cart WHERE name=@cartName";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@productName", cartName);
                result = GetMultipleQuery(command);
            }

            return result;
        }

        public DataSet GetProduct(string productName)
        {
            DataSet result;
            string cmdStr = "SELECT * FROM product WHERE name=@productName";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@productName", productName);
                result = GetMultipleQuery(command);
            }

            return result;
        }



        /*public int GetCityMaxNumber()
        {
            int result;
            string cmdStr = "SELECT MAX(cityCode) FROM city";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }*/

        public void InsertProduct(Product product)
        {
            string cmdStr = "INSERT INTO products (id, name, quantity, price, suplier_id) VALUES (@id, @name, @quantity, @price)";

            using(MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@quantity", product.Quantity);
                command.Parameters.AddWithValue("@price", product.Price);

                ExecuteSimpleQuery(command);
            }
        }

        public void InsertPerson(User user)
        {
            string cmdStr = "INSERT INTO persons (id, name, role) VALUES (@id, @name, @role)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@id", user.Id);
                command.Parameters.AddWithValue("@role", user.Role);

                ExecuteSimpleQuery(command);
            }
        }

        public void InsertGrades(Grade Item)
        {
            string cmdStr = "INSERT INTO grades (math, english, comp) VALUES (@math, @english, @comp)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@math", Item.Math);
                command.Parameters.AddWithValue("@english", Item.English);
                command.Parameters.AddWithValue("@comp", Item.Comp);

                ExecuteSimpleQuery(command);
            }
        }

        public static string DatabaseName
        {
            set
            {
                if(value != string.Empty)
                {
                    databaseName = value;
                }
            }
            get
            {
                return databaseName;
            }
        }

        public static string UserName
        {
            set
            {
                if (value != string.Empty)
                {
                    userName = value;
                }
            }
            get
            {
                return userName;
            }
        }

        public static string Password
        {
            set
            {
                if (value != string.Empty)
                {
                    password = value;
                }
            }
            get
            {
                return password;
            }
        }
    }
}
