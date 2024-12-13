namespace BikeStore
{
    partial class RequestForm
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
            RequestsListBox = new ListBox();
            OpenRequestButton = new Button();
            SuspendLayout();
            // 
            // RequestsListBox
            // 
            RequestsListBox.FormattingEnabled = true;
            RequestsListBox.ItemHeight = 20;
            RequestsListBox.Location = new Point(12, 12);
            RequestsListBox.Name = "RequestsListBox";
            RequestsListBox.Size = new Size(361, 384);
            RequestsListBox.TabIndex = 0;
            // 
            // OpenRequestButton
            // 
            OpenRequestButton.Location = new Point(12, 409);
            OpenRequestButton.Name = "OpenRequestButton";
            OpenRequestButton.Size = new Size(361, 29);
            OpenRequestButton.TabIndex = 1;
            OpenRequestButton.Text = "Открыть";
            OpenRequestButton.UseVisualStyleBackColor = true;
            OpenRequestButton.Click += OpenRequestButton_Click;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(OpenRequestButton);
            Controls.Add(RequestsListBox);
            Name = "RequestForm";
            Text = "RequestForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox RequestsListBox;
        private Button OpenRequestButton;
    }
}