namespace project
{
    partial class AddProduct
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
            lbPrice = new Label();
            lbQuantity = new Label();
            lbCategory = new Label();
            lbProductName = new Label();
            lbDescription = new Label();
            lbPicture = new Label();
            txtProductName = new TextBox();
            txtPicture = new TextBox();
            txtDescription = new RichTextBox();
            btnAdd = new Button();
            cboCategory = new ComboBox();
            txtPrice = new TextBox();
            numQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(316, 23);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(121, 240);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(54, 25);
            lbPrice.TabIndex = 7;
            lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuantity.Location = new Point(121, 188);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(84, 25);
            lbQuantity.TabIndex = 6;
            lbQuantity.Text = "Quantity";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategory.Location = new Point(121, 135);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(88, 25);
            lbCategory.TabIndex = 5;
            lbCategory.Text = "Category";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductName.Location = new Point(121, 81);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(133, 25);
            lbProductName.TabIndex = 4;
            lbProductName.Text = "Product Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescription.Location = new Point(121, 352);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(108, 25);
            lbDescription.TabIndex = 9;
            lbDescription.Text = "Description";
            // 
            // lbPicture
            // 
            lbPicture.AutoSize = true;
            lbPicture.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbPicture.Location = new Point(121, 296);
            lbPicture.Name = "lbPicture";
            lbPicture.Size = new Size(71, 25);
            lbPicture.TabIndex = 8;
            lbPicture.Text = "Picture";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(300, 81);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(442, 33);
            txtProductName.TabIndex = 10;
            // 
            // txtPicture
            // 
            txtPicture.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPicture.Location = new Point(300, 293);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(442, 33);
            txtPicture.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(300, 352);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(442, 105);
            txtDescription.TabIndex = 13;
            txtDescription.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(356, 478);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 32);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(300, 135);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(221, 33);
            cboCategory.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(300, 237);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(161, 33);
            txtPrice.TabIndex = 17;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantity.Location = new Point(300, 186);
            numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(161, 33);
            numQuantity.TabIndex = 18;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(numQuantity);
            Controls.Add(txtPrice);
            Controls.Add(cboCategory);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtPicture);
            Controls.Add(txtProductName);
            Controls.Add(lbDescription);
            Controls.Add(lbPicture);
            Controls.Add(lbPrice);
            Controls.Add(lbQuantity);
            Controls.Add(lbCategory);
            Controls.Add(lbProductName);
            Controls.Add(label1);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbPrice;
        private Label lbQuantity;
        private Label lbCategory;
        private Label lbProductName;
        private Label lbDescription;
        private Label lbPicture;
        private TextBox txtProductName;
        private TextBox txtPicture;
        private RichTextBox txtDescription;
        private Button btnAdd;
        private ComboBox cboCategory;
        private TextBox txtPrice;
        private NumericUpDown numQuantity;
    }
}