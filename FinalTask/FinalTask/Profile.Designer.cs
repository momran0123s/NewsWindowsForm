namespace FinalTask
{
    partial class Profile
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
            txt_userName = new TextBox();
            txt_name = new TextBox();
            nud_age = new NumericUpDown();
            label1 = new Label();
            lbl_name = new Label();
            lbl_userName = new Label();
            lbl_age = new Label();
            btn_update = new Button();
            label3 = new Label();
            txt_password = new TextBox();
            check_showPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            SuspendLayout();
            // 
            // txt_userName
            // 
            txt_userName.BackColor = Color.Gainsboro;
            txt_userName.BorderStyle = BorderStyle.None;
            txt_userName.Location = new Point(90, 181);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(150, 20);
            txt_userName.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.Gainsboro;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Location = new Point(90, 118);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(150, 20);
            txt_name.TabIndex = 1;
            // 
            // nud_age
            // 
            nud_age.BackColor = Color.Gainsboro;
            nud_age.BorderStyle = BorderStyle.None;
            nud_age.Location = new Point(90, 238);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(150, 23);
            nud_age.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(260, 42);
            label1.TabIndex = 3;
            label1.Text = "USER PROFILE";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_name.ForeColor = Color.RoyalBlue;
            lbl_name.Location = new Point(90, 95);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(54, 20);
            lbl_name.TabIndex = 4;
            lbl_name.Text = "NAME";
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_userName.ForeColor = Color.RoyalBlue;
            lbl_userName.Location = new Point(90, 158);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(91, 20);
            lbl_userName.TabIndex = 5;
            lbl_userName.Text = "USERNAME";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_age.ForeColor = Color.RoyalBlue;
            lbl_age.Location = new Point(90, 215);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(39, 20);
            lbl_age.TabIndex = 6;
            lbl_age.Text = "AGE";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.RoyalBlue;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(110, 384);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 7;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(90, 274);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 10;
            label3.Text = "PASSWORD";
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Gainsboro;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(90, 297);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(150, 20);
            txt_password.TabIndex = 9;
            // 
            // check_showPassword
            // 
            check_showPassword.AutoSize = true;
            check_showPassword.ForeColor = Color.RoyalBlue;
            check_showPassword.Location = new Point(90, 323);
            check_showPassword.Name = "check_showPassword";
            check_showPassword.Size = new Size(132, 24);
            check_showPassword.TabIndex = 11;
            check_showPassword.Text = "Show Password";
            check_showPassword.UseVisualStyleBackColor = true;
            check_showPassword.CheckedChanged += check_showPassword_CheckedChanged;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 509);
            Controls.Add(check_showPassword);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(btn_update);
            Controls.Add(lbl_age);
            Controls.Add(lbl_userName);
            Controls.Add(lbl_name);
            Controls.Add(label1);
            Controls.Add(nud_age);
            Controls.Add(txt_name);
            Controls.Add(txt_userName);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_userName;
        private TextBox txt_name;
        private NumericUpDown nud_age;
        private Label label1;
        private Label lbl_name;
        private Label lbl_userName;
        private Label lbl_age;
        private Button btn_update;
        private Label label3;
        private TextBox txt_password;
        private CheckBox check_showPassword;
    }
}