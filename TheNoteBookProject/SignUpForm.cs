using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TheNoteBookProject
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && IsValid(txtEmail.Text))
            {
                if (txtPassword.Text==txtpassword2.Text)
                {
                    User u = new User();
                    if (!u.UserNameControl(txtUserName.Text))
                    {
                        if (!u.UserMailControl(txtEmail.Text))
                        {
                            u.UserName = txtUserName.Text;
                            u.Email = txtEmail.Text;
                            u.Password = txtPassword.Text;
                            u.Name = txtName.Text;
                            u.Surname = txtSurname.Text;
                            if (u.AddUser(u))
                            {
                                MessageBox.Show("Kişi Bilgileri Eklendi.");
                                this.Close();
                                //user insert edildiğinde triggerla category tablosu doldurulur
                            }
                            else
                                MessageBox.Show("Kişi Bilgileri Kayıt Edilemedi.");
                        }
                        else
                        {
                            MessageBox.Show("Aynı mail adresini kullanan bir kullanıcı kayıtlı! Şifrenizi unuttuysanız Şifremi Unuttum'a tıklayın!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aynı kullanıcı adınıyla kayıtlı bir kullanıcı var! Şifrenizi unuttuysanız Şifremi Unuttum'a tıklayın!");
                        txtUserName.Focus();
                    }
                }
                else
                    MessageBox.Show("Girdiğiniz şifreler aynı değil!");
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz! Geçerli bir e-mail ve kullanıcı adı girmelisiniz!");
                txtUserName.Focus();
            }
        }

        private void Temizle()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtpassword2.Clear();
            txtEmail.Clear();
            txtUserName.Focus();
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"..\images\notebook-581128.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void txtpassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text==txtpassword2.Text)
            {
                lblPwdControl.Text = "*Şifreler aynı.";
            }
            else
            {
                lblPwdControl.Text = "*Şifreler aynı olmalı!";
            }
        }

        private void btnForgotPwd_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.ShowDialog();
            this.Close();
        }

    }
}

