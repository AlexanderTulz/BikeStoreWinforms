using BikeStore.HelperClasses;
using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        DB db = new DB();
        LoadSettings UserSettings;
        Form? CurrentForm;

        public MainForm()
        {
            InitializeComponent();
            UserSettings = new LoadSettings();

            int mainMenuStripIndex = MainFormMenuStrip.Items.IndexOfKey("дополнительноToolStripMenuItem");
            ToolStripMenuItem mainMenuStrip = (ToolStripMenuItem)MainFormMenuStrip.Items[mainMenuStripIndex];

            string commandString = "";

            db.OpenConnection();
            MySqlCommand sqlCommand = new MySqlCommand(commandString, db.GetConnection());

            bool isSellerWithRightPassword = 
                UserSettings.GetRole() == "Seller" &&                                                       // Check if role is seller
                db.GetUsersTableRole(UserSettings.GetLogin()) == UserSettings.GetRole() &&                  // Check if role matches settings
                db.GetUsersTablePassword(UserSettings.GetLogin()) == UserSettings.GetUserPassword() &&      // Check if actual password matches settings password
                db.GetIfLoginExistsFromUsersTable(UserSettings.GetLogin());                                 // Check if Login exists

            bool isAdminWithRightPassword =
                UserSettings.GetRole() == "Admin" &&                                                        // Check if role is seller
                db.GetUsersTableRole(UserSettings.GetLogin()) == UserSettings.GetRole() &&                  // Check if role matches settings
                db.GetUsersTablePassword(UserSettings.GetLogin()) == UserSettings.GetUserPassword() &&      // Check if actual password matches settings password
                db.GetIfLoginExistsFromUsersTable(UserSettings.GetLogin());                                 // Check if Login exists

            if (isSellerWithRightPassword)
            {
                ToolStripMenuItem AddProductProductsMenuItem = new ToolStripMenuItem("Страница добавления товаров");
                AddProductProductsMenuItem.Click += AddProductProductsPageClicked;
                mainMenuStrip.DropDownItems.Add(AddProductProductsMenuItem);
            }else if(isAdminWithRightPassword)
            {
                ToolStripMenuItem AdminPageMenuItem = new ToolStripMenuItem("Страница админа");
                AdminPageMenuItem.Click += AdminPageClicked;
                mainMenuStrip.DropDownItems.Add(AdminPageMenuItem);
            }

            db.CloseConnection();
        }

        private void AddProductProductsPageClicked(object sender, EventArgs e)
        {
            if (CurrentForm != null) CurrentForm.Hide();

            AddProductsPage StoreCartForm = new AddProductsPage() { TopLevel = false, TopMost = true };
            CurrentForm = StoreCartForm;

            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            ChildFormPanel.Controls.Add(CurrentForm);
            CurrentForm.Show();
        }

        private void AdminPageClicked(object sender, EventArgs e)
        {
            if(CurrentForm != null) CurrentForm.Hide();

            AdminPageForm adminPageForm = new AdminPageForm() { TopLevel = false, TopMost = true };
            CurrentForm = adminPageForm;

            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            ChildFormPanel.Controls.Add(CurrentForm);
            CurrentForm.Show();
        }

        void Acount()
        {
            bool LackOfUserInfo =
               string.IsNullOrEmpty(UserSettings.GetLogin()) ||
               string.IsNullOrEmpty(UserSettings.GetWhichUserIsLogged()) ||
               string.IsNullOrEmpty(UserSettings.GetUserPassword());

            if (LackOfUserInfo)
            {
                DialogResult dialogRes = MessageBox.Show("Зарегистрируйтесь, чтобы зайти в мой акаунт", "Нет акаунта", MessageBoxButtons.YesNo);

                if (dialogRes == DialogResult.Yes)
                {
                    RegisterForm registerForm = new RegisterForm();
                    registerForm.Show();
                }
            }
            else
            {
                db.OpenConnection();
                string name = db.GetUsersTableName(UserSettings.GetLogin());
                string password = db.GetUsersTablePassword(UserSettings.GetLogin());

                MessageBox.Show($"Name = {name}\nPassword = {password}");

                LoginForm loginForm = new LoginForm() { TopLevel = false, TopMost = true };
                loginForm.FormBorderStyle = FormBorderStyle.None;
                ChildFormPanel.Controls.Add(loginForm);
                loginForm.Show();

                db.CloseConnection();
            }
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentForm != null) CurrentForm.Hide();

            StoreMainPage storeMainPage = new StoreMainPage() { TopLevel = false, TopMost = true };
            CurrentForm = storeMainPage;

            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            ChildFormPanel.Controls.Add(CurrentForm);
            CurrentForm.Show();
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            if (CurrentForm != null) CurrentForm.Hide();

            CartForm StoreCartForm = new CartForm() { TopLevel = false, TopMost = true };
            CurrentForm = StoreCartForm;

            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            ChildFormPanel.Controls.Add(CurrentForm);
            CurrentForm.Show();
        }

        private void MyAccountButton_Click(object sender, EventArgs e)
        {
            if (CurrentForm != null) CurrentForm.Hide();

            MyAccountPage myAccountPage = new MyAccountPage() { TopLevel = false, TopMost = true };
            CurrentForm = myAccountPage;

            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            ChildFormPanel.Controls.Add(CurrentForm);
            CurrentForm.Show();
        }
    }
}
