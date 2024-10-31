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

            
        }
    }
}
