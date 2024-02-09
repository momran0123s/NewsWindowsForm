namespace FinalTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_userName = new TextBox();
            txt_password = new TextBox();
            lbl_userName = new Label();
            lbl_password = new Label();
            lbl_loginTitle = new Label();
            btn_login = new Button();
            btn_register = new Button();
            label1 = new Label();
            check_showPassword = new CheckBox();
            SuspendLayout();
            // 
            // txt_userName
            // 
            txt_userName.BackColor = Color.Gainsboro;
            txt_userName.BorderStyle = BorderStyle.None;
            txt_userName.Location = new Point(61, 161);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(162, 20);
            txt_userName.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Gainsboro;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(61, 239);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(162, 20);
            txt_password.TabIndex = 1;
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_userName.ForeColor = Color.RoyalBlue;
            lbl_userName.Location = new Point(61, 138);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(95, 20);
            lbl_userName.TabIndex = 2;
            lbl_userName.Text = "USER NAME";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_password.ForeColor = Color.RoyalBlue;
            lbl_password.Location = new Point(61, 216);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(91, 20);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "PASSWORD";
            // 
            // lbl_loginTitle
            // 
            lbl_loginTitle.AutoSize = true;
            lbl_loginTitle.Font = new Font("Gill Sans Ultra Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_loginTitle.ForeColor = Color.RoyalBlue;
            lbl_loginTitle.Location = new Point(51, 31);
            lbl_loginTitle.Name = "lbl_loginTitle";
            lbl_loginTitle.Size = new Size(194, 61);
            lbl_loginTitle.TabIndex = 4;
            lbl_loginTitle.Text = "LOGIN";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.RoyalBlue;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(93, 344);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 5;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.RoyalBlue;
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(93, 417);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 29);
            btn_register.TabIndex = 6;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(61, 394);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 7;
            label1.Text = "dont have an account ?";
            // 
            // check_showPassword
            // 
            check_showPassword.AutoSize = true;
            check_showPassword.ForeColor = Color.RoyalBlue;
            check_showPassword.Location = new Point(64, 272);
            check_showPassword.Name = "check_showPassword";
            check_showPassword.Size = new Size(132, 24);
            check_showPassword.TabIndex = 8;
            check_showPassword.Text = "Show Password";
            check_showPassword.UseVisualStyleBackColor = true;
            check_showPassword.CheckedChanged += check_showPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(321, 505);
            Controls.Add(check_showPassword);
            Controls.Add(label1);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(lbl_loginTitle);
            Controls.Add(lbl_password);
            Controls.Add(lbl_userName);
            Controls.Add(txt_password);
            Controls.Add(txt_userName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_userName;
        private TextBox txt_password;
        private Label lbl_userName;
        private Label lbl_password;
        private Label lbl_loginTitle;
        private Button btn_login;
        private Button btn_register;
        private Label label1;
        private CheckBox check_showPassword;
    }
}
