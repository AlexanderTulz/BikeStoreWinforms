namespace BikeStore
{
    partial class StoreMainPage
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
            ItemsListBox = new ListBox();
            OpenItemButton = new Button();
            ItemPictureBox = new PictureBox();
            ItemPriceLable = new Label();
            CategoryLable = new Label();
            ItemNameLable = new Label();
            ItemDescriptionRichTextBox = new RichTextBox();
            AmountInStockLable = new Label();
            ShopNameLable = new Label();
            ItemDescriptionLable = new Label();
            ItemPanel = new Panel();
            AddToCartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ItemPictureBox).BeginInit();
            ItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(12, 24);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(150, 364);
            ItemsListBox.TabIndex = 5;
            // 
            // OpenItemButton
            // 
            OpenItemButton.Location = new Point(12, 402);
            OpenItemButton.Name = "OpenItemButton";
            OpenItemButton.Size = new Size(150, 29);
            OpenItemButton.TabIndex = 6;
            OpenItemButton.Text = "Открыть товар";
            OpenItemButton.UseVisualStyleBackColor = true;
            OpenItemButton.Click += OpenItemButton_Click;
            // 
            // ItemPictureBox
            // 
            ItemPictureBox.Location = new Point(325, 46);
            ItemPictureBox.Name = "ItemPictureBox";
            ItemPictureBox.Size = new Size(312, 312);
            ItemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemPictureBox.TabIndex = 7;
            ItemPictureBox.TabStop = false;
            // 
            // ItemPriceLable
            // 
            ItemPriceLable.AutoSize = true;
            ItemPriceLable.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ItemPriceLable.Location = new Point(325, 360);
            ItemPriceLable.Name = "ItemPriceLable";
            ItemPriceLable.Size = new Size(185, 40);
            ItemPriceLable.TabIndex = 8;
            ItemPriceLable.Text = "Цена : 00000";
            // 
            // CategoryLable
            // 
            CategoryLable.AutoSize = true;
            CategoryLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryLable.Location = new Point(17, 12);
            CategoryLable.Name = "CategoryLable";
            CategoryLable.Size = new Size(300, 30);
            CategoryLable.TabIndex = 9;
            CategoryLable.Text = "Категория : категория длиннее";
            // 
            // ItemNameLable
            // 
            ItemNameLable.AutoSize = true;
            ItemNameLable.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ItemNameLable.Location = new Point(325, 12);
            ItemNameLable.Name = "ItemNameLable";
            ItemNameLable.Size = new Size(320, 31);
            ItemNameLable.TabIndex = 10;
            ItemNameLable.Text = "Название : что то крутое там";
            // 
            // ItemDescriptionRichTextBox
            // 
            ItemDescriptionRichTextBox.Location = new Point(17, 109);
            ItemDescriptionRichTextBox.Name = "ItemDescriptionRichTextBox";
            ItemDescriptionRichTextBox.ReadOnly = true;
            ItemDescriptionRichTextBox.Size = new Size(302, 229);
            ItemDescriptionRichTextBox.TabIndex = 11;
            ItemDescriptionRichTextBox.Text = "";
            // 
            // AmountInStockLable
            // 
            AmountInStockLable.AutoSize = true;
            AmountInStockLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AmountInStockLable.Location = new Point(17, 46);
            AmountInStockLable.Name = "AmountInStockLable";
            AmountInStockLable.Size = new Size(268, 30);
            AmountInStockLable.TabIndex = 12;
            AmountInStockLable.Text = "Количество на складе : 100";
            // 
            // ShopNameLable
            // 
            ShopNameLable.AutoSize = true;
            ShopNameLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ShopNameLable.Location = new Point(17, 76);
            ShopNameLable.Name = "ShopNameLable";
            ShopNameLable.Size = new Size(273, 30);
            ShopNameLable.TabIndex = 13;
            ShopNameLable.Text = "Магазин : Название магазина";
            // 
            // ItemDescriptionLable
            // 
            ItemDescriptionLable.AutoSize = true;
            ItemDescriptionLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ItemDescriptionLable.Location = new Point(17, 341);
            ItemDescriptionLable.Name = "ItemDescriptionLable";
            ItemDescriptionLable.Size = new Size(171, 30);
            ItemDescriptionLable.TabIndex = 14;
            ItemDescriptionLable.Text = "Описание товара";
            // 
            // ItemPanel
            // 
            ItemPanel.Controls.Add(ItemDescriptionLable);
            ItemPanel.Controls.Add(AddToCartButton);
            ItemPanel.Controls.Add(CategoryLable);
            ItemPanel.Controls.Add(AmountInStockLable);
            ItemPanel.Controls.Add(ShopNameLable);
            ItemPanel.Controls.Add(ItemDescriptionRichTextBox);
            ItemPanel.Controls.Add(ItemPictureBox);
            ItemPanel.Controls.Add(ItemNameLable);
            ItemPanel.Controls.Add(ItemPriceLable);
            ItemPanel.Location = new Point(168, 12);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new Size(648, 435);
            ItemPanel.TabIndex = 15;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(325, 403);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(312, 29);
            AddToCartButton.TabIndex = 16;
            AddToCartButton.Text = "Добавить в корзину";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // StoreMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 453);
            Controls.Add(OpenItemButton);
            Controls.Add(ItemsListBox);
            Controls.Add(ItemPanel);
            Name = "StoreMainPage";
            Text = "StoreMainPage";
            ((System.ComponentModel.ISupportInitialize)ItemPictureBox).EndInit();
            ItemPanel.ResumeLayout(false);
            ItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox ItemsListBox;
        private Button OpenItemButton;
        private PictureBox ItemPictureBox;
        private Label ItemPriceLable;
        private Label CategoryLable;
        private Label ItemNameLable;
        private RichTextBox ItemDescriptionRichTextBox;
        private Label AmountInStockLable;
        private Label ShopNameLable;
        private Label ItemDescriptionLable;
        private Panel ItemPanel;
        private Button AddToCartButton;
    }
}