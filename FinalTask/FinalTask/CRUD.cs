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
    public partial class CRUD : Form
    {
        Context db;
        int curId;
        public CRUD(int id)
        {
            InitializeComponent();
            db = new Context();
            curId = id;
        }
        private void display()
        {
            dgv_news.DataSource = db.News.Where(a => a.Auth_Id == curId).Select(x => new { x.Id, x.Title, x.Brief, x.Desc, x.Time, x.Date, x.Auth_Id, AuthName = x.AuthorObj.Name, x.Cat_Id, catName = x.CatalogObj.Name }).ToList();
            cb_catalog.DataSource = db.Catalog.ToList();
            cb_catalog.DisplayMember = "Name";
            cb_catalog.ValueMember = "Id";
            btn_add.Visible = true;
            btn_showAll.Visible = true;
            btn_updateNews.Visible = false;
            btn_showUser.Visible = false;
            btn_delete.Visible = false;
        }
        private void displayAll()
        {
            dgv_news.DataSource = db.News.Select(x => new { x.Id, x.Title, x.Brief, x.Desc, x.Time, x.Date, x.Auth_Id, AuthName = x.AuthorObj.Name, x.Cat_Id, catName = x.CatalogObj.Name }).ToList();
            cb_catalog.DataSource = db.Catalog.ToList();
            cb_catalog.DisplayMember = "Name";
            cb_catalog.ValueMember = "Id";
            btn_showUser.Visible = true;
            btn_showAll.Visible = false;
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_updateNews.Visible = false;
        }
        private void clearInput()
        {
            txt_title.Text = txt_brief.Text = txt_desc.Text = "";
        }
        private void CRUD_Load(object sender, EventArgs e)
        {
            display();
            clearInput();
        }

        TimeSpan curtime = DateTime.Now.TimeOfDay;
        private void btn_add_Click(object sender, EventArgs e)
        {
            News news = new News()
            {
                Title = txt_title.Text,
                Brief = txt_brief.Text,
                Desc = txt_desc.Text,
                Time = new TimeSpan(curtime.Hours, curtime.Minutes, curtime.Seconds),
                Date = DateTime.Now.Date,
                Auth_Id = curId,
                Cat_Id = (int)cb_catalog.SelectedValue
            };
            db.News.Add(news);
            db.SaveChanges();
            MessageBox.Show("data added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInput();
            display();
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
           displayAll();
            clearInput();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Profile profile = new Profile(curId);
            //profile.ShowDialog();
            ConfirmPassword confirmPassword = new ConfirmPassword(curId);
            confirmPassword.ShowDialog();
            this.Close();
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCatalog addCatalog = new AddCatalog(curId);
            addCatalog.ShowDialog();
            this.Close();
        }

        private void btn_showUser_Click(object sender, EventArgs e)
        {
            display();
            clearInput();
            btn_showUser.Visible = false;
            btn_showAll.Visible = true;
        }

        int rowId;
        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowId = (int)dgv_news.SelectedRows[0].Cells[0].Value;
            News curNews = db.News.FirstOrDefault(x => x.Id == rowId);
            txt_title.Text = curNews.Title;
            txt_brief.Text = curNews.Brief;
            txt_desc.Text = curNews.Desc;
            cb_catalog.SelectedValue = curNews.Cat_Id;
            btn_add.Visible = false;
            btn_updateNews.Visible = true;
            btn_delete.Visible = true;
        }

        private void btn_updateNews_Click(object sender, EventArgs e)
        {
            News updatedNews = db.News.FirstOrDefault(x => x.Id == rowId);
            if(updatedNews.Auth_Id != curId)
            {
                MessageBox.Show("You cant edit on this news", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearInput();
                displayAll();
            }
            else
            {

            updatedNews.Title = txt_title.Text;
            updatedNews.Brief = txt_brief.Text;
            updatedNews.Desc = txt_desc.Text;
            updatedNews.Time = new TimeSpan(curtime.Hours, curtime.Minutes, curtime.Seconds);
            updatedNews.Date = DateTime.Now;
            updatedNews.Cat_Id = (int)cb_catalog.SelectedValue;

            db.Update(updatedNews);
            db.SaveChanges();
            MessageBox.Show("Data Udated successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInput();
            display();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            News curNews = db.News.FirstOrDefault(n => n.Id == rowId);
            if (MessageBox.Show("Are u sure you want to delete", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (curNews.Auth_Id != curId)
            {
                MessageBox.Show("You cant delete on this news", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearInput();
                displayAll();
            }
            else
            {
                MessageBox.Show("Data Deleted successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Remove(curNews);
                db.SaveChanges();

                clearInput();
                display();
            }
            }


        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you logged out successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();

        }
    }
}
