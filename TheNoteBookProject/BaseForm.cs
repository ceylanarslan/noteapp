using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNoteBookProject
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Form whichForm)
        {
            bool FormIsOpen = false;
            if (MdiChildren.Length > 0)
            {
                if (whichForm.Name == MdiChildren[0].Name)
                {
                    whichForm.Focus();
                    FormIsOpen = true;
                }
                else
                {
                    MdiChildren[0].Close();
                }
            }
            if (FormIsOpen == false)
            {
                whichForm.MdiParent = this;
                whichForm.Show();
            }
            else
            {
                MessageBox.Show("Zaten o sayfadasınız.");
            }
        }
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            AgendaForm frm = new AgendaForm();
            OpenForm(frm);
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
            Color formColor = Color.FromArgb(0xe0f4e9);
            Color clr = Color.FromArgb(0xe1331b);
            Color clr2 = Color.FromArgb(0xf85e28);
            Color cPanel = Color.FromArgb(0xfff5c3);
            Color formBC = Color.FromArgb(formColor.R, formColor.G, formColor.B);
            Color btnBC = Color.FromArgb(clr.R, clr.G, clr.B);
            Color btnBC2 = Color.FromArgb(clr2.R, clr2.G, clr2.B);
            Color panelBC = Color.FromArgb(cPanel.R, cPanel.G, cPanel.B);

            this.BackColor = formBC;
            btnDiary.BackColor = btnBC;
            btnAgenda.BackColor = btnBC;
            btnGuide.BackColor = btnBC;
            //btnList.BackColor = btnBC;
            btnOptions.BackColor = btnBC;
            btnSearch.BackColor = btnBC2;
            btnExit.BackColor = btnBC2;
            panelMenu.BackColor = panelBC;

            statusDateToday.Text = DateTime.Now.ToLongDateString();

            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    string error = exc.Message;
                    // Catch and ignore the error if casting failed.
                }
            }

            AgendaForm frm = new AgendaForm();
            OpenForm(frm);
            Agenda agd = new Agenda();
            if (agd.ReminderControl())
            {
                ReminderForm frmRemind = new ReminderForm();
                frmRemind.Show();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Veda etmek istediğinden emin misin?", "Gidiyor musun?", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                LoginForm frm = new LoginForm();
                frm.Show();
                this.Close();
            }
        }
        private void btnDiary_Click(object sender, EventArgs e)
        {
            DiaryForm frm = new DiaryForm();
            OpenForm(frm);
        }
        private void btnGuide_Click(object sender, EventArgs e)
        {
            ContacsForm frm = new ContacsForm();
            OpenForm(frm);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            OpenForm(frm);
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsForm frm = new OptionsForm();
            OpenForm(frm);
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
