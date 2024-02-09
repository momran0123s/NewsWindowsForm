namespace FinalTask
{
    partial class ConfirmPassword
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
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_confirm = new Button();
            check_showPassword = new CheckBox();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Gainsboro;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(92, 175);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(176, 20);
            txt_password.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(312, 30);
            label1.TabIndex = 1;
            label1.Text = "CONFIRM PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(60, 116);
            label2.Name = "label2";
            label2.Size = new Size(251, 28);
            label2.TabIndex = 2;
            label2.Text = "ENTER YOUR PASSWORD";
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.RoyalBlue;
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Location = new Point(130, 248);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(94, 29);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "CONFIRM";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // check_showPassword
            // 
            check_showPassword.AutoSize = true;
            check_showPassword.ForeColor = Color.RoyalBlue;
            check_showPassword.Location = new Point(92, 201);
            check_showPassword.Name = "check_showPassword";
            check_showPassword.Size = new Size(132, 24);
            check_showPassword.TabIndex = 9;
            check_showPassword.Text = "Show Password";
            check_showPassword.UseVisualStyleBackColor = true;
            check_showPassword.CheckedChanged += check_showPassword_CheckedChanged;
            // 
            // ConfirmPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(381, 324);
            Controls.Add(check_showPassword);
            Controls.Add(btn_confirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Name = "ConfirmPassword";
            Text = "ConfirmPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Button btn_confirm;
        private CheckBox check_showPassword;
    }
}