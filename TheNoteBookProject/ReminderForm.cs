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
    public partial class ReminderForm : Form
    {
        public ReminderForm()
        {
            InitializeComponent();
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {
            this.Focus();
            Agenda agd = new Agenda();
            dgvReminder.DataSource = agd.GetNotesByRemindOn();
            dgvReminder.Columns[0].Width = 500;
        }
    }
}
