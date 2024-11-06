namespace BikeStore
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            EmailField = new TextBox();
            RoleBox = new ComboBox();
            LoginFormLabel = new Label();
            SecondNameField = new TextBox();
            FirstNameField = new TextBox();
            RegisterButton = new Button();
            PassField = new TextBox();
            LockPicture = new PictureBox();
            LoginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LockPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe Print", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(882, 166);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(EmailField);
            panel1.Controls.Add(RoleBox);
            panel1.Controls.Add(LoginFormLabel);
            panel1.Controls.Add(SecondNameField);
            panel1.Controls.Add(FirstNameField);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(PassField);
            panel1.Controls.Add(LockPicture);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 603);
            panel1.TabIndex = 1;
            // 
            // EmailField
            // 
            EmailField.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailField.Location = new Point(12, 317);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(388, 57);
            EmailField.TabIndex = 10;
            // 
            // RoleBox
            // 
            RoleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleBox.Location = new Point(476, 317);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(388, 28);
            RoleBox.TabIndex = 9;
            // 
            // LoginFormLabel
            // 
            LoginFormLabel.AutoSize = true;
            LoginFormLabel.Cursor = Cursors.Hand;
            LoginFormLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginFormLabel.Location = new Point(314, 566);
            LoginFormLabel.Name = "LoginFormLabel";
            LoginFormLabel.Size = new Size(244, 28);
            LoginFormLabel.TabIndex = 8;
            LoginFormLabel.Text = "Я уже зарегистрирован";
            // 
            // SecondNameField
            // 
            SecondNameField.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            SecondNameField.Location = new Point(12, 247);
            SecondNameField.Name = "SecondNameField";
            SecondNameField.Size = new Size(388, 57);
            SecondNameField.TabIndex = 7;
            // 
            // FirstNameField
            // 
            FirstNameField.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameField.Location = new Point(12, 175);
            FirstNameField.Name = "FirstNameField";
            FirstNameField.Size = new Size(388, 57);
            FirstNameField.TabIndex = 6;
            FirstNameField.Text = "Что то очень длинное, еще чуть чуть наверное, достаточно";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = SystemColors.ActiveBorder;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.FlatAppearance.BorderColor = Color.Black;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.ForeColor = SystemColors.ActiveCaptionText;
            RegisterButton.Location = new Point(231, 502);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(450, 61);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            PassField.Location = new Point(476, 247);
            PassField.Name = "PassField";
            PassField.Size = new Size(388, 57);
            PassField.TabIndex = 4;
            PassField.UseSystemPasswordChar = true;
            // 
            // LockPicture
            // 
            LockPicture.Cursor = Cursors.Hand;
            LockPicture.Image = Properties.Resources._lock;
            LockPicture.Location = new Point(406, 247);
            LockPicture.Name = "LockPicture";
            LockPicture.Size = new Size(64, 64);
            LockPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            LockPicture.TabIndex = 3;
            LockPicture.TabStop = false;
            LockPicture.Click += LockPicture_Click;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginField.Location = new Point(476, 175);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(388, 57);
            LoginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(406, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 166);
            panel2.TabIndex = 0;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 603);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LockPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button RegisterButton;
        private TextBox PassField;
        private PictureBox LockPicture;
        private TextBox LoginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox SecondNameField;
        private TextBox FirstNameField;
        private Label LoginFormLabel;
        private ComboBox RoleBox;
        private TextBox EmailField;
    }
}