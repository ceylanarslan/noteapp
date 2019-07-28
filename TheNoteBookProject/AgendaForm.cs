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
    public partial class AgendaForm : Form
    {
        public AgendaForm()
        {
            InitializeComponent();
        }

        private void ReminderCheck(ComboBox combo, CheckBox check)
        {
            if (check.Checked)
            {
                combo.Enabled = true;
                combo.SelectedIndex = 0;
            }
            else
            {
                combo.Enabled = false;
                combo.Text = "Hatırlatma yok";
            }
        }
        private void CleanUp()
        {
            txtNote.Text = "";
            cBoxIsReminder.Checked = false;
            comboPriority.SelectedIndex = 0;

            for (int i = 0; i < 24; i++)
            {
                lvSaatler.Items[i].BackColor = Color.White;
                lvNotesByDay.Items[i].BackColor = Color.White;
            }

        }
        private void GetImportantNotes()
        {
            foreach (DataGridViewRow row in dgvImportantNotes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            Agenda agd = new Agenda();
            dgvImportantNotes.DataSource = agd.GetImportantNotes();
            foreach (DataGridViewRow row in dgvImportantNotes.Rows)
            {
                if (row.Cells[1].Value.ToString() == "Çok Önemli")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (row.Cells[1].Value.ToString() == "Önemli")
                {
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                }
                else if (row.Cells[1].Value.ToString() == "Eh İşte")
                {
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.SeaShell;
                }
            }
        }
        private void AgendaForm_Load(object sender, EventArgs e)
        {
            Color formColor = Color.FromArgb(0xe0f4e9);
            Color formBC = Color.FromArgb(formColor.R, formColor.G, formColor.B);
            this.BackColor = formBC;

            Color clr = Color.FromArgb(0xe1331b);
            Color clr2 = Color.FromArgb(0xf85e28);
            Color menuBC = Color.FromArgb(clr2.R, clr2.G, clr2.B);
            descriptionBar.BackColor = menuBC;

            Color cTitle = Color.FromArgb(0xfff5c3);
            Color titleBC = Color.FromArgb(cTitle.R, cTitle.G, cTitle.B);
            formTitle.BackColor = titleBC;

            this.Top = 0;
            this.Left = 0;

            comboPriority.SelectedIndex = 0;

            ReminderCheck(comboReminderDate, cBoxIsReminder);
            txtTitleDate.Text = DateTime.Now.ToShortDateString();
            txtNoteDateTime.Text = txtTitleDate.Text + " 00:00:00";
            Agenda agd = new Agenda();
            if (CommonClass.noteDateTime == Convert.ToDateTime(null))
            {
                //Calendar.SelectionStart = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                //CommonClass.noteDateTime = Convert.ToDateTime(null);
                agd.GetNotesByDate(lvNotesByDay, lvSaatler, Convert.ToDateTime(txtNoteDateTime.Text));
            }
            else
            {
                Calendar.SelectionStart = CommonClass.noteDateTime;
            }
            GetImportantNotes();
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (txtNote.Text.Trim() == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }
        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            CleanUp();
            txtTitleDate.Text = Calendar.SelectionStart.ToShortDateString();
            Agenda agd = new Agenda();
            agd.GetNotesByDate(lvNotesByDay, lvSaatler, Calendar.SelectionStart);
            txtNote.Enabled = false;
        }
        private void cBoxIsReminder_CheckedChanged(object sender, EventArgs e)
        {
            ReminderCheck(comboReminderDate, cBoxIsReminder);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(txtNoteDateTime.Text);
            Agenda agd = new Agenda();
            agd.Body = txtNote.Text;
            agd.CreatedOn = DateTime.Now;
            agd.UpdatedOn = DateTime.Now;
            agd.IsReminder = cBoxIsReminder.Checked;
            agd.NoteDate = date;
            if (agd.IsReminder)
            {
                switch (comboReminderDate.SelectedItem.ToString())
                {
                    case "1 Hafta Önce":
                        agd.RemindOn = agd.NoteDate.AddDays(-7);
                        break;
                    case "1 Gün Önce":
                        agd.RemindOn = agd.NoteDate.AddDays(-1);
                        break;
                    case "1 Saat Önce":
                        agd.RemindOn = agd.NoteDate.AddHours(-1);
                        break;
                    case "Kendi saatinde":
                        agd.RemindOn = agd.NoteDate;
                        break;
                    default:
                        agd.RemindOn = Convert.ToDateTime(0);
                        break;
                }
            }
            agd.PriorityId = comboPriority.SelectedIndex + 1;
            if (agd.SaveNote(agd))
            {
                MessageBox.Show("Notunuz eklendi!");
                agd.GetNotesByDate(lvNotesByDay, lvSaatler, Convert.ToDateTime(txtNoteDateTime.Text));
                GetImportantNotes();
                CleanUp();
                txtNote.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Upss bir sorun var... Kayıt edemedim.");
            }
        }
        private void lvNotesByDay_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                lvSaatler.Items[i].BackColor = Color.White;
                lvNotesByDay.Items[i].BackColor = Color.White;
            }

            lvNotesByDay.SelectedItems[0].BackColor = Color.LightSalmon;
            lvSaatler.Items[lvNotesByDay.SelectedItems[0].Index].BackColor = Color.LightSalmon;
            txtNoteDate.Text = txtTitleDate.Text;
            txtNoteTime.Text = lvSaatler.Items[lvNotesByDay.SelectedItems[0].Index].SubItems[0].Text;
            DateTime _date = Convert.ToDateTime(txtTitleDate.Text + " " + txtNoteTime.Text + ":00");
            //string time = string.Format("{0:t}", _date);
            txtNoteDateTime.Text = _date.ToString();
            if (lvNotesByDay.SelectedItems[0].SubItems.Count < 2)
            {
                txtNote.Text = "";
                cBoxIsReminder.Checked = false;
                comboPriority.SelectedIndex = 0;
                txtNote.Focus();
                txtNote.Enabled = true;
            }
            else
            {
                txtId.Text = lvNotesByDay.SelectedItems[0].SubItems[5].Text;
                txtNote.Text = lvNotesByDay.SelectedItems[0].SubItems[1].Text;
                if (lvNotesByDay.SelectedItems[0].SubItems[3].Text == "")
                {
                    cBoxIsReminder.Checked = false;
                }
                else
                {
                    cBoxIsReminder.Checked = true;
                    if (Convert.ToDateTime(txtNoteDateTime.Text).AddDays(-7) == Convert.ToDateTime(lvNotesByDay.SelectedItems[0].SubItems[3].Text))
                    {
                        comboReminderDate.SelectedIndex = 0;
                    }
                    else if (Convert.ToDateTime(txtNoteDateTime.Text).AddHours(-1) == Convert.ToDateTime(lvNotesByDay.SelectedItems[0].SubItems[3].Text))
                    {
                        comboReminderDate.SelectedIndex = 2;
                    }
                    else if (Convert.ToDateTime(txtNoteDateTime.Text).AddDays(-1) == Convert.ToDateTime(lvNotesByDay.SelectedItems[0].SubItems[3].Text))
                    {
                        comboReminderDate.SelectedIndex = 1;
                    }
                    else
                    {
                        comboReminderDate.SelectedIndex = 3;
                    }
                }
                comboPriority.SelectedItem = lvNotesByDay.SelectedItems[0].SubItems[2].Text;
                btnDelete.Enabled = true;
                txtNote.Focus();
                txtNote.Enabled = true;
            }
        }
        private void lvSaatler_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                lvSaatler.Items[i].BackColor = Color.White;
                lvNotesByDay.Items[i].BackColor = Color.White;
            }

            lvSaatler.SelectedItems[0].BackColor = Color.LightSalmon;
            lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].BackColor = Color.LightSalmon;
            txtNoteDate.Text = txtTitleDate.Text;
            txtNoteTime.Text = lvSaatler.SelectedItems[0].SubItems[0].Text;
            DateTime _date = Convert.ToDateTime(txtTitleDate.Text + " " + txtNoteTime.Text + ":00");
            txtNoteDateTime.Text = _date.ToString();
            if (lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems.Count < 2)
            {
                txtNote.Text = "";
                cBoxIsReminder.Checked = false;
                comboPriority.SelectedIndex = 0;
                txtNote.Focus();
                txtNote.Enabled = true;
            }
            else
            {
                txtId.Text = lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems[5].Text;
                txtNote.Text = lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems[1].Text;
                if (lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems[3].Text == "")
                {
                    cBoxIsReminder.Checked = false;
                }
                else
                {
                    cBoxIsReminder.Checked = true;
                    if (Convert.ToDateTime(txtNoteDateTime.Text).AddDays(-7) == Convert.ToDateTime(lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems[3].Text))
                    {
                        comboReminderDate.SelectedIndex = 0;
                    }
                    else if (Convert.ToDateTime(txtNoteDateTime.Text).AddHours(-1) == Convert.ToDateTime(lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems[3].Text))
                    {
                        comboReminderDate.SelectedIndex = 2;
                    }
                    else if (Convert.ToDateTime(txtNoteDateTime.Text).AddDays(-1) == Convert.ToDateTime(lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems[3].Text))
                    {
                        comboReminderDate.SelectedIndex = 1;
                    }
                    else
                    {
                        comboReminderDate.SelectedIndex = 3;
                    }
                }
                comboPriority.SelectedItem = lvNotesByDay.Items[lvSaatler.SelectedItems[0].Index].SubItems[2].Text;
                btnDelete.Enabled = true;
                txtNote.Focus();
                txtNote.Enabled = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agenda agd = new Agenda();
            agd.DeleteNote(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Not silindi!");
            agd.GetNotesByDate(lvNotesByDay, lvSaatler, Convert.ToDateTime(txtNoteDateTime.Text));
            GetImportantNotes();
            CleanUp();
            btnDelete.Enabled = false;
        }
        private void dgvImportantNotes_DoubleClick(object sender, EventArgs e)
        {
            Calendar.SelectionStart = Convert.ToDateTime(dgvImportantNotes.SelectedRows[0].Cells[2].Value);
        }
    }
}
