namespace FinalTask
{
    partial class CRUD
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
            txt_desc = new TextBox();
            txt_brief = new TextBox();
            txt_title = new TextBox();
            cb_catalog = new ComboBox();
            label1 = new Label();
            lbl_title = new Label();
            lbl_brief = new Label();
            lbl_desc = new Label();
            lbl_catalog = new Label();
            dgv_news = new DataGridView();
            btn_add = new Button();
            btn_showAll = new Button();
            btn_profile = new Button();
            btn_addCat = new Button();
            btn_showUser = new Button();
            btn_updateNews = new Button();
            btn_delete = new Button();
            btn_logout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // txt_desc
            // 
            txt_desc.BackColor = Color.Gainsboro;
            txt_desc.BorderStyle = BorderStyle.None;
            txt_desc.Location = new Point(413, 120);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(125, 20);
            txt_desc.TabIndex = 0;
            // 
            // txt_brief
            // 
            txt_brief.BackColor = Color.Gainsboro;
            txt_brief.BorderStyle = BorderStyle.None;
            txt_brief.Location = new Point(218, 120);
            txt_brief.Name = "txt_brief";
            txt_brief.Size = new Size(125, 20);
            txt_brief.TabIndex = 1;
            // 
            // txt_title
            // 
            txt_title.BackColor = Color.Gainsboro;
            txt_title.BorderStyle = BorderStyle.None;
            txt_title.Location = new Point(35, 120);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(125, 20);
            txt_title.TabIndex = 2;
            // 
            // cb_catalog
            // 
            cb_catalog.BackColor = Color.Gainsboro;
            cb_catalog.FormattingEnabled = true;
            cb_catalog.Location = new Point(611, 120);
            cb_catalog.Name = "cb_catalog";
            cb_catalog.Size = new Size(151, 28);
            cb_catalog.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 61);
            label1.TabIndex = 4;
            label1.Text = "NEWS";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_title.ForeColor = Color.RoyalBlue;
            lbl_title.Location = new Point(35, 97);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(40, 20);
            lbl_title.TabIndex = 5;
            lbl_title.Text = "Title";
            // 
            // lbl_brief
            // 
            lbl_brief.AutoSize = true;
            lbl_brief.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_brief.ForeColor = Color.RoyalBlue;
            lbl_brief.Location = new Point(218, 97);
            lbl_brief.Name = "lbl_brief";
            lbl_brief.Size = new Size(43, 20);
            lbl_brief.TabIndex = 6;
            lbl_brief.Text = "Brief";
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_desc.ForeColor = Color.RoyalBlue;
            lbl_desc.Location = new Point(413, 97);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(89, 20);
            lbl_desc.TabIndex = 7;
            lbl_desc.Text = "Description";
            // 
            // lbl_catalog
            // 
            lbl_catalog.AutoSize = true;
            lbl_catalog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_catalog.ForeColor = Color.RoyalBlue;
            lbl_catalog.Location = new Point(611, 97);
            lbl_catalog.Name = "lbl_catalog";
            lbl_catalog.Size = new Size(62, 20);
            lbl_catalog.TabIndex = 8;
            lbl_catalog.Text = "Catalog";
            // 
            // dgv_news
            // 
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(12, 238);
            dgv_news.Name = "dgv_news";
            dgv_news.RowHeadersWidth = 51;
            dgv_news.Size = new Size(776, 200);
            dgv_news.TabIndex = 9;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.RoyalBlue;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(35, 181);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(148, 29);
            btn_add.TabIndex = 10;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_showAll
            // 
            btn_showAll.BackColor = Color.RoyalBlue;
            btn_showAll.ForeColor = Color.White;
            btn_showAll.Location = new Point(435, 181);
            btn_showAll.Name = "btn_showAll";
            btn_showAll.Size = new Size(148, 29);
            btn_showAll.TabIndex = 11;
            btn_showAll.Text = "SHOW ALL NEWS";
            btn_showAll.UseVisualStyleBackColor = false;
            btn_showAll.Click += btn_showAll_Click;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.RoyalBlue;
            btn_profile.ForeColor = Color.White;
            btn_profile.Location = new Point(694, 20);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(94, 29);
            btn_profile.TabIndex = 12;
            btn_profile.Text = "Profile";
            btn_profile.UseVisualStyleBackColor = false;
            btn_profile.Click += btn_profile_Click;
            // 
            // btn_addCat
            // 
            btn_addCat.BackColor = Color.RoyalBlue;
            btn_addCat.ForeColor = Color.White;
            btn_addCat.Location = new Point(614, 181);
            btn_addCat.Name = "btn_addCat";
            btn_addCat.Size = new Size(148, 29);
            btn_addCat.TabIndex = 13;
            btn_addCat.Text = "ADD CATALOG";
            btn_addCat.UseVisualStyleBackColor = false;
            btn_addCat.Click += btn_addCat_Click;
            // 
            // btn_showUser
            // 
            btn_showUser.BackColor = Color.RoyalBlue;
            btn_showUser.ForeColor = Color.White;
            btn_showUser.Location = new Point(435, 181);
            btn_showUser.Name = "btn_showUser";
            btn_showUser.Size = new Size(148, 29);
            btn_showUser.TabIndex = 14;
            btn_showUser.Text = "SHOW USER NEWS";
            btn_showUser.UseVisualStyleBackColor = false;
            btn_showUser.Click += btn_showUser_Click;
            // 
            // btn_updateNews
            // 
            btn_updateNews.BackColor = Color.RoyalBlue;
            btn_updateNews.ForeColor = Color.White;
            btn_updateNews.Location = new Point(35, 181);
            btn_updateNews.Name = "btn_updateNews";
            btn_updateNews.Size = new Size(148, 29);
            btn_updateNews.TabIndex = 15;
            btn_updateNews.Text = "UPDATE";
            btn_updateNews.UseVisualStyleBackColor = false;
            btn_updateNews.Click += btn_updateNews_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.RoyalBlue;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(218, 181);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(148, 29);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.RoyalBlue;
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(12, 20);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 17;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_logout);
            Controls.Add(btn_delete);
            Controls.Add(btn_updateNews);
            Controls.Add(btn_showUser);
            Controls.Add(btn_addCat);
            Controls.Add(btn_profile);
            Controls.Add(btn_showAll);
            Controls.Add(btn_add);
            Controls.Add(dgv_news);
            Controls.Add(lbl_catalog);
            Controls.Add(lbl_desc);
            Controls.Add(lbl_brief);
            Controls.Add(lbl_title);
            Controls.Add(label1);
            Controls.Add(cb_catalog);
            Controls.Add(txt_title);
            Controls.Add(txt_brief);
            Controls.Add(txt_desc);
            Name = "CRUD";
            Text = "CRUD";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_desc;
        private TextBox txt_brief;
        private TextBox txt_title;
        private ComboBox cb_catalog;
        private Label label1;
        private Label lbl_title;
        private Label lbl_brief;
        private Label lbl_desc;
        private Label lbl_catalog;
        private DataGridView dgv_news;
        private Button btn_add;
        private Button btn_showAll;
        private Button btn_profile;
        private Button btn_addCat;
        private Button btn_showUser;
        private Button btn_updateNews;
        private Button btn_delete;
        private Button btn_logout;
    }
}