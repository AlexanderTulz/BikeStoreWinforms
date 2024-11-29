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
            label1 = new Label();
            listBox1 = new ListBox();
            listView1 = new ListView();
            treeView1 = new TreeView();
            vScrollBar1 = new VScrollBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 161);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(196, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(330, 253);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 121);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(487, 253);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(151, 121);
            treeView1.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(122, 346);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(147, 125);
            vScrollBar1.TabIndex = 4;
            // 
            // AdminPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(vScrollBar1);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "AdminPageForm";
            Text = "AdminPageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private ListView listView1;
        private TreeView treeView1;
        private VScrollBar vScrollBar1;
    }
}