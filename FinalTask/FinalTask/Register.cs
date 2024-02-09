using FinalTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class Register : Form
    {
        Context db;
        public Register()
        {
            InitializeComponent();
            db = new Context();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_userName.Text == "" || txt_password.Text == "" || nud_age.Value == 0)
            {
                MessageBox.Show("Please complete your info", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Author author = new Author()
                {
                    Name = txt_name.Text,
                    Age = (int)nud_age.Value,
                    UserName = txt_userName.Text,
                    Password = txt_password.Text,
                    JoinDate = DateTime.Now,
                };
                db.Author.Add(author);
                db.SaveChanges();
                MessageBox.Show("User Registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void check_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showPassword.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }
    }
}
