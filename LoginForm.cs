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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, this.LoginField.Height);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginField.Text.ToString();
            String passwordUser = PassField.Text.ToString();

            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You are logged in");
            }
            else
            {
                MessageBox.Show("You are not logged in");

            }

            db.CloseConnection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PassField.UseSystemPasswordChar = !PassField.UseSystemPasswordChar;

            if (PassField.UseSystemPasswordChar)
                LockPicture.Image = Properties.Resources._lock;
            else
                LockPicture.Image = Properties.Resources.LockUnlocked;
        }
    }
}
