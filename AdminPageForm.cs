using BikeStore.HelperClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class AdminPageForm : Form
    {
        AdminHelper ah = new AdminHelper();
        DB db = new DB();
        LoadSettings settings = new LoadSettings();
        List<TextBoxBase> AllTextBoxes = new List<TextBoxBase>();
        int CurrentIndex = -1;


        public AdminPageForm()
        {
            InitializeComponent();


            string[] filesIndexes = ah.GetPermissionNames();


            foreach (var file in filesIndexes)
            {
                PermissionListbox.Items.Add($"{file}");
            }

            AllTextBoxes.Add(TimeAndDateTextBox);
            AllTextBoxes.Add(ShopNameTextBox);
            AllTextBoxes.Add(ActionTypeTextBox);
            AllTextBoxes.Add(ItemNameTextBox);
            AllTextBoxes.Add(ItemDescriptionRichTextBox);
            AllTextBoxes.Add(ItemPriceTextBox);
            AllTextBoxes.Add(AmountInStockTextBox);
            AllTextBoxes.Add(ItemCategoryTextBox);

            foreach (var TextBox in AllTextBoxes)
            {
                TextBox.ReadOnly = true;
            }

            PermissionComboBox.Items.Clear();
            PermissionComboBox.Items.Add("Разрешить");
            PermissionComboBox.Items.Add("Отклонить");
            PermissionComboBox.SelectedIndex = 0;
            PermissionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void OpenPermissionButton_Click(object sender, EventArgs e)
        {
            int SelectedIndex = PermissionListbox.SelectedIndex;
            int index = ah.GetIDXIndex(PermissionListbox.Items[SelectedIndex].ToString());
            CurrentIndex = index;

            //PermissionComboBox.Items [PermissionComboBox.SelectedIndex];

            //if("Отклонить".Equals(PermissionComboBox.Items[PermissionComboBox.SelectedIndex].ToString()))
            //{

            //    ah.SetStrFieldValue(AdminHelper.GetFieldName(EPermissionFields.Permission), "no");
            //    return;
            //}

            string fieldValue = "";

            TimeAndDateTextBox.Clear();
            ItemsPanel.Show();

            //if(ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Action), ref fieldValue)  &&
            //    fieldValue == PermissionAction.ChangeItem.ToString())
            //{
            //    foreach (TextBoxBase TextBox in AllTextBoxes)
            //    {
            //        TextBox.ReadOnly = false;
            //    }
            //}

            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Action), ref fieldValue) &&
                (fieldValue == PermissionAction.DeleteShop.ToString() ||
                 fieldValue == PermissionAction.AddShop.ToString()))
            {
                ItemsPanel.Hide();
                
                
            }

            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Date), ref fieldValue))
            {
                string dateVal = fieldValue.Replace(":", "/");
                TimeAndDateTextBox.Text += $"Дата: {dateVal}\t";
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Time), ref fieldValue))
            {
                TimeAndDateTextBox.Text += $"Время: {fieldValue}";
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Shop), ref fieldValue))
            {
                ShopNameTextBox.Text = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Action), ref fieldValue))
            {
                ActionTypeTextBox.Text = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.item_name), ref fieldValue))
            {
                ItemNameTextBox.Text = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.item_description), ref fieldValue))
            {
                ItemDescriptionRichTextBox.Text = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.price), ref fieldValue))
            {
                ItemPriceTextBox.Text = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.amount_in_stock), ref fieldValue))
            {
                AmountInStockTextBox.Text = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.category), ref fieldValue))
            {
                ItemCategoryTextBox.Text = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.item_image), ref fieldValue))
            {
                ItemPicture.Image = Image.FromFile(AdminHelper.NoImageFoundPicturePath);

                string itemPath = fieldValue;
                if (itemPath != null && File.Exists(itemPath))
                {
                    ItemPicture.Image = Image.FromFile(itemPath);
                }
            }


        }

        private void SendPermissionButton_Click(object sender, EventArgs e)
        {
            db.OpenConnection();

            string action = "";

            if(!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.Action), ref action))
            {
               
            }

            if ("Отклонить".Equals(PermissionComboBox.Items[PermissionComboBox.SelectedIndex].ToString()))
            {
                ah.DeleteIDX(CurrentIndex);
                CurrentIndex = -1;
                MessageBox.Show("Запрос был отклонен");
                return;
            }



            string login = settings.GetLogin();

            string ShopName = ""; // check with db
            string itemName = "";
            string itemDescription = "";
            string itemCategory = "";
            string itemImage = "";
            string price = "";
            string amountInStock = "";

            if (!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.Shop), ref ShopName))
            {
                MessageBox.Show($"Не смогли прочитать поле - {AdminHelper.GetFieldName(EPermissionFields.Shop)} ");
            }
            if (!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.item_name), ref itemName))
            {
                MessageBox.Show($"Не смогли прочитать поле - {AdminHelper.GetFieldName(EPermissionFields.item_name)} ");
            }
            if (!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.item_description), ref itemDescription))
            {
                MessageBox.Show($"Не смогли прочитать поле - {AdminHelper.GetFieldName(EPermissionFields.item_description)} ");
            }
            if (!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.category), ref itemCategory))
            {
                MessageBox.Show($"Не смогли прочитать поле - {AdminHelper.GetFieldName(EPermissionFields.category)} ");
            }
            if (!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.item_image), ref itemImage))
            {
                MessageBox.Show($"Не смогли прочитать поле - {AdminHelper.GetFieldName(EPermissionFields.item_image)} ");
            }
            if (!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.price), ref price))
            {
                MessageBox.Show($"Не смогли прочитать поле - {AdminHelper.GetFieldName(EPermissionFields.price)} ");
            }
            if (!ah.GetFieldValueAtIndex(CurrentIndex, AdminHelper.GetFieldName(EPermissionFields.amount_in_stock), ref amountInStock))
            {
                MessageBox.Show($"Не смогли прочитать поле - {AdminHelper.GetFieldName(EPermissionFields.amount_in_stock)} ");
            }

            if (action == PermissionAction.AddItem.ToString())
            {
                AddItemImplementation(ShopName, itemName, itemDescription, itemCategory, itemImage, price, amountInStock);
            }
            else if(action == PermissionAction.ChangeItem.ToString())
            {
                ChangeItemImplementation(ShopName, itemName, itemDescription, itemCategory, itemImage, price, amountInStock);
            }
            else if (action == PermissionAction.DeleteItem.ToString())
            {
                DeleteItemImplementation(ShopName, itemName);
            }
        }

        void AddItemImplementation(
            string ShopName,
            string itemName,
            string itemDescription,
            string itemCategory,
            string itemImage,
            string price,
            string amountInStock)
        {
            uint categoryID = db.GetCategoryID(itemCategory);
            if (categoryID == 0) // category does not exist
            {
                string categoryCommandStr = $"INSERT INTO `categories` (`category_name`) VALUES('{itemCategory}')";
                MySqlCommand categoryCommand = new MySqlCommand(categoryCommandStr, db.GetConnection());

                db.OpenConnection();
                if (categoryCommand.ExecuteNonQuery() == 1)
                {
                    // success created category
                    categoryID = db.GetCategoryID(itemCategory);
                }
                else
                {
                    MessageBox.Show($"Категория {itemCategory} не была создана");
                }
                db.CloseConnection();
            }


            const string commandString = "INSERT INTO `items` (`shopID`, `item_name`, `item_description`, `price`, `amount_in_stock`, `categoryID`) VALUES (@shopID, @item_name, @item_description, @price, @amount_in_stock, @categoryID); ";
            MySqlCommand sqlCommand = new MySqlCommand(commandString, db.GetConnection());


            sqlCommand.Parameters.Add("@shopID", MySqlDbType.UInt32).Value = db.GetShopID(ShopName);
            sqlCommand.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = itemName;
            sqlCommand.Parameters.Add("@item_description", MySqlDbType.VarChar).Value = itemDescription;
            sqlCommand.Parameters.Add("@price", MySqlDbType.Double).Value = Double.Parse(price);
            sqlCommand.Parameters.Add("@amount_in_stock", MySqlDbType.UInt32).Value = UInt32.Parse(amountInStock);
            sqlCommand.Parameters.Add("@categoryID", MySqlDbType.UInt32).Value = (categoryID);

            db.CloseConnection();
            db.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                // success
                string imageCommandStr = "INSERT INTO `item_images` (`itemID`, `path_to_image`) VALUES(@itemID, @path_to_image)";
                MySqlCommand imageCommand = new MySqlCommand(imageCommandStr, db.GetConnection());

                uint itemID = db.GetItemID(itemName, db.GetShopID(ShopName));

                if (itemID == 0)
                {
                    MessageBox.Show("Запрос не был исполнене, ошибка");
                    return;
                }

                imageCommand.Parameters.Add("@itemID", MySqlDbType.UInt32).Value = itemID;
                imageCommand.Parameters.Add("@path_to_image", MySqlDbType.VarChar).Value = itemImage;

                db.CloseConnection();
                db.OpenConnection();

                if (imageCommand.ExecuteNonQuery() == 1)
                {
                    // success

                    MessageBox.Show("Запрос был одобрен");
                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Запрос не был исполнене, ошибка");
                }
                db.CloseConnection();


            }
            else
            {
                MessageBox.Show("Запрос не был исполнене, ошибка");
            }


            db.CloseConnection();
        }

        void ChangeItemImplementation(
            string ShopName,
            string itemName,
            string itemDescription,
            string itemCategory,
            string itemImage,
            string price,
            string amountInStock)
        {
            uint categoryID = db.GetCategoryID(itemCategory);
            if (categoryID == 0) // category does not exist
            {
                string categoryCommandStr = $"INSERT INTO `categories` (`category_name`) VALUES('{itemCategory}')";
                MySqlCommand categoryCommand = new MySqlCommand(categoryCommandStr, db.GetConnection());

                db.OpenConnection();
                if (categoryCommand.ExecuteNonQuery() == 1)
                {
                    // success created category
                    categoryID = db.GetCategoryID(itemCategory);
                }
                else
                {
                    MessageBox.Show($"Категория {itemCategory} не была создана");
                }
                db.CloseConnection();
            }


            const string commandString = "UPDATE `items` SET `item_name` = @item_name, `item_description` = @item_description, `price` = @price, `amount_in_stock` = @amount_in_stock, `categoryID` = @categoryID WHERE `itemID` = @itemID AND `shopID` = @shopID;";
            MySqlCommand sqlCommand = new MySqlCommand(commandString, db.GetConnection());

            // Non predictible behavior when changing item name // fix it

            sqlCommand.Parameters.Add("@itemID", MySqlDbType.UInt32).Value = db.GetItemID(itemName, db.GetShopID(ShopName));
            sqlCommand.Parameters.Add("@shopID", MySqlDbType.UInt32).Value = db.GetShopID(ShopName);
            sqlCommand.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = itemName;
            sqlCommand.Parameters.Add("@item_description", MySqlDbType.VarChar).Value = itemDescription;
            sqlCommand.Parameters.Add("@price", MySqlDbType.Double).Value = Double.Parse(price);
            sqlCommand.Parameters.Add("@amount_in_stock", MySqlDbType.UInt32).Value = UInt32.Parse(amountInStock);
            sqlCommand.Parameters.Add("@categoryID", MySqlDbType.UInt32).Value = (categoryID);

            db.CloseConnection();
            db.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                // success
                string imageCommandStr = "UPDATE `item_images` SET `path_to_image` = @path_to_image WHERE `itemID` = @itemID";
                MySqlCommand imageCommand = new MySqlCommand(imageCommandStr, db.GetConnection());

                uint itemID = db.GetItemID(itemName, db.GetShopID(ShopName));

                if (itemID == 0)
                {
                    MessageBox.Show("Запрос не был исполнене, ошибка");
                    return;
                }

                imageCommand.Parameters.Add("@itemID", MySqlDbType.UInt32).Value = itemID;
                imageCommand.Parameters.Add("@path_to_image", MySqlDbType.VarChar).Value = itemImage;

                db.CloseConnection();
                db.OpenConnection();

                if (imageCommand.ExecuteNonQuery() == 1)
                {
                    // success

                    MessageBox.Show("Запрос был одобрен");
                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Запрос не был исполнене, ошибка");
                }
                db.CloseConnection();


            }
            else
            {
                MessageBox.Show("Запрос не был исполнене, ошибка");
            }


            db.CloseConnection();
        }

        void DeleteItemImplementation(
            string ShopName,
            string itemName)
        {
            const string commandString = "DELETE FROM `items` WHERE `itemID` = @itemID AND `shopID` = @shopID;";
            MySqlCommand sqlCommand = new MySqlCommand(commandString, db.GetConnection());

            // Non predictible behavior when changing item name // fix it

            sqlCommand.Parameters.Add("@itemID", MySqlDbType.UInt32).Value = db.GetItemID(itemName, db.GetShopID(ShopName));
            sqlCommand.Parameters.Add("@shopID", MySqlDbType.UInt32).Value = db.GetShopID(ShopName);

            db.CloseConnection();
            db.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                // success
                string imageCommandStr = "DELETE FROM `item_images` WHERE `itemID` = @itemID";
                MySqlCommand imageCommand = new MySqlCommand(imageCommandStr, db.GetConnection());

                uint itemID = db.GetItemID(itemName, db.GetShopID(ShopName));

                if (itemID == 0)
                {
                    MessageBox.Show("Запрос не был исполнене, ошибка");
                    return;
                }

                imageCommand.Parameters.Add("@itemID", MySqlDbType.UInt32).Value = itemID;
                db.CloseConnection();
                db.OpenConnection();

                if (imageCommand.ExecuteNonQuery() == 1)
                {
                    // success

                    MessageBox.Show("Запрос был одобрен");
                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Запрос не был исполнене, ошибка");
                }
                db.CloseConnection();


            }
            else
            {
                MessageBox.Show("Запрос не был исполнене, ошибка");
            }


            db.CloseConnection();
        }
    }
}
