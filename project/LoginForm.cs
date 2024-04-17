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

namespace project
{
    public partial class LoginForm : Form
    {
        PRN211_ProjectContext _context = new();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public class Acc
        {
            public static string CurrentAcc = "";
            public static bool? Role = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var user = (from u in _context.Accounts
                        where u.Username == username && u.Password == password
                        select u).FirstOrDefault();
            
            if (username.Length > 0 && password.Length > 0)
            {
                if (user != null)
                {
                    Acc.CurrentAcc = username;
                    Acc.Role = user.Role;
                    //MessageBox.Show(Acc.CurrentAcc);
                    //MessageBox.Show(Acc.Role.ToString());
                    //MessageBox.Show("Login thành công.");
                    if (user.Role == true)
                    {
                        //MessageBox.Show(user.Role.ToString());
                        ProductManagement pm = new ProductManagement();
                        this.Hide();
                        pm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        ViewProduct vp = new ViewProduct();
                        this.Hide();
                        vp.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }
    }
}
