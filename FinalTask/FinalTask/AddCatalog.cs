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
    public partial class AddCatalog : Form
    {
        Context db;
        int curId;
        public AddCatalog(int id)
        {
            InitializeComponent();
            db = new Context();
            curId = id;
        }
        private void showCatalogs()
        {
            dgv_catalog.DataSource = db.Catalog.ToList();
            btn_addCat.Visible = true;
            btn_deleteCat.Visible = false;
            btn_updateCat.Visible = false;
        }
        private void clearInput()
        {
            txt_catName.Text = txt_desc.Text = "";
        }
        private void AddCatalog_Load(object sender, EventArgs e)
        {
            showCatalogs();
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog()
            {
                Name = txt_catName.Text,
                Desc = txt_desc.Text,
            };
            db.Catalog.Add(catalog);
            db.SaveChanges();
            MessageBox.Show("Catalog Added successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showCatalogs();
            
            clearInput();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD cRUD = new CRUD(curId);
            cRUD.ShowDialog();
            this.Close();
        }
        int rowId;
        private void dgv_catalog_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowId = (int)dgv_catalog.SelectedRows[0].Cells[0].Value;
            Catalog curCatalog = db.Catalog.Find(rowId);
            txt_catName.Text = curCatalog.Name;
            txt_desc.Text = curCatalog.Desc;
            btn_addCat.Visible = false;
            btn_updateCat.Visible = true;
            btn_deleteCat.Visible = true;
        }

        private void btn_updateCat_Click(object sender, EventArgs e)
        {
            Catalog curCatalog = db.Catalog.Find(rowId);
            curCatalog.Name = txt_catName.Text;
            curCatalog.Desc = txt_desc.Text;
            db.Update(curCatalog);
            db.SaveChanges();
            MessageBox.Show("Data Updated successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            showCatalogs();
            clearInput();
        }

        private void btn_deleteCat_Click(object sender, EventArgs e)
        {
            Catalog curCatalog = db.Catalog.Find(rowId);
            if(MessageBox.Show("Are u sure you want to delete", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            db.Remove(curCatalog);
            db.SaveChanges();
            MessageBox.Show("Data Deleted successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showCatalogs();
            clearInput();
            }
        }
    }
}
