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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            Color formColor = Color.FromArgb(0xe0f4e9);
            Color formBC = Color.FromArgb(formColor.R, formColor.G, formColor.B);
            this.BackColor = formBC;
            Color cTitle = Color.FromArgb(0xfff5c3);
            Color titleBC = Color.FromArgb(cTitle.R, cTitle.G, cTitle.B);
            formTitle.BackColor = titleBC;
            this.Top = 0;
            this.Left = 0;

            //User u = new User();
            //u=u.GetUserInfo();
            //txtSurname.Text = u.UserName.ToString();
            //txtName.Text = u.Name.ToString();
            //txtSurname.Text = u.Surname.ToString();
            //txtPassword.Text = u.Password.ToString();
            //txtpassword2.Text = u.Password.ToString();
            //txtEmail.Text = u.Email.ToString();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesabını tamamen silmek verilerine bir daha ulaşamamana neden olacak. Hesabını silmeyi gerçekten istiyor musun?", "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Hoşçakal! Not defterin seni özleyecek...");
                User u = new User();
                if (u.DeleteUser())
                {
                    Application.Exit();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
