using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TheNoteBookProject
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
                MailMessage message;
                SmtpClient smtp;

                try
                {
                    message = new MailMessage();
                    string email = txtMail.Text;
                    if (IsValid(email))
                    {
                        User user = new User();
                        message.To.Add(email);
                        message.Subject = "Not Defteri - Sifremi Unuttum";
                        message.From = new MailAddress("noteappinfo@gmail.com", "NoteApp Info");
                        message.Body = "Merhaba, Kullanıcı Adınız: " + user.UserNameByEmail(email) + " Şifreniz: " + user.PasswordByEmail(email);
                        if (user.UserMailControl(email))
                        {
                            smtp = new SmtpClient("smtp.gmail.com");
                            smtp.Port = 25;
                            smtp.EnableSsl = true;
                            smtp.Credentials = new NetworkCredential("noteappinfo@gmail.com", "note.app");
                            smtp.SendAsync(message, message.Subject);
                            smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
                        }
                        else
                        {
                            MessageBox.Show("Böyle bir mail kayıtlı değil.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Şifre gönderimini iptal ettiniz.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Şifre gönderilemedi.");
            }
            else
            {
                MessageBox.Show("Şifreniz mailinize gönderildi.");
            }

            this.Close();
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
                MessageBox.Show("Geçerli bir mail girmelisiniz.");
                return false;
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Image.FromFile(@"..\images\notebook-581128.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
