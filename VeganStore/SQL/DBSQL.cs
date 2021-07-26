using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using VeganStore.Models;
using System.Collections;

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

        public new static DBSQL Instance
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

        protected Product DataSetRowToProductObject(DataRow row)
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(row["id"].ToString());
            product.Name = row["name"].ToString();
            product.Quantity = Convert.ToInt32(row["quantity"]);
            product.Price = Convert.ToInt32(row["price"]);
            product.Suplier_id = Convert.ToInt32(row["suplier_id"]);
            if(row.Table.Columns.Contains("suplier_name"))
                product.Suplier_name = row["suplier_name"].ToString();

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

        public User GetUserByID(long userID)
        {
            DataSet result;
            User user;
            string cmdStr = "SELECT * FROM users WHERE id=@id";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", userID);
                result = GetMultipleQuery(command);
            }

            try
            {
                user = new User
                {
                    Id = Convert.ToInt32(result.Tables[0].Rows[0]["id"]),
                    Name = result.Tables[0].Rows[0]["name"].ToString(),
                    Role = result.Tables[0].Rows[0]["role"].ToString()
                };
            }
            catch
            {
                user = null;
            }
            

            return user;
        }

        public List<OrderTotal> GetOrdersByUserID(long userID)
        {
            DataSet result;
            string cmdStr = "SELECT * FROM " +
                                "(SELECT carts.id cart_id, carts.created_at, users.name, " +
	                                "(SELECT SUM(products.price * orders.quantity) " +
                                     "FROM orders " +
                                     "LEFT JOIN products " +
                                     "ON orders.product_id = products.id " +
                                     "WHERE carts.id = orders.cart_id " +
                                     "GROUP BY orders.cart_id) AS total " +
                                "FROM carts " +
                                "LEFT JOIN users " +
                                "ON carts.user_id = users.id " +
                                " WHERE carts.user_id=@user_id) subtable " +
                            "WHERE subtable.total IS NOT NULL ";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@user_id", userID);
                result = GetMultipleQuery(command);
            }

            return GetOrders(result);
        }

        public List<OrderProduct> GetOrderProducts(long cartID)
        {
            DataSet result;
            string cmdStr = "SELECT o.product_id, o.cart_id, o.quantity, p.name, p.price, (p.price * o.quantity) total_price " +
                                "FROM orders o " +
                                "LEFT JOIN products p ON o.product_id = p.id " +
                                "WHERE o.cart_id =@cart_id";

             using (MySqlCommand command = new MySqlCommand(cmdStr))
             {
                command.Parameters.AddWithValue("@cart_id", cartID);
                result = GetMultipleQuery(command);
             }

            return GetOrdersProductsToList(result);
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
        public List<T> GetData<T>()
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
                    cmdStr = "SELECT pr.id, pr.name, pr.price, pr.quantity, pr.suplier_id, sp.name as suplier_name " +
                             "FROM products pr " +
                             "LEFT JOIN supliers sp ON pr.suplier_id=sp.id";
                    break;
                case "Suplier":
                    cmdStr += " supliers";
                    break;
                case "User":
                    cmdStr += " users";
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
        public List<T> GetData<T>(DataSet dataSet)
        {
            DataRowCollection data = dataSet.Tables[0].Rows;
            List<T> list = new List<T>();

            for (int i = 0; i < data.Count; i++)
            {
                switch (typeof(T).Name)
                {
                    case "Cart":
                        list.Add((T)(object)DataSetRowToCartObject(data[i]));
                        break;
                    case "Order":
                        list.Add((T)(object)DataSetRowToOrderObject(data[i]));
                        break;
                    case "Product":
                        list.Add((T)(object)DataSetRowToProductObject(data[i]));
                        break;
                    case "Suplier":
                        list.Add((T)(object)DataSetRowToSuplierObject(data[i]));
                        break;
                    case "User":
                        list.Add((T)(object)DataSetRowToUserObject(data[i]));
                        break;
                    default:
                        break;
                }
            }
            return list;
        }

        // Get DataSet from table by name
        public DataSet GetData<T>(string name)
        {
            DataSet result;
            string cmdStr = "SELECT * FROM " + typeof(T).Name.ToLower() + "s WHERE name=@name";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", name);
                result = GetMultipleQuery(command);
            }

            return result;
        }

        public DataSet GetDataForExcel<T>()
        {
            DataSet result;
            string cmdStr = "SELECT * FROM " + typeof(T).Name.ToLower() + "s";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = GetMultipleQuery(command);
            }

            return result;
        }

        // Get DataSet from table by id
        public DataSet GetData<T>(long id)
        {
            DataSet result;
            string cmdStr = "SELECT * FROM " + typeof(T).Name.ToLower() + "s WHERE id=@id";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", id);
                result = GetMultipleQuery(command);
            }

            return result;
        }


        public List<Product> GetProductsBySuplierID(long suplierID)
        {
            DataSet result;
            string cmdStr = "SELECT * FROM products WHERE suplier_id=@suplierID";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@suplierID", suplierID);
                result = GetMultipleQuery(command);
            }

            return GetProducts(result);
        }

        public List<Product> GetProducts(DataSet dataSet)
        {
            DataRowCollection data = dataSet.Tables[0].Rows;
            List<Product> list = new List<Product>();

            for (int i = 0; i < data.Count; i++)
            { 
                list.Add((Product)DataSetRowToProductObject(data[i]));          
            }
            return list;
        }

        public List<OrderTotal> GetOrders(DataSet dataSet)
        {
            DataRowCollection data = dataSet.Tables[0].Rows;
            List<OrderTotal> list = new List<OrderTotal>();

            for (int i = 0; i < data.Count; i++)
            {
                list.Add((OrderTotal)DataSetRowToOrderObject(data[i]));
            }
            return list;
        }

        public List<OrderProduct> GetOrdersProductsToList(DataSet dataSet)
        {
            DataRowCollection data = dataSet.Tables[0].Rows;
            List<OrderProduct> list = new List<OrderProduct>();

            for (int i = 0; i < data.Count; i++)
            {
                list.Add(DataSetRowToOrderProductObject(data[i]));
            }
            return list;
        }

        private OrderTotal DataSetRowToOrderObject(DataRow row)
        {
            OrderTotal order = new OrderTotal
            {
                Cart_id = Convert.ToInt32(row["cart_id"].ToString()),
                Name = row["name"].ToString(),
                Created_at = row["created_at"].ToString(),
                Total = Convert.ToInt32(row["total"].ToString())
            };
            return order;
        }

        private OrderProduct DataSetRowToOrderProductObject(DataRow row)
        {
            OrderProduct order = new OrderProduct
            {
                Product_id = Convert.ToInt32(row["product_id"].ToString()),
                Name = row["name"].ToString(),
                Quantity = Convert.ToInt32(row["quantity"].ToString()),
                Price = Convert.ToInt32(row["price"].ToString()),
                Total_price = Convert.ToInt32(row["total_price"].ToString()),
                Cart_id = Convert.ToInt32(row["cart_id"].ToString())
            };

            return order;
        }

        /*Inserts*/

        public long InsertCart(Cart cart)
        {
            string cmdStr = "INSERT INTO carts (user_id, created_at) VALUES (@user_id, @created_at)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@user_id", cart.User_id);
                command.Parameters.AddWithValue("@created_at", cart.Created_at);

                return ExecuteSimpleQuery(command);
            }
        }

        public long InsertOrder(Order order)
        {
            string cmdStr = "INSERT INTO orders (product_id, quantity, cart_id) VALUES (@product_id, @quantity, @cart_id)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@product_id", order.Product_id);
                command.Parameters.AddWithValue("@quantity", order.Quantity);
                command.Parameters.AddWithValue("@cart_id", order.Cart_id);

                return ExecuteSimpleQuery(command);
            }
        }

        public long InsertProduct(Product product)
        {
            string cmdStr = "INSERT INTO products (name, quantity, price, suplier_id) VALUES (@name, @quantity, @price, @suplier_id)";

            using(MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@quantity", product.Quantity);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@suplier_id", product.Suplier_id);

                return ExecuteSimpleQuery(command);
            }
        }

        public long InsertUser(User user)
        {
            string cmdStr = "INSERT INTO users (name, role) VALUES (@name, @role)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@role", user.Role);

                return ExecuteSimpleQuery(command);
            }
        }    

        public long InsertSuplier(Suplier suplier)
        {
            string cmdStr = "INSERT INTO supliers (id, name, phone) VALUES (@id, @name, @phone)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", suplier.Id);
                command.Parameters.AddWithValue("@name", suplier.Name);
                command.Parameters.AddWithValue("@phone", suplier.Phone);

                return ExecuteSimpleQuery(command);
            }
        }

        /*Updates*/

        public long UpdateProduct(Product product)
        {
            string cmdStr = "UPDATE products SET name=@name, quantity=@quantity, price=@price WHERE id=@id";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@quantity", product.Quantity);
                command.Parameters.AddWithValue("@price", product.Price);

                return ExecuteSimpleQuery(command);
            }
        }

        public long UpdateSuplier(Suplier suplier)
        {
            string cmdStr = "UPDATE supliers SET name=@name, phone=@phone WHERE id=@id";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", suplier.Name);
                command.Parameters.AddWithValue("@id", suplier.Id);
                command.Parameters.AddWithValue("@phone", suplier.Phone);

                return ExecuteSimpleQuery(command);
            }
        }

        public long UpdateUser(User user)
        {
            string cmdStr = "UPDATE users SET name=@name, role=@role WHERE id=@id";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@id", user.Id);
                command.Parameters.AddWithValue("@role", user.Role);

                return ExecuteSimpleQuery(command);
            }
        }

        /*Delete*/

        public long DeleteRow<T>(long id)
        {
            long result = -1;
            string cmdStr = "DELETE FROM " + typeof(T).Name.ToLower() + "s WHERE id=@id";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                result = ExecuteSimpleQuery(command);
            }

            return result;
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
