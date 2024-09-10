namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstFruit = new System.Windows.Forms.ListBox();
            btnAdd = new Button();
            txtNewFruit = new TextBox();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstFruit
            // 
            lstFruit.FormattingEnabled = true;
            lstFruit.ItemHeight = 15;
            lstFruit.Items.AddRange(new object[] { "apple", "orange", "banana" });
            lstFruit.Location = new Point(129, 103);
            lstFruit.Name = "lstFruit";
            lstFruit.Size = new Size(116, 94);
            lstFruit.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNewFruit
            // 
            txtNewFruit.Location = new Point(129, 239);
            txtNewFruit.Name = "txtNewFruit";
            txtNewFruit.Size = new Size(116, 23);
            txtNewFruit.TabIndex = 2;
            txtNewFruit.KeyDown += txtNewFruit_KeyDown;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 85);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "List of Fruits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 225);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "New Fruit:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(txtNewFruit);
            Controls.Add(btnAdd);
            Controls.Add(lstFruit);
            Name = "Form1";
            Text = "Fruit List";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstFruit;
        private Button btnAdd;
        private TextBox txtNewFruit;
        private Button btnDelete;
        private Label label1;
        private Label label2;
    }
}
