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
using static project.ProductManagement;

namespace project
{
    public partial class AddProduct : Form
    {
        PRN211_ProjectContext _context = new();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal unitprice = 0;
            bool isErr = false;

            string err_empty = "Vui lòng điền đầy đủ thông tin";

            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtPicture.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show(err_empty);
                isErr = true;
            }
            else
            {
                // check price
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    isErr = true;
                    MessageBox.Show("Vui lòng nhập giá sản phẩm");
                }
                else if (decimal.TryParse(txtPrice.Text, out decimal number))
                {
                    unitprice = number;
                }
                else
                {
                    isErr = true;
                    MessageBox.Show("Sai định dạng Price");
                }

                int quantity = int.Parse(numQuantity.Value.ToString());
                int category_id = cboCategory.SelectedIndex + 1;

                MessageBox.Show(category_id.ToString());
                MessageBox.Show(numQuantity.ToString());

                if (!isErr)
                {
                    Product p = new Product
                    {
                        ProductName = txtProductName.Text,
                        CategoryId = category_id,
                        Quantity = quantity,
                        UnitPrice = unitprice,
                        Picture = txtPicture.Text,
                        Description = txtDescription.Text,

                    };
                    _context.Add(p);
                    _context.SaveChanges();
                    MessageBox.Show("Thêm sản phẩm thành công");
                }
                
            }


        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = _context.Categories.Select(e => e.CategoryName).ToList();
        }
    }
}
