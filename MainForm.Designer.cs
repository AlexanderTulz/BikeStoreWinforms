namespace BikeStore
{
    partial class MainForm
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
            MainPageButton = new Button();
            ChildFormPanel = new Panel();
            ButtonsPanel = new Panel();
            MyAccountButton = new Button();
            CartButton = new Button();
            MainFormMenuStrip = new MenuStrip();
            дополнительноToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            ButtonsPanel.SuspendLayout();
            MainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainPageButton
            // 
            MainPageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MainPageButton.BackColor = SystemColors.ActiveCaption;
            MainPageButton.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MainPageButton.ForeColor = SystemColors.ActiveCaptionText;
            MainPageButton.Location = new Point(3, 3);
            MainPageButton.Name = "MainPageButton";
            MainPageButton.Size = new Size(196, 43);
            MainPageButton.TabIndex = 0;
            MainPageButton.Text = "Главная страница";
            MainPageButton.UseVisualStyleBackColor = false;
            MainPageButton.Click += MainPageButton_Click;
            // 
            // ChildFormPanel
            // 
            ChildFormPanel.Location = new Point(220, 30);
            ChildFormPanel.Name = "ChildFormPanel";
            ChildFormPanel.Size = new Size(1030, 631);
            ChildFormPanel.TabIndex = 1;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(MyAccountButton);
            ButtonsPanel.Controls.Add(CartButton);
            ButtonsPanel.Controls.Add(MainPageButton);
            ButtonsPanel.Location = new Point(12, 30);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(202, 631);
            ButtonsPanel.TabIndex = 0;
            // 
            // MyAccountButton
            // 
            MyAccountButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MyAccountButton.BackColor = SystemColors.ActiveCaption;
            MyAccountButton.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MyAccountButton.ForeColor = SystemColors.ActiveCaptionText;
            MyAccountButton.Location = new Point(3, 101);
            MyAccountButton.Name = "MyAccountButton";
            MyAccountButton.Size = new Size(196, 43);
            MyAccountButton.TabIndex = 2;
            MyAccountButton.Text = "Мой акаунт";
            MyAccountButton.UseVisualStyleBackColor = false;
            MyAccountButton.Click += MyAccountButton_Click;
            // 
            // CartButton
            // 
            CartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CartButton.BackColor = SystemColors.ActiveCaption;
            CartButton.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CartButton.ForeColor = SystemColors.ActiveCaptionText;
            CartButton.Location = new Point(3, 52);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(196, 43);
            CartButton.TabIndex = 1;
            CartButton.Text = "Корзина";
            CartButton.UseVisualStyleBackColor = false;
            CartButton.Click += CartButton_Click;
            // 
            // MainFormMenuStrip
            // 
            MainFormMenuStrip.ImageScalingSize = new Size(20, 20);
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { дополнительноToolStripMenuItem });
            MainFormMenuStrip.Location = new Point(0, 0);
            MainFormMenuStrip.Name = "MainFormMenuStrip";
            MainFormMenuStrip.Size = new Size(1262, 28);
            MainFormMenuStrip.TabIndex = 2;
            MainFormMenuStrip.Text = "menuStrip1";
            // 
            // дополнительноToolStripMenuItem
            // 
            дополнительноToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поискToolStripMenuItem });
            дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            дополнительноToolStripMenuItem.Size = new Size(134, 24);
            дополнительноToolStripMenuItem.Text = "Дополнительно";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(224, 26);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(ButtonsPanel);
            Controls.Add(ChildFormPanel);
            Controls.Add(MainFormMenuStrip);
            Name = "MainForm";
            Text = "MainForm";
            ButtonsPanel.ResumeLayout(false);
            MainFormMenuStrip.ResumeLayout(false);
            MainFormMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainPageButton;
        private Panel ChildFormPanel;
        private Panel ButtonsPanel;
        private Button CartButton;
        private Button MyAccountButton;
        private MenuStrip MainFormMenuStrip;
        private ToolStripMenuItem дополнительноToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
    }
}