namespace project
{
    partial class ViewProduct
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
            tabViewProduct = new TabControl();
            tabHome = new TabPage();
            flpListProduct = new FlowLayoutPanel();
            tabOrder = new TabPage();
            tabViewProduct.SuspendLayout();
            tabHome.SuspendLayout();
            SuspendLayout();
            // 
            // tabViewProduct
            // 
            tabViewProduct.Controls.Add(tabHome);
            tabViewProduct.Controls.Add(tabOrder);
            tabViewProduct.Location = new Point(1, 12);
            tabViewProduct.Name = "tabViewProduct";
            tabViewProduct.SelectedIndex = 0;
            tabViewProduct.Size = new Size(975, 590);
            tabViewProduct.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(flpListProduct);
            tabHome.Location = new Point(4, 24);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(967, 562);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // flpListProduct
            // 
            flpListProduct.AutoScroll = true;
            flpListProduct.Location = new Point(7, 6);
            flpListProduct.Name = "flpListProduct";
            flpListProduct.Size = new Size(950, 550);
            flpListProduct.TabIndex = 0;
            // 
            // tabOrder
            // 
            tabOrder.Location = new Point(4, 24);
            tabOrder.Name = "tabOrder";
            tabOrder.Padding = new Padding(3);
            tabOrder.Size = new Size(962, 564);
            tabOrder.TabIndex = 1;
            tabOrder.Text = "Order";
            tabOrder.UseVisualStyleBackColor = true;
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 607);
            Controls.Add(tabViewProduct);
            Name = "ViewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewProduct";
            Load += ViewProduct_Load;
            tabViewProduct.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabViewProduct;
        private TabPage tabHome;
        private TabPage tabOrder;
        private FlowLayoutPanel flpListProduct;
    }
}