namespace FinalTask
{
    partial class Register
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
            txt_name = new TextBox();
            txt_password = new TextBox();
            txt_userName = new TextBox();
            nud_age = new NumericUpDown();
            label1 = new Label();
            lbl_name = new Label();
            lbl_age = new Label();
            lbl_userName = new Label();
            lbl_password = new Label();
            btn_register = new Button();
            btn_login = new Button();
            lbl_phrase = new Label();
            check_showPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.Gainsboro;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Location = new Point(79, 123);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(150, 20);
            txt_name.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Gainsboro;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(79, 336);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(150, 20);
            txt_password.TabIndex = 1;
            // 
            // txt_userName
            // 
            txt_userName.BackColor = Color.Gainsboro;
            txt_userName.BorderStyle = BorderStyle.None;
            txt_userName.Location = new Point(79, 265);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(150, 20);
            txt_userName.TabIndex = 2;
            // 
            // nud_age
            // 
            nud_age.BackColor = Color.Gainsboro;
            nud_age.BorderStyle = BorderStyle.None;
            nud_age.Location = new Point(79, 194);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(150, 23);
            nud_age.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(238, 56);
            label1.TabIndex = 4;
            label1.Text = "Register";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_name.ForeColor = Color.RoyalBlue;
            lbl_name.Location = new Point(78, 100);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(54, 20);
            lbl_name.TabIndex = 5;
            lbl_name.Text = "NAME";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_age.ForeColor = Color.RoyalBlue;
            lbl_age.Location = new Point(79, 171);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(39, 20);
            lbl_age.TabIndex = 6;
            lbl_age.Text = "AGE";
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_userName.ForeColor = Color.RoyalBlue;
            lbl_userName.Location = new Point(78, 242);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(91, 20);
            lbl_userName.TabIndex = 7;
            lbl_userName.Text = "USERNAME";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_password.ForeColor = Color.RoyalBlue;
            lbl_password.Location = new Point(77, 313);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(91, 20);
            lbl_password.TabIndex = 8;
            lbl_password.Text = "PASSWORD";
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.RoyalBlue;
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(100, 423);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 29);
            btn_register.TabIndex = 9;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.RoyalBlue;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(100, 487);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 10;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_phrase
            // 
            lbl_phrase.AutoSize = true;
            lbl_phrase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_phrase.ForeColor = Color.RoyalBlue;
            lbl_phrase.Location = new Point(79, 464);
            lbl_phrase.Name = "lbl_phrase";
            lbl_phrase.Size = new Size(153, 20);
            lbl_phrase.TabIndex = 11;
            lbl_phrase.Text = "Already Registered ? ";
            // 
            // check_showPassword
            // 
            check_showPassword.AutoSize = true;
            check_showPassword.BackColor = Color.Transparent;
            check_showPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            check_showPassword.ForeColor = Color.RoyalBlue;
            check_showPassword.Location = new Point(79, 369);
            check_showPassword.Name = "check_showPassword";
            check_showPassword.Size = new Size(136, 24);
            check_showPassword.TabIndex = 12;
            check_showPassword.Text = "Show Password";
            check_showPassword.UseVisualStyleBackColor = false;
            check_showPassword.CheckedChanged += check_showPassword_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(307, 555);
            Controls.Add(check_showPassword);
            Controls.Add(lbl_phrase);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(lbl_password);
            Controls.Add(lbl_userName);
            Controls.Add(lbl_age);
            Controls.Add(lbl_name);
            Controls.Add(label1);
            Controls.Add(nud_age);
            Controls.Add(txt_userName);
            Controls.Add(txt_password);
            Controls.Add(txt_name);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_password;
        private TextBox txt_userName;
        private NumericUpDown nud_age;
        private Label label1;
        private Label lbl_name;
        private Label lbl_age;
        private Label lbl_userName;
        private Label lbl_password;
        private Button btn_register;
        private Button btn_login;
        private Label lbl_phrase;
        private CheckBox check_showPassword;
    }
}