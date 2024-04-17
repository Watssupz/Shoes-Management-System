using Microsoft.VisualBasic.ApplicationServices;
using project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project.LoginForm;

namespace project
{
    public partial class ProductManagement : Form
    {
        PRN211_ProjectContext _context = new();
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            if (Acc.Role == true)
            {
                lbRole.Text = Acc.CurrentAcc + "[Manager]";
            }
            else
            {
                lbRole.Text = Acc.CurrentAcc;
            }
            Load_Product();
            Load_Categories();
        }

        public void Load_Product()
        {
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.DataSource = (from p in _context.Products
                                     join c in _context.Categories on p.CategoryId equals c.CategoryId
                                     select new
                                     {
                                         ProductId = p.ProductId,
                                         CategoryName = c.CategoryName,
                                         ProductName = p.ProductName,
                                         Quantity = p.Quantity,
                                         UnitPrice = p.UnitPrice,
                                         Picture = p.Picture,
                                         Description = p.Description,
                                     }).ToList();
        }

        public void Load_Categories()
        {
            var categories = (from c in _context.Categories
                              select c.CategoryName).ToList();
            categories.Insert(0, "All");
            cboCateSearch.DataSource = categories;

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selected = dgvProduct.Rows[e.RowIndex];
            txtProductID.Text = selected.Cells["ProductId"].Value.ToString();
            txtProductName.Text = selected.Cells["ProductName"].Value.ToString();
            numQuantity.Text = selected.Cells["Quantity"].Value.ToString();
            txtUnitPrice.Text = selected.Cells["UnitPrice"].Value.ToString();
            txtPicture.Text = selected.Cells["Picture"].Value.ToString();
            txtDescription.Text = selected.Cells["Description"].Value.ToString();
        }

        // View Profile
        private void menuProfile_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        // Logout
        private void menuLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Close();
            lf.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(txtProductID.Text);

            decimal unitprice = 0;
            bool isErr = false;

            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtUnitPrice.Text) || string.IsNullOrEmpty(txtPicture.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                isErr = true;
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                // check price
                if (string.IsNullOrEmpty(txtUnitPrice.Text))
                {
                    isErr = true;
                    MessageBox.Show("Vui lòng nhập giá sản phẩm");
                }
                else if (decimal.TryParse(txtUnitPrice.Text, out decimal number))
                {
                    unitprice = number;
                }
                else
                {
                    isErr = true;
                    MessageBox.Show("Sai định dạng Price");
                }
            }

            if (!isErr)
            {
                Product p = _context.Products.FirstOrDefault(e => e.ProductId == pid);
                if (p != null)
                {
                    MessageBox.Show(p.ProductId.ToString());
                    MessageBox.Show(txtProductName.Text);

                    p.ProductName = txtProductName.Text;
                    p.Quantity = (int)numQuantity.Value;
                    p.UnitPrice = unitprice;
                    p.Picture = txtPicture.Text;
                    p.Description = txtDescription.Text;
                    _context.SaveChanges();
                    Load_Product();
                    MessageBox.Show("Cập nhật sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("nullllll");
                }
            }

        }

        public void Filter()
        {
            string ProductName = txtProductSearch.Text.Trim();
            string Category = cboCateSearch.Text.Trim();
            int CategoryID = 0;

            if (!Category.Equals("All"))
            {
                CategoryID = _context.Categories
                          .Where(c => c.CategoryName == Category)
                          .Select(c => c.CategoryId)
                          .FirstOrDefault();
            }

            var search = (from p in _context.Products
                          where (ProductName == "" || p.ProductName.Contains(ProductName)) &&
                                (CategoryID == 0 || p.CategoryId == CategoryID)
                          select new
                          {
                              ProductId = p.ProductId,
                              ProductName = p.ProductName,
                              Quantity = p.Quantity,
                              UnitPrice = p.UnitPrice,
                              Picture = p.Picture,
                              Description = p.Description
                          }).ToList();

            dgvProduct.DataSource = search;

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cboCateSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int product_id = int.Parse(txtProductID.Text);
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Product product = _context.Products.Find(product_id);
                _context.Remove(product);
                _context.SaveChanges();
                Load_Product();
            }
        }
    }
}
