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
    public partial class Private_notes : Form
    {
        public Private_notes()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                User u = new User();
         
                if (u.PasswordByuserID(txtPassword.Text))
                {       this.Hide();
               
                        DiaryForm frm = new DiaryForm();

                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz yanlıştır..");
                    }
                }
              
            }

        }
    }
