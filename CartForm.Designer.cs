namespace BikeStore
{
    partial class CartForm
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
            CartLable = new Label();
            CartListBox = new ListBox();
            ItemsLable = new Label();
            RemoveItemFromCartButton = new Button();
            OrderItemsButton = new Button();
            ClearCartButton = new Button();
            SuspendLayout();
            // 
            // CartLable
            // 
            CartLable.AutoSize = true;
            CartLable.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point);
            CartLable.Location = new Point(242, 25);
            CartLable.Name = "CartLable";
            CartLable.Size = new Size(206, 71);
            CartLable.TabIndex = 1;
            CartLable.Text = "Корзина";
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 20;
            CartListBox.Location = new Point(12, 68);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(224, 364);
            CartListBox.TabIndex = 2;
            // 
            // ItemsLable
            // 
            ItemsLable.AutoSize = true;
            ItemsLable.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLable.Location = new Point(12, 25);
            ItemsLable.Name = "ItemsLable";
            ItemsLable.Size = new Size(224, 40);
            ItemsLable.TabIndex = 3;
            ItemsLable.Text = "Товары в корзине";
            // 
            // RemoveItemFromCartButton
            // 
            RemoveItemFromCartButton.Location = new Point(242, 322);
            RemoveItemFromCartButton.Name = "RemoveItemFromCartButton";
            RemoveItemFromCartButton.Size = new Size(200, 52);
            RemoveItemFromCartButton.TabIndex = 4;
            RemoveItemFromCartButton.Text = "Удалить вышестоящий товар";
            RemoveItemFromCartButton.UseVisualStyleBackColor = true;
            RemoveItemFromCartButton.Click += RemoveItemFromCartButton_Click;
            // 
            // OrderItemsButton
            // 
            OrderItemsButton.Location = new Point(242, 380);
            OrderItemsButton.Name = "OrderItemsButton";
            OrderItemsButton.Size = new Size(200, 52);
            OrderItemsButton.TabIndex = 5;
            OrderItemsButton.Text = "Купить";
            OrderItemsButton.UseVisualStyleBackColor = true;
            OrderItemsButton.Click += OrderItemsButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(242, 264);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(200, 52);
            ClearCartButton.TabIndex = 6;
            ClearCartButton.Text = "Очистить корзину";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(ClearCartButton);
            Controls.Add(OrderItemsButton);
            Controls.Add(RemoveItemFromCartButton);
            Controls.Add(ItemsLable);
            Controls.Add(CartListBox);
            Controls.Add(CartLable);
            Name = "CartForm";
            Text = "CartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CartLable;
        private ListBox CartListBox;
        private Label ItemsLable;
        private Button RemoveItemFromCartButton;
        private Button OrderItemsButton;
        private Button ClearCartButton;
    }
}