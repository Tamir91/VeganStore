using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace VeganStore
{
    public class DBSQL:DBConnection
    {
        readonly private string DATA_BASE_NAME = "finalCSharp";

        private static DBSQL instance;

        private DBSQL()
        {
            databaseName = DATA_BASE_NAME;
            userName = "root";
            password = string.Empty;
        }

        public static DBSQL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DBSQL();
                    DBConnection.Instance();
                }
                return instance;
            }
        }

        protected Person dataSetRowToPersonObject(DataRow row)
        {
            Person person = new Person();
            person.Id = Convert.ToInt32(row["id"]);
            person.CityCode = Convert.ToInt32(row["cityCode"]);
            person.FirstName = row["firstName"].ToString();
            person.LastName = row["lastName"].ToString();
            person.UserName = row["userName"].ToString();
            return person;
        }

        protected Person[] dataSetPersonToArrayOfObjects(DataSet dataSet)
        {
            DataRowCollection data = dataSet.Tables[0].Rows;
            Person[] persons = new Person[data.Count];

            for (int i = 0; i < data.Count; i++)
                persons[i] = dataSetRowToPersonObject(data[i]);

            return persons;
        }

        public Person[] GetPersons()
        {
            DataSet result;
            string cmdStr = "SELECT * FROM persons";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = GetMultipleQuery(command);
            }

            return dataSetPersonToArrayOfObjects(result);
        }

        protected City dataSetRowToCityObject(DataRow row)
        {
            City city = new City();
            city.CityName = row["cityName"].ToString();
            city.CityCode = Convert.ToInt32(row["cityCode"]);
            city.Id = Convert.ToInt32(row["id"].ToString());
            return city;
        }

        protected City[] dataSetCityToArrayOfObjects(DataSet dataSet)
        {
            DataRowCollection data = dataSet.Tables[0].Rows;
            City[] cities = new City[data.Count];

            for (int i = 0; i < data.Count; i++)
                cities[i] = dataSetRowToCityObject(data[i]);

            return cities;
        }

        public City[] GetCities()
        {
            DataSet result;
            string cmdStr = "SELECT * FROM city";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = GetMultipleQuery(command);
            }

            return dataSetCityToArrayOfObjects(result);
        }

        public DataSet GetCityByName(string cityName)
        {
            DataSet result;
            string cmdStr = "SELECT * FROM city WHERE cityName=@cityName";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cityName", cityName);
                result = GetMultipleQuery(command);
            }

            return result;
        }

        public int GetCityMaxNumber()
        {
            int result;
            string cmdStr = "SELECT MAX(cityCode) FROM city";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public void InsertCity(City Item)
        {
            string cmdStr = "INSERT INTO city (cityCode, cityName) VALUES (@cityCode, @cityName)";

            using(MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cityCode", Item.CityCode);
                command.Parameters.AddWithValue("@cityName", Item.CityName);

                ExecuteSimpleQuery(command);
            }
        }

        public void InsertPerson(Person Item)
        {
            string cmdStr = "INSERT INTO persons (firstName, lastName, cityCode, userName, userPassword) VALUES (@firstName, @lastName, @cityCode, @userName, @userPassword)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@firstname", Item.FirstName);
                command.Parameters.AddWithValue("@lastName", Item.LastName);
                command.Parameters.AddWithValue("@cityCode", Item.CityCode);
                command.Parameters.AddWithValue("@userName", Item.UserName);
                command.Parameters.AddWithValue("@userPassword", Item.UserPassword);

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
