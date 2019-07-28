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
    public partial class ContacsForm : Form
    {
        public ContacsForm()
        {
            InitializeComponent();
        }
        BindingSource bs1;
        DataSet ds = new DataSet();
        
        private void ContacsForm_Load(object sender, EventArgs e)
        {
            Color cTitle = Color.FromArgb(0xfff5c3);
            Color titleBC = Color.FromArgb(cTitle.R, cTitle.G, cTitle.B);
            formTitle.BackColor = titleBC;

            this.Top = 0;
            this.Left = 0;

            Contacts cs = new Contacts();
            ds = cs.GetAllRehber();
            bs1 = new BindingSource();
            bs1.DataSource = ds.Tables["Contacts"];

            cs.GetAllRehber(lvKisiler);

            DataBind();
            DataLocation();


        }
        private void DataBind()
        {
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtSurname.DataBindings.Clear();
            txtPhoneNumber.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bs1, "id");
            txtName.DataBindings.Add("Text", bs1, "name");
            txtSurname.DataBindings.Add("Text", bs1, "surname");
            txtPhoneNumber.DataBindings.Add("Text", bs1, "phoneNumber");
            txtEmail.DataBindings.Add("Text", bs1, "email");
            txtAddress.DataBindings.Add("Text", bs1, "address");
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Contacts cs = new Contacts();
            cs.GetAllContactsByNameSurname(txtSearch.Text, lvKisiler);
        }
        private void DataLocation()
        {
            lblLocation.Text = (bs1.Position + 1) + " / " + bs1.Count;
        }
        private void tsFirst_Click(object sender, EventArgs e)
        {
            bs1.Position = 0;
            DataLocation();
        }
        private void tsPrev_Click(object sender, EventArgs e)
        {
            bs1.Position -= 1;
            DataLocation();
        }
        private void tsNext_Click(object sender, EventArgs e)
        {
            bs1.Position += 1;
            DataLocation();
        }
        private void tsLast_Click(object sender, EventArgs e)
        {
            bs1.Position = bs1.Count;
            DataLocation();
        }
        private void lvKisiler_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = lvKisiler.SelectedItems[0].SubItems[0].Text;
            txtName.Text = lvKisiler.SelectedItems[0].SubItems[1].Text;
            txtSurname.Text = lvKisiler.SelectedItems[0].SubItems[2].Text;
            txtPhoneNumber.Text = lvKisiler.SelectedItems[0].SubItems[3].Text;
            txtEmail.Text = lvKisiler.SelectedItems[0].SubItems[4].Text;
            txtAddress.Text = lvKisiler.SelectedItems[0].SubItems[5].Text;
            Contacts cs = new Contacts();
            bs1.Position = cs.ContactOrder(Convert.ToInt32(lvKisiler.SelectedItems[0].SubItems[0].Text));
            DataLocation();
            tsDelete.Enabled = true;
            tsUpdate.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                Contacts cs = new Contacts();
                cs.Name = txtName.Text;
                cs.Surname = txtSurname.Text;
                cs.Telefon = txtPhoneNumber.Text;
                cs.Email = txtEmail.Text;
                cs.Address = txtAddress.Text;

                if (cs.AddContact(cs))
                {
                    bs1.EndEdit();
                    cs.GetAllRehber(lvKisiler);
                    DataBind();
                    DataLocation();
                    btnSave.Enabled = false;
                    tsUpdate.Enabled = true;
                    tsDelete.Enabled = true;
                    MessageBox.Show("Kisi eklendi..");
                }
            }
            else
            {
                MessageBox.Show("Bir isim girmelisiniz!");
            }
        }
        private void tsUpdate_Click(object sender, EventArgs e)
        {
            Contacts cs = new Contacts();
            cs.Id = Convert.ToInt32(txtID.Text);
            cs.Name = txtName.Text;
            cs.Surname = txtSurname.Text;
            cs.Telefon = txtPhoneNumber.Text;
            cs.Email = txtEmail.Text;
            cs.Address = txtAddress.Text;
            if (txtName.Text.Trim() != "")
            {
                cs.Name = txtName.Text;
                if (txtPhoneNumber.Text.Trim() != "")
                {
                    cs.Telefon = txtPhoneNumber.Text;
                }
                if (cs.UpdateContact(cs))
                {
                    bs1.EndEdit();
                    DataBind();
                    cs.GetAllRehber(lvKisiler);
                    DataLocation();
                    MessageBox.Show("Rehberinizde kişi güncellendi.");
                }
            }
            else
            {
                MessageBox.Show("Kişi adı girmelisiniz.");
            }
       
        }
        private void tsNew_Click(object sender, EventArgs e)
        {
            bs1.AddNew();
            btnSave.Enabled = true;
            txtName.Focus();
            tsUpdate.Enabled = false;
            tsDelete.Enabled = false;
            DataLocation();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtName.Text + " adlı kisiyi silmek istiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Contacts cs = new Contacts();
                if (cs.DeleteContact(Convert.ToInt32(txtID.Text)))
                {
                    bs1.EndEdit();
                    MessageBox.Show("Kişi bilgileri silindi.");
                    cs.GetAllRehber(lvKisiler);
                    DataBind();
                    DataLocation();
                }
                else
                {
                    MessageBox.Show("Upss bir sorun var! Silemedim!");
                }
            }
        }
    }
}
