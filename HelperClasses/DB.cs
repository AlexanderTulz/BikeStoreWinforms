using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.HelperClasses
{
    public class DB
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
            command.Parameters.Add("@userID", MySqlDbType.UInt32).Value = userID;

            string shopName = "";
            result = command.ExecuteScalar();
            if (result != null) shopName = result.ToString();

            CloseConnection();

            return shopName;
        }

        public uint GetShopID(string shopName)
        {
            OpenConnection();

            string commandString = "SELECT `ShopID` FROM `shops` WHERE `ShopName` = @shopName";

            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.CommandText = commandString;
            command.Parameters.Add("@shopName", MySqlDbType.VarChar).Value = shopName;

            uint shopID = 0;
            object result = command.ExecuteScalar();
            if (result != null) shopID = UInt32.Parse(result.ToString());

            CloseConnection();

            return shopID;
        }

        public uint GetCategoryID(string categoryName) 
        {
            OpenConnection();
            string commandString = "SELECT `categoryID` FROM `categories` WHERE `category_name` = @category_name";

            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.CommandText = commandString;
            command.Parameters.Add("@category_name", MySqlDbType.VarChar).Value = categoryName;

            uint categoryID = 0;
            object result = command.ExecuteScalar();
            if (result != null) categoryID = UInt32.Parse(result.ToString());

            CloseConnection();

            return categoryID;

        }

        public uint GetItemID(string itemName, uint shopID)
        {
            OpenConnection();
            string commandString = "SELECT `itemID` FROM `items` WHERE `item_name` = @item_name AND `shopID` = @shopID";

            MySqlCommand command = new MySqlCommand(commandString, GetConnection());
            command.CommandText = commandString;
            command.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = itemName;
            command.Parameters.Add("@shopID", MySqlDbType.UInt32).Value = shopID;

            uint itemID = 0;
            object result = command.ExecuteScalar();
            if (result != null) itemID = UInt32.Parse(result.ToString());

            CloseConnection();

            return itemID;
        }

        public ItemObject GetItemObjectByID(int id)
        {
            var Items = GetAllItems();

            foreach(var Item in Items)
            {
                if (Item.itemID == id)
                {
                    return Item;
                }
            }

            return null;
        }

        public List<ItemObject> GetAllItems()
        {
            List<ItemObject > items = new List<ItemObject>();

            OpenConnection();
            try
            {
                

                string commandString = "SELECT * FROM `items`";

                MySqlDataAdapter adapter = new MySqlDataAdapter(commandString, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataGridView dataGridViewProducts = new DataGridView();

                dataGridViewProducts.DataSource = dt;   // Don't need it for now

                

                CloseConnection();

                foreach (DataRow row in dt.Rows)
                {
                    OpenConnection();

                    ItemObject item = new ItemObject()
                    {
                        itemID = Int32.Parse(row["itemID"].ToString()),
                        shopID = Int32.Parse(row["shopID"].ToString()),
                        item_name = row["item_name"].ToString(),
                        item_description = row["item_description"].ToString(),
                        price = Double.Parse(row["price"].ToString()),
                        amountInStock = Int32.Parse(row["amount_in_stock"].ToString()),
                        categoryID = Int32.Parse(row["categoryID"].ToString())


                    };

                    commandString = "SELECT `ShopName` FROM `shops` WHERE `ShopID` = @shopID";
                    MySqlCommand command = new MySqlCommand(commandString, GetConnection());
                    command.Parameters.Add("@shopID", MySqlDbType.UInt32).Value = item.shopID;

                    CloseConnection();
                    OpenConnection();

                    object value = command.ExecuteScalar();
                    if(value != null)
                    {
                        item.shop_name = value.ToString();
                    }

                    CloseConnection();
                    OpenConnection();

                    commandString = "SELECT `category_name` FROM `categories` WHERE `categoryID` = @categoryID";
                    command.CommandText = commandString;
                    command.Parameters.Clear();
                    command.Parameters.Add("@categoryID", MySqlDbType.UInt32).Value = item.categoryID;

                    value = command.ExecuteScalar();
                    if (value != null)
                    {
                        item.category_name = value.ToString();
                    }

                    CloseConnection();
                    OpenConnection();

                    commandString = "SELECT `path_to_image` FROM `item_images` WHERE `ItemID` = @ItemID";
                    command.CommandText = commandString;
                    command.Parameters.Clear();
                    command.Parameters.Add("@ItemID", MySqlDbType.UInt32).Value = item.itemID;

                    value = command.ExecuteScalar();
                    if (value != null)
                    {
                        item.pathToImage = value.ToString();
                    }


                    items.Add(item);

                    CloseConnection();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            CloseConnection();

            return items;
        }

        static public string CategoryToString(ECategory category)
        {
            string returnVal = "";

            switch (category)
            {
                case ECategory.MTB:
                    returnVal = "MTB";
                    break;
                case ECategory.MTB_Downhill:
                    returnVal = "MTB Downhill";
                    break;
                case ECategory.Gravel:
                    returnVal = "Gravel";
                    break;
                case ECategory.Fix:
                    returnVal = "Fix";
                    break;
                case ECategory.Sport:
                    returnVal = "Sport";
                    break;
                case ECategory.EBike:
                    returnVal = "E-Bike";
                    break;
                case ECategory.Accessories:
                    returnVal = "Accessories";
                    break;
            }

            return returnVal;
        }

        static public int CategoryToCategoryID(ECategory category)
        {
            int returnVal = (int)category;
            return returnVal;
        }
    }

    public class ItemObject
    {
        public int itemID { get; set; }
        public int shopID { get; set; }
        public string item_name {  get; set; }
        public string item_description { get; set; }
        public double price { get; set; }
        public int amountInStock { get; set; }
        public int categoryID { get; set; }

        public string shop_name { get; set; }
        public string category_name { get; set; }
        public string pathToImage { get; set; }
    }

    public enum ECategory
    {
        MTB = 1,
        MTB_Downhill,
        Gravel,
        Fix,
        Sport,
        EBike,
        Accessories
    }

    


}
