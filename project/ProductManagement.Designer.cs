namespace project
{
    partial class ProductManagement
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
            menuStrip1 = new MenuStrip();
            lbRole = new ToolStripMenuItem();
            accountInformationToolStripMenuItem = new ToolStripMenuItem();
            menuProfile = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            dgvProduct = new DataGridView();
            gbDetails = new GroupBox();
            lbProductID = new Label();
            txtProductID = new TextBox();
            numQuantity = new NumericUpDown();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddNew = new Button();
            txtDescription = new RichTextBox();
            txtPicture = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            lbDescription = new Label();
            lbPicture = new Label();
            lbUnitPrice = new Label();
            lbQuantity = new Label();
            lbProductName = new Label();
            txtProductSearch = new TextBox();
            cboCateSearch = new ComboBox();
            lbProductSearch = new Label();
            lbCateSearch = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lbRole, accountInformationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1230, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lbRole
            // 
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(42, 20);
            lbRole.Text = "Role";
            // 
            // accountInformationToolStripMenuItem
            // 
            accountInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuProfile, menuLogout });
            accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            accountInformationToolStripMenuItem.Size = new Size(130, 20);
            accountInformationToolStripMenuItem.Text = "Account information";
            // 
            // menuProfile
            // 
            menuProfile.Name = "menuProfile";
            menuProfile.Size = new Size(112, 22);
            menuProfile.Text = "Profile";
            menuProfile.Click += menuProfile_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(112, 22);
            menuLogout.Text = "Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 72);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(675, 470);
            dgvProduct.TabIndex = 1;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(lbProductID);
            gbDetails.Controls.Add(txtProductID);
            gbDetails.Controls.Add(numQuantity);
            gbDetails.Controls.Add(btnDelete);
            gbDetails.Controls.Add(btnUpdate);
            gbDetails.Controls.Add(btnAddNew);
            gbDetails.Controls.Add(txtDescription);
            gbDetails.Controls.Add(txtPicture);
            gbDetails.Controls.Add(txtUnitPrice);
            gbDetails.Controls.Add(txtProductName);
            gbDetails.Controls.Add(lbDescription);
            gbDetails.Controls.Add(lbPicture);
            gbDetails.Controls.Add(lbUnitPrice);
            gbDetails.Controls.Add(lbQuantity);
            gbDetails.Controls.Add(lbProductName);
            gbDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDetails.Location = new Point(693, 72);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(525, 470);
            gbDetails.TabIndex = 2;
            gbDetails.TabStop = false;
            gbDetails.Text = "Details";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductID.Location = new Point(27, 43);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(83, 21);
            lbProductID.TabIndex = 16;
            lbProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductID.Location = new Point(149, 40);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(100, 29);
            txtProductID.TabIndex = 15;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(149, 148);
            numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(159, 29);
            numQuantity.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(365, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(214, 425);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 37);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNew.Location = new Point(61, 425);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(110, 37);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(149, 313);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(347, 106);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            // 
            // txtPicture
            // 
            txtPicture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPicture.Location = new Point(149, 251);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(347, 29);
            txtPicture.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(149, 198);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(347, 29);
            txtUnitPrice.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(149, 93);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(347, 29);
            txtProductName.TabIndex = 5;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescription.Location = new Point(27, 311);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(89, 21);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "Description";
            // 
            // lbPicture
            // 
            lbPicture.AutoSize = true;
            lbPicture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPicture.Location = new Point(27, 254);
            lbPicture.Name = "lbPicture";
            lbPicture.Size = new Size(58, 21);
            lbPicture.TabIndex = 3;
            lbPicture.Text = "Picture";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUnitPrice.Location = new Point(27, 198);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(77, 21);
            lbUnitPrice.TabIndex = 2;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuantity.Location = new Point(27, 150);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(70, 21);
            lbQuantity.TabIndex = 1;
            lbQuantity.Text = "Quantity";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductName.Location = new Point(27, 96);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(110, 21);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductSearch.Location = new Point(128, 37);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(179, 29);
            txtProductSearch.TabIndex = 3;
            txtProductSearch.TextChanged += txtProductSearch_TextChanged;
            // 
            // cboCateSearch
            // 
            cboCateSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCateSearch.FormattingEnabled = true;
            cboCateSearch.Items.AddRange(new object[] { "All" });
            cboCateSearch.Location = new Point(426, 37);
            cboCateSearch.Name = "cboCateSearch";
            cboCateSearch.Size = new Size(145, 29);
            cboCateSearch.TabIndex = 4;
            cboCateSearch.SelectedValueChanged += cboCateSearch_SelectedValueChanged;
            // 
            // lbProductSearch
            // 
            lbProductSearch.AutoSize = true;
            lbProductSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductSearch.Location = new Point(12, 40);
            lbProductSearch.Name = "lbProductSearch";
            lbProductSearch.Size = new Size(110, 21);
            lbProductSearch.TabIndex = 17;
            lbProductSearch.Text = "Product Name";
            // 
            // lbCateSearch
            // 
            lbCateSearch.AutoSize = true;
            lbCateSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCateSearch.Location = new Point(347, 40);
            lbCateSearch.Name = "lbCateSearch";
            lbCateSearch.Size = new Size(73, 21);
            lbCateSearch.TabIndex = 18;
            lbCateSearch.Text = "Category";
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 554);
            Controls.Add(lbCateSearch);
            Controls.Add(lbProductSearch);
            Controls.Add(cboCateSearch);
            Controls.Add(txtProductSearch);
            Controls.Add(gbDetails);
            Controls.Add(dgvProduct);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductManagement";
            Load += ProductManagement_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lbRole;
        private ToolStripMenuItem accountInformationToolStripMenuItem;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuLogout;
        private DataGridView dgvProduct;
        private GroupBox gbDetails;
        private Label lbDescription;
        private Label lbPicture;
        private Label lbUnitPrice;
        private Label lbQuantity;
        private Label lbProductName;
        private RichTextBox txtDescription;
        private TextBox txtPicture;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNew;
        private NumericUpDown numQuantity;
        private TextBox txtProductID;
        private Label lbProductID;
        private TextBox txtProductSearch;
        private ComboBox cboCateSearch;
        private Label lbProductSearch;
        private Label lbCateSearch;
    }
}