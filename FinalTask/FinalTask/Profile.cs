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
    public partial class Profile : Form
    {
        Context db;
        int curId;
        public Profile(int id)
        {
            InitializeComponent();
            db = new Context();
            curId = id;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txt_name.Text = db.Author.FirstOrDefault(x => x.Id == curId)?.Name;
            txt_userName.Text = db.Author.FirstOrDefault(x => x.Id == curId)?.UserName;
            nud_age.Value = db.Author.FirstOrDefault(x => x.Id == curId).Age;
            txt_password.Text = db.Author.FirstOrDefault(x => x.Id == curId)?.Password;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Author curAuthor = db.Author.Find(curId);
            if (curAuthor != null)
            {
                curAuthor.Name = txt_name.Text;
                curAuthor.UserName = txt_userName.Text;
                curAuthor.Age = (int)nud_age.Value;
                curAuthor.Password = txt_password.Text;
                db.Update(curAuthor);
                db.SaveChanges();
                MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                CRUD cRUD = new CRUD(curId);
                cRUD.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("user not found", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfirmPassword confirmPassword = new ConfirmPassword(curId);
            confirmPassword.ShowDialog();
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
