using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static project.LoginForm;
using System.Text.RegularExpressions;

namespace project
{
    public partial class Profile : Form
    {
        PRN211_ProjectContext _context = new();

        string err_email = "";
        bool isErr = false;

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Load_Profile();
        }

        public void Load_Profile()
        {
            var account = (from a in _context.Accounts
                           where a.Username == Acc.CurrentAcc
                           select new
                           {
                               Username = a.Username,
                               Password = a.Password,
                               Email = a.Email,
                               Fullname = a.Fullname,
                               Address = a.Address,
                               //Phonenumber = a.Phonenumber
                           }).FirstOrDefault();
            //MessageBox.Show(account.Username + "\n" + account.Password + "\n" + account.Email + "\n" + account.Fullname + "\n" + account.Address + "\n" + account.Phonenumber);

            txtUsername.Text = account.Username;
            txtEmail.Text = account.Email;
            txtFullname.Text = account.Fullname;
            txtAddress.Text = account.Address;
            //txtPhonenumber.Text = account.Phonenumber;
        }

        public bool CheckEmail(string Email)
        {
            var email = (from e in _context.Accounts
                         where e.Email == Email
                         select e.Email
                            ).FirstOrDefault();
            if (email != null)
            {
                return true;
            }
            return false;
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            Account account = _context.Accounts.Find(txtUsername.Text);
            //MessageBox.Show(account.Username + "\n" + account.Password + "\n" + account.Email + "\n" + account.Fullname + "\n" + account.Address + "\n" + account.Phonenumber);

            // check Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                err_email = "Không bỏ trống email";
                isErr = true;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                err_email = "Sai định dạng email";
                isErr = true;
            }
            else if (CheckEmail(txtEmail.Text))
            {
                err_email = "Email đã tồn tại";
                isErr = true;
            }

            if (!isErr)
            {
                if (account != null)
                {
                    account.Email = txtEmail.Text;
                    account.Address = txtAddress.Text;
                    account.Fullname = txtFullname.Text;
                    account.Address = txtAddress.Text;
                    _context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                    Load_Profile();
                    btnSaveChange.Enabled = IsEmailChanged();
                }
            }
            else
            {
                MessageBox.Show(err_email);
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnSaveChange.Enabled = IsEmailChanged();
        }

        private bool IsEmailChanged()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                return false;
            }
            else
            {
                if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    return true;
                }
                else if (CheckEmail(txtEmail.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtFullname.Text))
            {
                btnSaveChange.Enabled = true;
            }
            btnSaveChange.Enabled = false;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                btnSaveChange.Enabled = true;
            }
            btnSaveChange.Enabled = false;
        }
    }
}
