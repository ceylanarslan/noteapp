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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Color cTitle = Color.FromArgb(0xfff5c3);
            Color titleBC = Color.FromArgb(cTitle.R, cTitle.G, cTitle.B);
            formTitle.BackColor = titleBC;

            Agenda agd=new Agenda();
            dgvAgendaNotes.DataSource = agd.GetAllNotes();

            Diary d = new Diary();
            dgvDiaryNotes.DataSource = d.GetAllNotes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Agenda agd = new Agenda();
                dgvAgendaNotes.DataSource = agd.GetAllNotes();

                Diary d = new Diary();
                dgvDiaryNotes.DataSource = d.GetAllNotes();
            }
            else
            {
                Agenda agd = new Agenda();
                dgvAgendaNotes.DataSource = agd.SearchNotes(txtSearch.Text);

                Diary d = new Diary();
                dgvDiaryNotes.DataSource = d.SearchNotes(txtSearch.Text);
            }

        }

        private void dgvAgendaNotes_DoubleClick(object sender, EventArgs e)
        {
            CommonClass.noteDateTime = Convert.ToDateTime(dgvAgendaNotes.SelectedRows[0].Cells[2].Value);
            AgendaForm frm = new AgendaForm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void dgvDiaryNotes_DoubleClick(object sender, EventArgs e)
        {
            CommonClass.noteDateTime = Convert.ToDateTime(dgvDiaryNotes.SelectedRows[0].Cells[2].Value);
            DiaryForm frm = new DiaryForm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }
    }
}
