using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNoteBookProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text != "")
            {
                User u = new User();
                if (u.UserNameControl(txtUserName.Text))
                {
                    if (u.PasswordControl(txtUserName.Text, txtPassword.Text))
                    {
                        this.Hide();
                        CommonClass.userNo = u.IdByUserName(txtUserName.Text);
                        BaseForm frm = new BaseForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz yanlıştır..");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı. Lütfen üye olunuz..");
                    Temizle();
                }
            }
        }
        private void Temizle()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnForgotPwd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm frm = new SignUpForm();
            frm.ShowDialog();
            this.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"..\images\notebook-581128.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
