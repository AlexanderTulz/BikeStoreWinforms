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
    public partial class StoreMainPage : Form
    {
        DB db = new DB();
        List<ItemObject> AllItems;
        CartHelper CartHelper = new CartHelper();

        public StoreMainPage()
        {
            InitializeComponent();

            AllItems = db.GetAllItems();

            foreach (var item in AllItems)
            {
                ItemsListBox.Items.Add(item.item_name);
            }

            ItemPanel.Hide();
        }

        private void OpenItemButton_Click(object sender, EventArgs e)
        {
            ItemPanel.Hide();
            int Index = ItemsListBox.SelectedIndex;

            if (Index == null || Index < 0 || Index > ItemsListBox.Items.Count) return;

            var Item = AllItems.ElementAt(Index);

            if (Item != null)
            {
                ItemPanel.Show();

                ItemNameLable.Text = $"Название : {Item.item_name}";
                ItemDescriptionRichTextBox.Text = $"{Item.item_description}";
                ItemPriceLable.Text = $"Цена : {Item.price}";
                AmountInStockLable.Text = $"Количество на складе : {Item.amountInStock}";
                ShopNameLable.Text = $"Магазин : {Item.shop_name}";
                CategoryLable.Text = $"Категория : {Item.category_name}";

                if (File.Exists(Item.pathToImage))
                {
                    //ItemPictureBox.Image = Image.FromFile(Item.pathToImage);
                    ItemPictureBox.Image = new Bitmap(Item.pathToImage);
                }
                else
                {
                    ItemPictureBox.Image = new Bitmap(AdminHelper.NoImageFoundPicturePath);
                }
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int Index = ItemsListBox.SelectedIndex;

            var Item = AllItems.ElementAt(Index);

            CartHelper.AddToCart(Item.itemID);

            MessageBox.Show("Товар был добавлен в корзину");
        }
    }
}
