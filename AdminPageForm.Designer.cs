namespace BikeStore
{
    partial class AdminPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPageForm));
            PermissionListbox = new ListBox();
            OpenPermissionButton = new Button();
            DateAndTimeLable = new Label();
            ShopeLable = new Label();
            ActionLable = new Label();
            PermissionLable = new Label();
            TimeAndDateTextBox = new TextBox();
            ShopNameTextBox = new TextBox();
            ActionTypeTextBox = new TextBox();
            PermissionComboBox = new ComboBox();
            ItemsPanel = new Panel();
            AmountInStockTextBox = new TextBox();
            ItemPriceTextBox = new TextBox();
            ItemCategoryTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemImageLable = new Label();
            CategoryLable = new Label();
            ItemAmountInStockLable = new Label();
            ItemPriceLable = new Label();
            ItemNameLable = new Label();
            ItemDescriptionLable = new Label();
            ItemDescriptionRichTextBox = new RichTextBox();
            ItemPicture = new PictureBox();
            SendPermissionButton = new Button();
            ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPicture).BeginInit();
            SuspendLayout();
            // 
            // PermissionListbox
            // 
            PermissionListbox.HorizontalExtent = 5;
            PermissionListbox.HorizontalScrollbar = true;
            PermissionListbox.ItemHeight = 20;
            PermissionListbox.Location = new Point(12, 43);
            PermissionListbox.Name = "PermissionListbox";
            PermissionListbox.ScrollAlwaysVisible = true;
            PermissionListbox.Size = new Size(186, 624);
            PermissionListbox.TabIndex = 1;
            // 
            // OpenPermissionButton
            // 
            OpenPermissionButton.Location = new Point(12, 6);
            OpenPermissionButton.Name = "OpenPermissionButton";
            OpenPermissionButton.Size = new Size(186, 31);
            OpenPermissionButton.TabIndex = 2;
            OpenPermissionButton.Text = "Открыть запрос";
            OpenPermissionButton.UseVisualStyleBackColor = true;
            OpenPermissionButton.Click += OpenPermissionButton_Click;
            // 
            // DateAndTimeLable
            // 
            DateAndTimeLable.AutoSize = true;
            DateAndTimeLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DateAndTimeLable.Location = new Point(204, 43);
            DateAndTimeLable.Name = "DateAndTimeLable";
            DateAndTimeLable.Size = new Size(314, 30);
            DateAndTimeLable.TabIndex = 3;
            DateAndTimeLable.Text = "Дата и время отправки запроса";
            // 
            // ShopeLable
            // 
            ShopeLable.AutoSize = true;
            ShopeLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ShopeLable.Location = new Point(570, 43);
            ShopeLable.Name = "ShopeLable";
            ShopeLable.Size = new Size(86, 30);
            ShopeLable.TabIndex = 7;
            ShopeLable.Text = "Магазин";
            // 
            // ActionLable
            // 
            ActionLable.AutoSize = true;
            ActionLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ActionLable.Location = new Point(698, 43);
            ActionLable.Name = "ActionLable";
            ActionLable.Size = new Size(121, 30);
            ActionLable.TabIndex = 8;
            ActionLable.Text = "Тип запроса";
            // 
            // PermissionLable
            // 
            PermissionLable.AutoSize = true;
            PermissionLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PermissionLable.Location = new Point(841, 43);
            PermissionLable.Name = "PermissionLable";
            PermissionLable.Size = new Size(117, 30);
            PermissionLable.TabIndex = 9;
            PermissionLable.Text = "Разрешение";
            // 
            // TimeAndDateTextBox
            // 
            TimeAndDateTextBox.Location = new Point(204, 76);
            TimeAndDateTextBox.Name = "TimeAndDateTextBox";
            TimeAndDateTextBox.Size = new Size(314, 27);
            TimeAndDateTextBox.TabIndex = 10;
            // 
            // ShopNameTextBox
            // 
            ShopNameTextBox.Location = new Point(551, 76);
            ShopNameTextBox.Name = "ShopNameTextBox";
            ShopNameTextBox.Size = new Size(127, 27);
            ShopNameTextBox.TabIndex = 11;
            // 
            // ActionTypeTextBox
            // 
            ActionTypeTextBox.Location = new Point(698, 76);
            ActionTypeTextBox.Name = "ActionTypeTextBox";
            ActionTypeTextBox.Size = new Size(127, 27);
            ActionTypeTextBox.TabIndex = 12;
            // 
            // PermissionComboBox
            // 
            PermissionComboBox.FormattingEnabled = true;
            PermissionComboBox.Location = new Point(841, 76);
            PermissionComboBox.Name = "PermissionComboBox";
            PermissionComboBox.Size = new Size(117, 28);
            PermissionComboBox.TabIndex = 13;
            // 
            // ItemsPanel
            // 
            ItemsPanel.Controls.Add(AmountInStockTextBox);
            ItemsPanel.Controls.Add(ItemPriceTextBox);
            ItemsPanel.Controls.Add(ItemCategoryTextBox);
            ItemsPanel.Controls.Add(ItemNameTextBox);
            ItemsPanel.Controls.Add(ItemImageLable);
            ItemsPanel.Controls.Add(CategoryLable);
            ItemsPanel.Controls.Add(ItemAmountInStockLable);
            ItemsPanel.Controls.Add(ItemPriceLable);
            ItemsPanel.Controls.Add(ItemNameLable);
            ItemsPanel.Controls.Add(ItemDescriptionLable);
            ItemsPanel.Controls.Add(ItemDescriptionRichTextBox);
            ItemsPanel.Controls.Add(ItemPicture);
            ItemsPanel.Location = new Point(204, 109);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(754, 522);
            ItemsPanel.TabIndex = 14;
            // 
            // AmountInStockTextBox
            // 
            AmountInStockTextBox.Location = new Point(356, 106);
            AmountInStockTextBox.Name = "AmountInStockTextBox";
            AmountInStockTextBox.Size = new Size(329, 27);
            AmountInStockTextBox.TabIndex = 26;
            // 
            // ItemPriceTextBox
            // 
            ItemPriceTextBox.Location = new Point(21, 106);
            ItemPriceTextBox.Name = "ItemPriceTextBox";
            ItemPriceTextBox.Size = new Size(329, 27);
            ItemPriceTextBox.TabIndex = 25;
            // 
            // ItemCategoryTextBox
            // 
            ItemCategoryTextBox.Location = new Point(356, 43);
            ItemCategoryTextBox.Name = "ItemCategoryTextBox";
            ItemCategoryTextBox.Size = new Size(329, 27);
            ItemCategoryTextBox.TabIndex = 24;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(21, 43);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(329, 27);
            ItemNameTextBox.TabIndex = 22;
            // 
            // ItemImageLable
            // 
            ItemImageLable.AutoSize = true;
            ItemImageLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemImageLable.Location = new Point(494, 186);
            ItemImageLable.Name = "ItemImageLable";
            ItemImageLable.Size = new Size(204, 30);
            ItemImageLable.TabIndex = 20;
            ItemImageLable.Text = "Изображение товара";
            // 
            // CategoryLable
            // 
            CategoryLable.AutoSize = true;
            CategoryLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLable.Location = new Point(356, 10);
            CategoryLable.Name = "CategoryLable";
            CategoryLable.Size = new Size(113, 30);
            CategoryLable.TabIndex = 19;
            CategoryLable.Text = "Категория";
            // 
            // ItemAmountInStockLable
            // 
            ItemAmountInStockLable.AutoSize = true;
            ItemAmountInStockLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemAmountInStockLable.Location = new Point(356, 73);
            ItemAmountInStockLable.Name = "ItemAmountInStockLable";
            ItemAmountInStockLable.Size = new Size(213, 30);
            ItemAmountInStockLable.TabIndex = 18;
            ItemAmountInStockLable.Text = "Количество на складе";
            // 
            // ItemPriceLable
            // 
            ItemPriceLable.AutoSize = true;
            ItemPriceLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemPriceLable.Location = new Point(21, 73);
            ItemPriceLable.Name = "ItemPriceLable";
            ItemPriceLable.Size = new Size(57, 30);
            ItemPriceLable.TabIndex = 17;
            ItemPriceLable.Text = "Цена";
            // 
            // ItemNameLable
            // 
            ItemNameLable.AutoSize = true;
            ItemNameLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNameLable.Location = new Point(21, 10);
            ItemNameLable.Name = "ItemNameLable";
            ItemNameLable.Size = new Size(167, 30);
            ItemNameLable.TabIndex = 16;
            ItemNameLable.Text = "Название товара";
            // 
            // ItemDescriptionLable
            // 
            ItemDescriptionLable.AutoSize = true;
            ItemDescriptionLable.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemDescriptionLable.Location = new Point(143, 186);
            ItemDescriptionLable.Name = "ItemDescriptionLable";
            ItemDescriptionLable.Size = new Size(171, 30);
            ItemDescriptionLable.TabIndex = 15;
            ItemDescriptionLable.Text = "Описание товара";
            // 
            // ItemDescriptionRichTextBox
            // 
            ItemDescriptionRichTextBox.Location = new Point(3, 219);
            ItemDescriptionRichTextBox.Name = "ItemDescriptionRichTextBox";
            ItemDescriptionRichTextBox.Size = new Size(442, 300);
            ItemDescriptionRichTextBox.TabIndex = 1;
            ItemDescriptionRichTextBox.Text = "";
            // 
            // ItemPicture
            // 
            ItemPicture.Image = (Image)resources.GetObject("ItemPicture.Image");
            ItemPicture.Location = new Point(451, 219);
            ItemPicture.Name = "ItemPicture";
            ItemPicture.Size = new Size(300, 300);
            ItemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemPicture.TabIndex = 0;
            ItemPicture.TabStop = false;
            // 
            // SendPermissionButton
            // 
            SendPermissionButton.Location = new Point(207, 638);
            SendPermissionButton.Name = "SendPermissionButton";
            SendPermissionButton.Size = new Size(442, 29);
            SendPermissionButton.TabIndex = 15;
            SendPermissionButton.Text = "Отправить запрос";
            SendPermissionButton.UseVisualStyleBackColor = true;
            SendPermissionButton.Click += SendPermissionButton_Click;
            // 
            // AdminPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(SendPermissionButton);
            Controls.Add(ItemsPanel);
            Controls.Add(PermissionComboBox);
            Controls.Add(ActionTypeTextBox);
            Controls.Add(ShopNameTextBox);
            Controls.Add(TimeAndDateTextBox);
            Controls.Add(PermissionLable);
            Controls.Add(ActionLable);
            Controls.Add(ShopeLable);
            Controls.Add(DateAndTimeLable);
            Controls.Add(OpenPermissionButton);
            Controls.Add(PermissionListbox);
            Name = "AdminPageForm";
            Text = "AdminPageForm";
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox PermissionListbox;
        private Button OpenPermissionButton;
        private Label DateAndTimeLable;
        private Label ShopeLable;
        private Label ActionLable;
        private Label PermissionLable;
        private TextBox TimeAndDateTextBox;
        private TextBox ShopNameTextBox;
        private TextBox ActionTypeTextBox;
        private ComboBox PermissionComboBox;
        private Panel ItemsPanel;
        private PictureBox ItemPicture;
        private Label ItemDescriptionLable;
        private RichTextBox ItemDescriptionRichTextBox;
        private TextBox ItemNameTextBox;
        private Label ItemImageLable;
        private Label CategoryLable;
        private Label ItemAmountInStockLable;
        private Label ItemPriceLable;
        private Label ItemNameLable;
        private TextBox AmountInStockTextBox;
        private TextBox ItemPriceTextBox;
        private TextBox ItemCategoryTextBox;
        private Button SendPermissionButton;
    }
}