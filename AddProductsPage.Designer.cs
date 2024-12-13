namespace BikeStore
{
    partial class AddProductsPage
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
            SetItemNameTextBox = new TextBox();
            SetItemNameLable = new Label();
            SetItemDescriptionLable = new Label();
            SetItemDescriptionRichTextBox = new RichTextBox();
            SetItemPriceLable = new Label();
            SetItemPriceTextBox = new TextBox();
            SetItemInStockAmountLable = new Label();
            SetItemInStockAmountTextBox = new TextBox();
            SetItemCategoryLable = new Label();
            SetItemCategoryComboBox = new ComboBox();
            SetItemImagePictureBox = new PictureBox();
            SetItemImageLable = new Label();
            SelectItemImageButton = new Button();
            AddItemButton = new Button();
            CancelButton = new Button();
            menuStrip1 = new MenuStrip();
            отправленныеЗапросыToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)SetItemImagePictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(694, 62);
            label1.TabIndex = 2;
            label1.Text = "Страница добавления товаров";
            // 
            // SetItemNameTextBox
            // 
            SetItemNameTextBox.Location = new Point(12, 163);
            SetItemNameTextBox.Name = "SetItemNameTextBox";
            SetItemNameTextBox.Size = new Size(196, 27);
            SetItemNameTextBox.TabIndex = 3;
            // 
            // SetItemNameLable
            // 
            SetItemNameLable.AutoSize = true;
            SetItemNameLable.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetItemNameLable.Location = new Point(12, 125);
            SetItemNameLable.Name = "SetItemNameLable";
            SetItemNameLable.Size = new Size(196, 35);
            SetItemNameLable.TabIndex = 4;
            SetItemNameLable.Text = "Название товара";
            // 
            // SetItemDescriptionLable
            // 
            SetItemDescriptionLable.AutoSize = true;
            SetItemDescriptionLable.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetItemDescriptionLable.Location = new Point(12, 206);
            SetItemDescriptionLable.Name = "SetItemDescriptionLable";
            SetItemDescriptionLable.Size = new Size(201, 35);
            SetItemDescriptionLable.TabIndex = 5;
            SetItemDescriptionLable.Text = "Описание товара";
            // 
            // SetItemDescriptionRichTextBox
            // 
            SetItemDescriptionRichTextBox.Location = new Point(12, 244);
            SetItemDescriptionRichTextBox.Name = "SetItemDescriptionRichTextBox";
            SetItemDescriptionRichTextBox.Size = new Size(196, 296);
            SetItemDescriptionRichTextBox.TabIndex = 6;
            SetItemDescriptionRichTextBox.Text = "";
            // 
            // SetItemPriceLable
            // 
            SetItemPriceLable.AutoSize = true;
            SetItemPriceLable.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetItemPriceLable.Location = new Point(377, 125);
            SetItemPriceLable.Name = "SetItemPriceLable";
            SetItemPriceLable.Size = new Size(154, 35);
            SetItemPriceLable.TabIndex = 7;
            SetItemPriceLable.Text = "Цена товара";
            // 
            // SetItemPriceTextBox
            // 
            SetItemPriceTextBox.Location = new Point(377, 163);
            SetItemPriceTextBox.Name = "SetItemPriceTextBox";
            SetItemPriceTextBox.Size = new Size(196, 27);
            SetItemPriceTextBox.TabIndex = 8;
            // 
            // SetItemInStockAmountLable
            // 
            SetItemInStockAmountLable.AutoSize = true;
            SetItemInStockAmountLable.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetItemInStockAmountLable.Location = new Point(702, 125);
            SetItemInStockAmountLable.Name = "SetItemInStockAmountLable";
            SetItemInStockAmountLable.Size = new Size(248, 35);
            SetItemInStockAmountLable.TabIndex = 9;
            SetItemInStockAmountLable.Text = "Количество на складе";
            // 
            // SetItemInStockAmountTextBox
            // 
            SetItemInStockAmountTextBox.Location = new Point(702, 163);
            SetItemInStockAmountTextBox.Name = "SetItemInStockAmountTextBox";
            SetItemInStockAmountTextBox.Size = new Size(196, 27);
            SetItemInStockAmountTextBox.TabIndex = 10;
            // 
            // SetItemCategoryLable
            // 
            SetItemCategoryLable.AutoSize = true;
            SetItemCategoryLable.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetItemCategoryLable.Location = new Point(377, 206);
            SetItemCategoryLable.Name = "SetItemCategoryLable";
            SetItemCategoryLable.Size = new Size(134, 35);
            SetItemCategoryLable.TabIndex = 11;
            SetItemCategoryLable.Text = "Категория";
            // 
            // SetItemCategoryComboBox
            // 
            SetItemCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SetItemCategoryComboBox.FlatStyle = FlatStyle.System;
            SetItemCategoryComboBox.FormattingEnabled = true;
            SetItemCategoryComboBox.Location = new Point(380, 244);
            SetItemCategoryComboBox.Name = "SetItemCategoryComboBox";
            SetItemCategoryComboBox.Size = new Size(193, 28);
            SetItemCategoryComboBox.TabIndex = 12;
            // 
            // SetItemImagePictureBox
            // 
            SetItemImagePictureBox.Location = new Point(702, 284);
            SetItemImagePictureBox.Name = "SetItemImagePictureBox";
            SetItemImagePictureBox.Size = new Size(256, 256);
            SetItemImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SetItemImagePictureBox.TabIndex = 13;
            SetItemImagePictureBox.TabStop = false;
            // 
            // SetItemImageLable
            // 
            SetItemImageLable.AutoSize = true;
            SetItemImageLable.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetItemImageLable.Location = new Point(702, 206);
            SetItemImageLable.Name = "SetItemImageLable";
            SetItemImageLable.Size = new Size(238, 35);
            SetItemImageLable.TabIndex = 14;
            SetItemImageLable.Text = "Изображение товара";
            // 
            // SelectItemImageButton
            // 
            SelectItemImageButton.Location = new Point(702, 243);
            SelectItemImageButton.Name = "SelectItemImageButton";
            SelectItemImageButton.Size = new Size(196, 29);
            SelectItemImageButton.TabIndex = 15;
            SelectItemImageButton.Text = "Выбрать изображение";
            SelectItemImageButton.UseVisualStyleBackColor = true;
            SelectItemImageButton.Click += SelectItemImageButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(702, 577);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(256, 29);
            AddItemButton.TabIndex = 16;
            AddItemButton.Text = "Добавить товар";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(440, 577);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(256, 29);
            CancelButton.TabIndex = 17;
            CancelButton.Text = "Отменить изменения";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { отправленныеЗапросыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1040, 28);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // отправленныеЗапросыToolStripMenuItem
            // 
            отправленныеЗапросыToolStripMenuItem.Name = "отправленныеЗапросыToolStripMenuItem";
            отправленныеЗапросыToolStripMenuItem.Size = new Size(191, 24);
            отправленныеЗапросыToolStripMenuItem.Text = "Отправленные запросы";
            отправленныеЗапросыToolStripMenuItem.Click += отправленныеЗапросыToolStripMenuItem_Click;
            // 
            // AddProductsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 645);
            Controls.Add(CancelButton);
            Controls.Add(AddItemButton);
            Controls.Add(SelectItemImageButton);
            Controls.Add(SetItemImageLable);
            Controls.Add(SetItemImagePictureBox);
            Controls.Add(SetItemCategoryComboBox);
            Controls.Add(SetItemCategoryLable);
            Controls.Add(SetItemInStockAmountTextBox);
            Controls.Add(SetItemInStockAmountLable);
            Controls.Add(SetItemPriceTextBox);
            Controls.Add(SetItemPriceLable);
            Controls.Add(SetItemDescriptionRichTextBox);
            Controls.Add(SetItemDescriptionLable);
            Controls.Add(SetItemNameLable);
            Controls.Add(SetItemNameTextBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AddProductsPage";
            Text = "AddProductsPage";
            ((System.ComponentModel.ISupportInitialize)SetItemImagePictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SetItemNameTextBox;
        private Label SetItemNameLable;
        private Label SetItemDescriptionLable;
        private RichTextBox SetItemDescriptionRichTextBox;
        private Label SetItemPriceLable;
        private TextBox SetItemPriceTextBox;
        private Label SetItemInStockAmountLable;
        private TextBox SetItemInStockAmountTextBox;
        private Label SetItemCategoryLable;
        private ComboBox SetItemCategoryComboBox;
        private PictureBox SetItemImagePictureBox;
        private Label SetItemImageLable;
        private Button SelectItemImageButton;
        private Button AddItemButton;
        private Button CancelButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem отправленныеЗапросыToolStripMenuItem;
    }
}