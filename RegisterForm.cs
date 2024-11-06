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
    public partial class RegisterForm : Form
    {
        private const string DefaultUsernamMessage = "Введите имя";
        private const string DefaultSurnameMessage = "Введите Фамилью";
        private const string DefaultEmailMessage = "Введите почту";
        private const string DefaultLoginMessage = "Придумайте логин";

        // TODO: transition to LoginForm by clicking "я уже зарегистрирован"
        public RegisterForm()
        {
            InitializeComponent();

            RoleBox.Items.Add("Покупатель");
            RoleBox.Items.Add("Продавец");
            RoleBox.SelectedItem = RoleBox.Items[0];

            FirstNameField.Text = DefaultUsernamMessage;
            SecondNameField.Text = DefaultSurnameMessage;
            EmailField.Text = DefaultEmailMessage;
            LoginField.Text = DefaultLoginMessage;

            FirstNameField.ForeColor = Color.Gray;
            SecondNameField.ForeColor = Color.Gray;
            EmailField.ForeColor = Color.Gray;
            LoginField.ForeColor = Color.Gray;

            FirstNameField.Enter += OnEnterField;
            FirstNameField.Leave += OnLeaveField;

            SecondNameField.Enter += OnEnterField;
            SecondNameField.Leave += OnLeaveField;

            EmailField.Enter += OnEnterField;
            EmailField.Leave += OnLeaveField;

            LoginField.Enter += OnEnterField;
            LoginField.Leave += OnLeaveField;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DateTime dateTime = DateTime.Now;

            String name = FirstNameField.Text;
            String surname = SecondNameField.Text;
            String loginName = LoginField.Text;
            String password = PassField.Text;
            String email = EmailField.Text;
            String CurrentRole = (String)RoleBox.Items[RoleBox.SelectedIndex];
            String role = ((CurrentRole == "Продавец") ? "Seller" : "Customer");
            String date = dateTime.ToString("yyyy/MM/dd");

            // TODO: Add checkers so you can't enter more then a table value can handle in registration form

            if (CheckIfEmpty(name, "имени", DefaultUsernamMessage)) return;
            else if (CheckIfEmpty(surname, "фамилья", DefaultSurnameMessage)) return;
            else if (CheckIfEmpty(loginName, "логин", DefaultLoginMessage)) return;
            else if (CheckIfEmpty(password, "пароль", "")) return;
            else if (CheckIfEmpty(email, "почты", DefaultEmailMessage)) return;

            if (IsLoginExisting()) return;

            if (RoleBox.SelectedItem == null)
            {
                MessageBox.Show("Не указан роль акаунта!");
            }




            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `email`, `name`, `surname`, `role`, `created_at`) VALUES (@login, @password, @email, @name, @surname, @role, @date); ", db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginName;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@role", MySqlDbType.Enum).Value = role;
            command.Parameters.Add("@date", MySqlDbType.DateTime).Value = date;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
                this.Close();

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            db.CloseConnection();

        }

        private bool CheckIfEmpty(String checkField, String FieldName, String DefaultMessage)
        {
            if (string.IsNullOrEmpty(checkField) || checkField == DefaultMessage)
            {
                string ShowMessage = string.Format("Поле {0} пустая!", FieldName);

                MessageBox.Show(ShowMessage);

                return true;
            }

            return false;
        }

        public bool IsLoginExisting()
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой!");
                return true;
            }

            return false;

        }


        private void LockPicture_Click(object sender, EventArgs e)
        {
            PassField.UseSystemPasswordChar = !PassField.UseSystemPasswordChar;

            if (PassField.UseSystemPasswordChar)
                LockPicture.Image = Properties.Resources._lock;
            else
                LockPicture.Image = Properties.Resources.LockUnlocked;

        }

        private void OnEnterField(object sender, EventArgs e)
        {
            TextBox Field = (TextBox)sender;

            if (Field != null)
            {
                bool ShouldClearText = (Field.Text == DefaultUsernamMessage) ||
                                       (Field.Text == DefaultSurnameMessage) ||
                                       (Field.Text == DefaultEmailMessage) ||
                                       (Field.Text == DefaultLoginMessage);

                if (ShouldClearText)
                {
                    Field.Text = "";
                    Field.ForeColor = Color.Black;
                }
            }
            // I think here can be errors
        }

        private void OnLeaveField(object sender, EventArgs e)
        {
            TextBox Field = (TextBox)sender;

            if (Field != null && Field.Text == "")
            {
                if (FirstNameField != null && Field == FirstNameField)
                {
                    Field.Text = DefaultUsernamMessage;
                }
                else if (SecondNameField != null && Field == SecondNameField)
                {
                    Field.Text = DefaultSurnameMessage;
                }
                else if (LoginField != null && Field == LoginField)
                {
                    Field.Text = DefaultLoginMessage;
                }
                else if (EmailField != null && Field == EmailField)
                {
                    Field.Text = DefaultEmailMessage;
                }

                Field.ForeColor = Color.Gray;
            }
        }
    }
}
