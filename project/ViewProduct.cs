using project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class ViewProduct : Form
    {
        public static int height = 250;
        public static int width = 300;

        PRN211_ProjectContext _context = new();
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            Load_Product();
        }

        public async void Load_Product()
        {
            flpListProduct.Controls.Clear();
            List<Product> products = _context.Products.ToList();
            foreach (var item in products)
            {
                // Create container for each product
                Panel productPanel = new Panel();
                productPanel.Size = new Size(210, 250);
                productPanel.Margin = new Padding(10);
                // Handle the Paint event to draw border
                productPanel.Paint += (sender, e) =>
                {
                    ControlPaint.DrawBorder(e.Graphics, productPanel.ClientRectangle,
                        Color.FromArgb(255, 0, 0, 0), // Color of the border
                        ButtonBorderStyle.Solid); // Border style
                };

                // Create flow layout panel to hold picture box and label
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.Fill; // Fill the entire container
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown; // Arrange controls vertically

                // Load picture
                PictureBox pictureBoxFood = new PictureBox();
                pictureBoxFood.Size = new Size(200, 150);
                pictureBoxFood.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxFood.Margin = new Padding(5);
                LoadImageIntoPictureBox(pictureBoxFood, item.Picture);

                // Load label
                Label label = new Label();
                label.AutoSize = true;
                label.Margin = new Padding(5);
                label.Font = new Font(label.Font.FontFamily, 10, FontStyle.Bold);
                label.Text = item.ProductName;

                // Create button
                Button button = new Button();
                button.Text = "View Details";
                button.Size = new Size(100, 30);
                button.Margin = new Padding(5);
                // Attach click event handler
                button.Click += (sender, e) => ViewProductDetails(item);

                // Add picture box and label to the flow layout panel
                flowLayoutPanel.Controls.Add(pictureBoxFood);
                flowLayoutPanel.Controls.Add(label);
                flowLayoutPanel.Controls.Add(button);

                // Add the flow layout panel to the product panel
                productPanel.Controls.Add(flowLayoutPanel);

                // Add the product panel to the flow layout panel
                flpListProduct.Controls.Add(productPanel);
            }
        }

        private void ViewProductDetails(Product product)
        {
            // Handle button click event, e.g., show product details
            MessageBox.Show($"Viewing details for product: {product.ProductName}");
        }

        private async void LoadImageIntoPictureBox(PictureBox pictureBox, string imageUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = await webClient.DownloadDataTaskAsync(imageUrl);
                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        Image image = Image.FromStream(stream);
                        pictureBox.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

    }
}
