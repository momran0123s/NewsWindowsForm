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
    public partial class ConfirmPassword : Form
    {
        Context db;
        int curId;
        public ConfirmPassword(int id)
        {
            InitializeComponent();
            db = new Context();
            curId = id;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Author author = db.Author.Find(curId);
            if (author.Password == txt_password.Text)
            {
                this.Hide();
                Profile profile = new Profile(curId);
                profile.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password isnt correct", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
