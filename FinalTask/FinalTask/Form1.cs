using FinalTask.Models;

namespace FinalTask
{
    public partial class Form1 : Form
    {
        int curId;
        Context db;
        public Form1()
        {
            InitializeComponent();
            db = new Context();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var author = db.Author.FirstOrDefault(a => a.UserName == txt_userName.Text && a.Password == txt_password.Text);
            if (author != null)
            {
                curId = author.Id;
                this.Hide();
                CRUD cRUD = new CRUD(curId);
                cRUD.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("user doesnt exist", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
