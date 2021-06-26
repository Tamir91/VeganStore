using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganStore
{
    public class DBConnection
    {
        public static string databaseName = string.Empty;
        public static string userName = string.Empty;
        public static string password = string.Empty;

        protected static string connString = string.Empty;

        private static DBConnection _instance = null;
        private static MySqlConnection connection = null;

        protected static DBConnection Instance()
        {
            bool result = true;

            if (_instance == null)
            {
                _instance = new DBConnection();
                result = !string.IsNullOrEmpty(databaseName);

                if (result)
                {
                    connString = string.Format("Server=localhost; database={0}; UID={1}; password={2}", databaseName, userName, password);
                    connection = new MySqlConnection(connString);
                }
            }

            return _instance;
        }

        public bool Connect()
        {
            bool result = true;

            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                result = false;
            }
    
            return result;
        }

        public void Close()
        {
            connection.Close();
        }

        protected bool ExecuteSimpleQuery(MySqlCommand command)
        {
            bool result = true;

            lock (connection)// creates pipe, only one per time can connect 
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        command.ExecuteNonQuery(); // not returning result
                    }
                    catch (Exception)
                    {
                        result = false;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }

            return result;
        }

        // command - query
        protected int ExecuteScalarIntQuery(MySqlCommand command)
        {
            int result = -1;

            lock (connection)// one query per time
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        result =  Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception)
                    {
                        result = -1;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
            return result;
        }

        protected DataSet GetMultipleQuery(MySqlCommand command)
        {
            DataSet dataset = new DataSet();// dataset

            lock (connection)
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter();// create mysql adapter
                        adapter.SelectCommand = command;
                        adapter.Fill(dataset);// run query and put result into dataset
                    }
                    catch (Exception)
                    {
                        dataset = null;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
            return dataset;
        }
    }
}
