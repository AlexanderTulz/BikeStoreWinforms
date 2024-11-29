using BikeStore.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class AddProductsPage : Form
    {
        public AddProductsPage()
        {
            InitializeComponent();
            debugButton.Click += DebugFunc;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            LoadSettings settings = new LoadSettings();
            DB db = new DB();

            string itemName = string.IsNullOrEmpty(SetItemNameTextBox.Text.ToString()) ? "" : SetItemNameTextBox.Text.ToString();
            string itemDescription = string.IsNullOrEmpty(SetItemDescriptionRichTextBox.Text.ToString()) ? "" : SetItemDescriptionRichTextBox.Text.ToString();
            double price = string.IsNullOrEmpty(SetItemPriceTextBox.Text.ToString()) ? -1.0 : Double.Parse(SetItemPriceTextBox.Text);
            int amountInStock = string.IsNullOrEmpty(SetItemInStockAmountTextBox.Text.ToString()) ? -1 : Int32.Parse(SetItemInStockAmountTextBox.Text.ToString());
            string category = string.IsNullOrEmpty(SetItemCategoryComboBox.Text.ToString()) ? "" : SetItemCategoryComboBox.Text.ToString();
            string itemIMGPath = "Make itWhenFinished";
            string shopName = db.GetShopName(settings.GetLogin());


            AdminHelper ah = new AdminHelper();
            ah.SendItemPermission(
                PermissionAction.AddItem,
                itemName,
                itemDescription,
                price,
                amountInStock,
                category,
                itemIMGPath,
                shopName);

            string val = "";

            //if (ah.GetParametersAtIndex(50, ref val))
            //{
            //    MessageBox.Show(val);
            //}

        }

        private void DebugFunc(object sender, EventArgs e)
        {
            string itemDesc = "";

            AdminHelper ah = new AdminHelper();
            if(ah.GetFieldValueAtIndex(48, "pricee", ref itemDesc))
            {
                MessageBox.Show(itemDesc);
            }
            else
            {
                MessageBox.Show("Sorry we didn't find such field");
            }
        }
    }
}
