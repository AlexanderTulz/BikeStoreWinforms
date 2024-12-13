using BikeStore.HelperClasses;
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
    public partial class AddProductsPage : Form
    {
        AdminHelper ah = new AdminHelper();
        string? itemImagePath;
        PermissionAction ButtonAction = PermissionAction.AddItem;

        public AddProductsPage()
        {
            InitializeComponent();
            //debugButton.Click += DebugFunc;

            List<ECategory> Categories = new List<ECategory>()
            {
                ECategory.MTB,
                ECategory.MTB_Downhill,
                ECategory.Gravel,
                ECategory.Fix,
                ECategory.Sport,
                ECategory.EBike,
                ECategory.Accessories,

            };
            foreach (var category in Categories) 
            {
                SetItemCategoryComboBox.Items.Add(category);
            }
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
            string itemIMGPath = itemImagePath;
            string shopName = db.GetShopName(settings.GetLogin());



            bool success = ah.SendItemPermission(
                ButtonAction,
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

            if (success)
            {
                MessageBox.Show("Запрос отправлен, в ближайщее время будет расмотрен и добавлен в магазин");
            }
            else
            {
                MessageBox.Show("Запрос не оправлен, пожалуйста попробуйте заново или позже");

            }
        }

        private void DebugFunc(object sender, EventArgs e)
        {
            string itemDesc = "";

            AdminHelper ah = new AdminHelper();
            if (ah.GetFieldValueAtIndex(48, "pricee", ref itemDesc))
            {
                MessageBox.Show(itemDesc);
            }
            else
            {
                MessageBox.Show("Sorry we didn't find such field");
            }
        }

        private void SelectItemImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;) | *.jpg; *.jpeg; *.gif; *.bmp; *.png;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                SetItemImagePictureBox.Image = new Bitmap(open.FileName);
                itemImagePath = AdminHelper.BasePath + @"\Images\IMG_" + ah.GetIndex().ToString() + ".png";

                File.Copy(open.FileName, itemImagePath, true);
            }
        }

        private void отправленныеЗапросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestForm RF = new RequestForm(this);
            RF.Show();
        }

        public void FillParameters(
            string itemName,
            string itemDescription,
            string price,
            string amountInStock,
            string category,
            string itemIMGPath)
        {
            SetItemNameTextBox.Text = itemName;
            SetItemDescriptionRichTextBox.Text = itemDescription;
            SetItemPriceTextBox.Text = price;
            SetItemInStockAmountTextBox.Text = amountInStock;

            int CategoryCurrentIndex = SetItemCategoryComboBox.SelectedIndex; // work with category it is not done

            if (File.Exists(itemIMGPath))
            {
                SetItemImagePictureBox.Image = new Bitmap(itemIMGPath);
            }
            else
            {
                SetItemImagePictureBox.Image = Image.FromFile(AdminHelper.NoImageFoundPicturePath);
            }

            AddItemButton.Text = "Добавить изменения";
            ButtonAction = PermissionAction.ChangeItem;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddItemButton.Text = "Добавить товар";

            SetItemNameTextBox.Text = string.Empty;
            SetItemDescriptionRichTextBox.Text = string.Empty;
            SetItemPriceTextBox.Text = string.Empty;
            SetItemInStockAmountTextBox.Text = string.Empty;
            SetItemImagePictureBox.Image = Image.FromFile(AdminHelper.NoImageFoundPicturePath);

            ButtonAction = PermissionAction.AddItem;

        }
    }
}
