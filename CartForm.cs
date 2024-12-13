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
    public partial class CartForm : Form
    {
        CartHelper cartHelper = new CartHelper();
        DB db = new DB();

        List<int> CartIds = new List<int>();

        public CartForm()
        {
            InitializeComponent();
            CartIds = cartHelper.GetItemIndexesInCart();
            SeeAndSetCart();
        }

        private void SeeAndSetCart()
        {
            CartListBox.Items.Clear();
            CartIds.Clear();
            CartIds = cartHelper.GetItemIndexesInCart();

            var itemIds = cartHelper.GetItemIndexesInCart();
            var allItems = db.GetAllItems();

            for (int i = 0; i < itemIds.Count; i++)
            {
                for (int j = 0; j < allItems.Count; j++)
                {
                    if (itemIds.ElementAt(i).Equals(allItems[j].itemID))
                    {
                        CartListBox.Items.Add(allItems[j].item_name);
                    }
                }
            }
        }

        private void RemoveItemFromCartButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count <= 0) return;

            CartListBox.Focus();
            CartListBox.SetSelected(0, true);
            cartHelper.RemoveFromCartLine(1);

            SeeAndSetCart();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            foreach (var item in CartListBox.Items)
            {
                cartHelper.RemoveFromCartLine(1);
            }

            SeeAndSetCart();
        }

        private void OrderItemsButton_Click(object sender, EventArgs e)
        {
            cartHelper.OrderItems(db);

            SeeAndSetCart();

            MessageBox.Show("Вы успешно купили товары!");
        }
    }
}
