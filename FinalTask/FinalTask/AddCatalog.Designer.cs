namespace FinalTask
{
    partial class AddCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_catName = new TextBox();
            txt_desc = new TextBox();
            lbl_catalog = new Label();
            lbl_name = new Label();
            lbl_desc = new Label();
            dgv_catalog = new DataGridView();
            btn_addCat = new Button();
            btn_back = new Button();
            btn_updateCat = new Button();
            btn_deleteCat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_catalog).BeginInit();
            SuspendLayout();
            // 
            // txt_catName
            // 
            txt_catName.BackColor = Color.Gainsboro;
            txt_catName.BorderStyle = BorderStyle.None;
            txt_catName.ForeColor = Color.RoyalBlue;
            txt_catName.Location = new Point(150, 138);
            txt_catName.Name = "txt_catName";
            txt_catName.Size = new Size(188, 20);
            txt_catName.TabIndex = 0;
            // 
            // txt_desc
            // 
            txt_desc.BackColor = Color.Gainsboro;
            txt_desc.BorderStyle = BorderStyle.None;
            txt_desc.ForeColor = Color.Black;
            txt_desc.Location = new Point(150, 198);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(188, 20);
            txt_desc.TabIndex = 1;
            // 
            // lbl_catalog
            // 
            lbl_catalog.AutoSize = true;
            lbl_catalog.BackColor = Color.Transparent;
            lbl_catalog.Font = new Font("Gill Sans Ultra Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_catalog.ForeColor = SystemColors.Highlight;
            lbl_catalog.Location = new Point(98, 25);
            lbl_catalog.Name = "lbl_catalog";
            lbl_catalog.Size = new Size(258, 61);
            lbl_catalog.TabIndex = 2;
            lbl_catalog.Text = "Catalogs";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_name.ForeColor = Color.RoyalBlue;
            lbl_name.Location = new Point(150, 115);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(54, 20);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "NAME";
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_desc.ForeColor = Color.RoyalBlue;
            lbl_desc.Location = new Point(150, 175);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(106, 20);
            lbl_desc.TabIndex = 4;
            lbl_desc.Text = "DESCRIPTION";
            // 
            // dgv_catalog
            // 
            dgv_catalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_catalog.Location = new Point(25, 359);
            dgv_catalog.Name = "dgv_catalog";
            dgv_catalog.RowHeadersWidth = 51;
            dgv_catalog.Size = new Size(432, 204);
            dgv_catalog.TabIndex = 5;
            dgv_catalog.RowHeaderMouseDoubleClick += dgv_catalog_RowHeaderMouseDoubleClick;
            // 
            // btn_addCat
            // 
            btn_addCat.BackColor = Color.RoyalBlue;
            btn_addCat.ForeColor = Color.White;
            btn_addCat.Location = new Point(188, 270);
            btn_addCat.Name = "btn_addCat";
            btn_addCat.Size = new Size(106, 29);
            btn_addCat.TabIndex = 6;
            btn_addCat.Text = "ADD";
            btn_addCat.UseVisualStyleBackColor = false;
            btn_addCat.Click += btn_addCat_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.RoyalBlue;
            btn_back.BackgroundImageLayout = ImageLayout.None;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(14, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(35, 29);
            btn_back.TabIndex = 7;
            btn_back.Text = "<";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_updateCat
            // 
            btn_updateCat.BackColor = Color.RoyalBlue;
            btn_updateCat.ForeColor = Color.White;
            btn_updateCat.Location = new Point(188, 235);
            btn_updateCat.Name = "btn_updateCat";
            btn_updateCat.Size = new Size(106, 29);
            btn_updateCat.TabIndex = 8;
            btn_updateCat.Text = "Update";
            btn_updateCat.UseVisualStyleBackColor = false;
            btn_updateCat.Click += btn_updateCat_Click;
            // 
            // btn_deleteCat
            // 
            btn_deleteCat.BackColor = Color.RoyalBlue;
            btn_deleteCat.ForeColor = Color.White;
            btn_deleteCat.Location = new Point(188, 305);
            btn_deleteCat.Name = "btn_deleteCat";
            btn_deleteCat.Size = new Size(106, 29);
            btn_deleteCat.TabIndex = 9;
            btn_deleteCat.Text = "Delete";
            btn_deleteCat.UseVisualStyleBackColor = false;
            btn_deleteCat.Click += btn_deleteCat_Click;
            // 
            // AddCatalog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 575);
            Controls.Add(btn_deleteCat);
            Controls.Add(btn_updateCat);
            Controls.Add(btn_back);
            Controls.Add(btn_addCat);
            Controls.Add(dgv_catalog);
            Controls.Add(lbl_desc);
            Controls.Add(lbl_name);
            Controls.Add(lbl_catalog);
            Controls.Add(txt_desc);
            Controls.Add(txt_catName);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "AddCatalog";
            Text = "AddCatalog";
            Load += AddCatalog_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_catalog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_catName;
        private TextBox txt_desc;
        private Label lbl_catalog;
        private Label lbl_name;
        private Label lbl_desc;
        private DataGridView dgv_catalog;
        private Button btn_addCat;
        private Button btn_back;
        private Button btn_updateCat;
        private Button btn_deleteCat;
    }
}