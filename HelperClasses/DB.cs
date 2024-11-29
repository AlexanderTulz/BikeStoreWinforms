using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.HelperClasses
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=MySQL-8.2;port=3306;username=root;password=;database=BikestoreDB");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public string GetUsersTableName(string login)
        {
            OpenConnection();

            string commandString = "SELECT `name` FROM `users` WHERE `login` = @login";
            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            string name = "";
            object result = command.ExecuteScalar();
            if (result != null) name = result.ToString();

            CloseConnection();

            return name;
        }

        public string GetUsersTablePassword(string login)
        {
            OpenConnection();

            string commandString = "SELECT `password` FROM `users` WHERE `login` = @login";
            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            string password = "";
            object result = command.ExecuteScalar();
            if (result != null) password = result.ToString();

            CloseConnection();

            return password;
        }

        public string GetUsersTableRole(string login)
        {
            OpenConnection();

            string commandString = "SELECT `role` FROM `users` WHERE `login` = @login";
            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            string role = "";
            object result = command.ExecuteScalar();
            if (result != null) role = result.ToString();

            CloseConnection();

            return role;
        }

        public bool GetIfLoginExistsFromUsersTable(string login)
        {
            OpenConnection();

            string commandString = "SELECT `login` FROM `users` WHERE `login` = @login";
            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            string loginFromDB = "";
            object result = command.ExecuteScalar();
            if (result != null) loginFromDB = result.ToString();

            CloseConnection();

            bool Check = loginFromDB == login;

            return Check;
        }

        public string GetShopName(string login)
        {
            OpenConnection();

            string commandString = "SELECT `user_id` FROM `users` WHERE `login` = @login";
            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            uint? userID = 0;
            object result = command.ExecuteScalar();
            if (result != null) userID = UInt32.Parse(result.ToString());
            if (userID == null) return string.Empty;


            commandString = "SELECT `ShopName` FROM `shops` WHERE `OwnerID` = @userID";
            command.CommandText = commandString;
            command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID;

            string shopName = "";
            result = command.ExecuteScalar();
            if (result != null) shopName = result.ToString();

            CloseConnection();

            return shopName;
        }
    }
}
