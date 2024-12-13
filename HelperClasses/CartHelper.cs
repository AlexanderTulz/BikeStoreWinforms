using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.HelperClasses
{


    public class CartHelper
    {
        public static string BasePath = @"X:\Unik\AlgorithmsAndDataStructure\BikeStore";
        static string FolderName = @"Cart\";
        static string FullPath = BasePath + @"\" + FolderName;
        string CartFile = "OnCart";

        public CartHelper() 
        {
            CreateIndexing();
        }

        private void CreateIndexing()
        {
            if (File.Exists(FullPath + CartFile))
            {
                return;
            }
            // Check for folder

            using (FileStream fs = File.OpenWrite(FullPath + CartFile))
            {
                byte[] title = new UTF8Encoding(true).GetBytes("");
                fs.Write(title, 0, title.Length);
                fs.Close();
            }
        }

        public void AddToCart(int ItemId)
        {
            string FullCart = "";

            using (StreamReader sr = File.OpenText(FullPath + CartFile))
            {
                string buffer = "";

                while ((buffer = sr.ReadLine()) != null)
                {
                    FullCart += $"{buffer}\n";
                }

                sr.Close();
            }

            using (FileStream fs = File.OpenWrite(FullPath + CartFile))
            {
                byte[] title = new UTF8Encoding(true).GetBytes($"{FullCart}{ItemId}\n");
                fs.Write(title, 0, title.Length);
                fs.Close();
            }
        }

        public void RemoveFromCart(int ItemId)
        {
            int LineIndexToDelete = 0;

            using (StreamReader sr = File.OpenText(FullPath + CartFile))
            {
                string buffer = "";

                while ((buffer = sr.ReadLine()) != null)
                {
                    if(Int32.Parse(buffer) == ItemId)
                    {
                        break;
                    }
                    ++LineIndexToDelete;
                }

                sr.Close();
            }

            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(FullPath + CartFile).ToList();

                // Check if the specified line number is valid
                if (LineIndexToDelete > 0 && LineIndexToDelete <= lines.Count)
                {
                    // Remove the specified line
                    lines.RemoveAt(LineIndexToDelete - 1);

                    // Write the remaining lines back to the file
                    File.WriteAllLines(FullPath + CartFile, lines);

                    Console.WriteLine("Line removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid line number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void RemoveFromCartLine(int LineToDelete)
        {
            int LineIndexToDelete = LineToDelete;

            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(FullPath + CartFile).ToList();

                // Check if the specified line number is valid
                if (LineIndexToDelete > 0 && LineIndexToDelete <= lines.Count)
                {
                    // Remove the specified line
                    lines.RemoveAt(LineIndexToDelete - 1);

                    // Write the remaining lines back to the file
                    File.WriteAllLines(FullPath + CartFile, lines);

                    Console.WriteLine("Line removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid line number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        
        public void OrderItems(DB db)
        {
            var itemIds = GetItemIndexesInCart();

            db.OpenConnection();

            try
            {
                foreach (var itemId in itemIds)
                {
                    db.CloseConnection();
                    var ItemObj = db.GetItemObjectByID(itemId);

                    db.CloseConnection();
                    db.OpenConnection();

                    string commandString = "UPDATE `items` SET `amount_in_stock` = @amount_in_stock WHERE `itemID` = @itemID";
                    MySqlCommand command = new MySqlCommand(commandString, db.GetConnection());
                    command.Parameters.Add("@amount_in_stock", MySqlDbType.UInt32).Value = ItemObj.amountInStock - 1;
                    command.Parameters.Add("@itemID", MySqlDbType.UInt32).Value = ItemObj.itemID;

                    command.ExecuteNonQuery();

                    if (ItemObj.amountInStock - 1 <= 0)
                    {
                        db.CloseConnection();
                        db.OpenConnection();
                        string deleteCommandString = "DELETE FROM `items` WHERE `itemID` = @itemID";
                        MySqlCommand deleteCommand = new MySqlCommand(deleteCommandString, db.GetConnection());
                        deleteCommand.Parameters.Add("@itemID", MySqlDbType.UInt32).Value = ItemObj.itemID;

                        deleteCommand.ExecuteNonQuery();
                        db.CloseConnection();

                    }

                    RemoveFromCartLine(1);
                }
            }
            catch
            {

            }
            

            db.CloseConnection();
        }

        public List<int> GetItemIndexesInCart()
        {
            var list = new List<int>();

            using (StreamReader sr = File.OpenText(FullPath + CartFile))
            {
                string buffer = "";

                while ((buffer = sr.ReadLine()) != null)
                {
                    int? itemID = Int32.Parse(buffer);

                    if(itemID != null && itemID >= 0)
                    {
                        list.Add(itemID.Value);
                    }
                }

                sr.Close();
            }

            return list;
        }
    }
}

   
