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

namespace TheNoteBookProject
{
    public partial class DiaryForm : Form
    {
        //private static DateTime sqlMinValue = DateTime.Parse("01.01.1753 00:00:00");
        //private static DateTime sqlMaxValue = DateTime.Parse("31.12.9999 00:00:00");
        public DiaryForm()
        {
            InitializeComponent();
        }

        private void DiaryForm_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Color formColor = Color.FromArgb(0xe0f4e9);
            Color formBC = Color.FromArgb(formColor.R, formColor.G, formColor.B);
            this.BackColor = formBC;
            Color cTitle = Color.FromArgb(0xfff5c3);
            Color titleBC = Color.FromArgb(cTitle.R, cTitle.G, cTitle.B);
            formTitle.BackColor = titleBC;

            User u = new User();
            diaryCalendar.MinDate = u.SignUpDate();
            diaryCalendar.MaxDate = DateTime.Now;  //takvimde gelecek günleri görmemek için maxdate'ini bugüne sabitledim. aynı şekilde mindate de kontrol edilebilir.
            
            Category cat = new Category();
            txtcatID.Text = cat.GetCategoryId(diaryMenuItem.Text).ToString();
            txtTarih.Text = DateTime.Now.ToShortDateString();
            tsTxtCatName.Text = diaryMenuItem.Text;

            Diary d = new Diary();
            if (CommonClass.noteDateTime == Convert.ToDateTime(null))
            {
                diaryCalendar.SelectionStart = Convert.ToDateTime(txtTarih.Text);
            }
            else
            {
                diaryCalendar.SelectionStart = CommonClass.noteDateTime;
            }

            CommonClass.noteDateTime = Convert.ToDateTime(null);
        }
        private void diaryCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtNote.Text = "";
            txtNote.Enabled = true;
            dgvNotes.Enabled = true;
            btnDelete.Enabled = true;
            Diary d = new Diary();
            d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text),diaryCalendar.SelectionStart);
            dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
            txtTarih.Text = diaryCalendar.SelectionStart.ToShortDateString();
            if (tsTxtCatName.Text=="Günlüğüm" && diaryCalendar.SelectionStart!=Convert.ToDateTime(DateTime.Now.ToShortDateString()))
            {
                txtNote.Enabled = false;
            }
            if (txtNote.Text=="")
            {
                btnDelete.Enabled = false;
            }
        }
        private void noteBookMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnDelete.Enabled = false;
            }
            catPicture.Image = Image.FromFile(@"..\images\journal-155431.png");
            catPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            txtNote.Enabled = true;
            dgvNotes.Enabled = true;
            btnSave.Enabled = true;
            diaryCalendar.Enabled = true;
            Category cat = new Category();
            txtcatID.Text = cat.GetCategoryId(noteBookMenuItem.Text).ToString();
            Diary d = new Diary();
            d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text), diaryCalendar.SelectionStart);
            tsTxtCatName.Text = noteBookMenuItem.Text;
            dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
        }
        private void travelMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnDelete.Enabled = false;
            }
            catPicture.Image = Image.FromFile(@"..\images\seyahatDefteri.jpg");
            txtNote.Enabled = true;
            dgvNotes.Enabled = true;
            btnSave.Enabled = true;
            diaryCalendar.Enabled = true;
            Category cat = new Category();
            txtcatID.Text = cat.GetCategoryId(travelMenuItem.Text).ToString();
            Diary d = new Diary();
            d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text), diaryCalendar.SelectionStart);
            tsTxtCatName.Text = travelMenuItem.Text;
            dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
        }
        private void workMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnDelete.Enabled = false;
            }
            catPicture.Image = Image.FromFile(@"..\images\clipboard-155885.png");
            txtNote.Enabled = true;
            dgvNotes.Enabled = true;
            btnSave.Enabled = true;
            diaryCalendar.Enabled = true;
            Category cat = new Category();
            txtcatID.Text = cat.GetCategoryId(workingMenuItem.Text).ToString();
            Diary d = new Diary();
            d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text), diaryCalendar.SelectionStart);
            tsTxtCatName.Text = workingMenuItem.Text;
            dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
        }
        private void lessonMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnDelete.Enabled = false;
            }
            catPicture.Image = Image.FromFile(@"..\images\clipboard-155885.png");
            txtNote.Enabled = true;
            dgvNotes.Enabled = true;
            btnSave.Enabled = true;
            diaryCalendar.Enabled = true;
            Category cat = new Category();
            txtcatID.Text = cat.GetCategoryId(lessonMenuItem.Text).ToString();
            Diary d = new Diary();
            d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text), diaryCalendar.SelectionStart);
            tsTxtCatName.Text = lessonMenuItem.Text;
            dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
        }
        private void forLaterMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnDelete.Enabled = false;
            }
            catPicture.Image = Image.FromFile(@"..\images\journal-155431.png");
            txtNote.Enabled = true;
            dgvNotes.Enabled = true;
            btnSave.Enabled = true;
            diaryCalendar.Enabled = true;
            Category cat = new Category();
            txtcatID.Text = cat.GetCategoryId(forLaterMenuItem.Text).ToString();
            Diary d = new Diary();
            d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text), diaryCalendar.SelectionStart);
            tsTxtCatName.Text = forLaterMenuItem.Text;
            dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
        }
        private void diaryMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnDelete.Enabled = false;
            }
            catPicture.Image = Image.FromFile(@"..\images\certificate-154169.png");
            txtNote.Enabled = true;
            dgvNotes.Enabled = true;
            btnSave.Enabled = true;
            diaryCalendar.Enabled = true;
            Category cat = new Category();
            txtcatID.Text = cat.GetCategoryId(diaryMenuItem.Text).ToString();
            Diary d = new Diary();
            d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text), diaryCalendar.SelectionStart);
            tsTxtCatName.Text = diaryMenuItem.Text;
            dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
        }
        private void privateMenuItem_Click(object sender, EventArgs e)
        {
            catPicture.Image = Image.FromFile(@"..\images\girl-160167.png");
            User u = new User();
            if (u.PasswordByUserID(Microsoft.VisualBasic.Interaction.InputBox("Bu bölümü açabilmek için şifrenizi tekrar girmelisiniz.", "Gizli Notlar", "Şifreniz", -1, -1)))
            {
                if (txtNote.Text == "")
                {
                    btnDelete.Enabled = false;
                }
                Category cat = new Category();
                txtcatID.Text = cat.GetCategoryId(privateMenuItem.Text).ToString();
                Diary d = new Diary();
                d.GetDiaryNote(txtNote, Convert.ToInt32(txtcatID.Text), diaryCalendar.SelectionStart);
                tsTxtCatName.Text = privateMenuItem.Text;
                dgvNotes.DataSource = d.GetDatagrid(Convert.ToInt32((txtcatID.Text)));
            }
            else
            {
                txtNote.Clear();
                dgvNotes.DataSource = null;
                MessageBox.Show("Şifreyi yanlış girdiniz. Bu bölüme girme izniniz yok.");
                txtNote.Enabled = false;
                dgvNotes.Enabled = false;
                btnSave.Enabled = false;
                diaryCalendar.Enabled = false;
                
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            Diary d = new Diary();
            d.Body = Convert.ToString(txtNote.Text);
            d.CategoryId = Convert.ToInt32(txtcatID.Text);
            d.CreatedOn = diaryCalendar.SelectionStart;
            if (d.SaveDiaryNote(d))
            {
                MessageBox.Show("Notlarınız güncellendi!");

            }
            else
                MessageBox.Show("Notlarınız güncellenemedi! ");
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }
        private void dgvNotes_DoubleClick(object sender, EventArgs e)
        {
            diaryCalendar.SelectionStart = Convert.ToDateTime(dgvNotes.SelectedRows[0].Cells[2].Value);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu notunu silmeyi gerçekten istiyor musun?", "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Diary d = new Diary();
                if (d.DeleteDiaryNote(diaryCalendar.SelectionStart, Convert.ToInt32(txtcatID.Text)))
                {
                    MessageBox.Show("Not silindi.");
                }
                else
                {
                    MessageBox.Show("Ups bir sorun var. Notu silemedim.");
                }
            }
        }
      
    }

}
