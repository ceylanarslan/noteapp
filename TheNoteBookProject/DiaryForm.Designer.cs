namespace TheNoteBookProject
{
    partial class DiaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaryForm));
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.diaryCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtcatID = new System.Windows.Forms.TextBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.catPicture = new System.Windows.Forms.PictureBox();
            this.formTitle = new System.Windows.Forms.ToolStrip();
            this.tsLblTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripDiaryNotes = new System.Windows.Forms.MenuStrip();
            this.tsTxtCatName = new System.Windows.Forms.ToolStripTextBox();
            this.txtTarih = new System.Windows.Forms.ToolStripTextBox();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteBookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forLaterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).BeginInit();
            this.formTitle.SuspendLayout();
            this.menuStripDiaryNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(318, 59);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(522, 387);
            this.txtNote.TabIndex = 6;
            this.txtNote.Text = "";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // diaryCalendar
            // 
            this.diaryCalendar.Location = new System.Drawing.Point(7, 9);
            this.diaryCalendar.MaxSelectionCount = 1;
            this.diaryCalendar.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.diaryCalendar.Name = "diaryCalendar";
            this.diaryCalendar.TabIndex = 10;
            this.diaryCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.diaryCalendar_DateChanged);
            // 
            // txtcatID
            // 
            this.txtcatID.Location = new System.Drawing.Point(165, 452);
            this.txtcatID.Name = "txtcatID";
            this.txtcatID.Size = new System.Drawing.Size(30, 20);
            this.txtcatID.TabIndex = 11;
            // 
            // dgvNotes
            // 
            this.dgvNotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvNotes.Location = new System.Drawing.Point(10, 174);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(231, 267);
            this.dgvNotes.TabIndex = 12;
            this.dgvNotes.DoubleClick += new System.EventHandler(this.dgvNotes_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.dgvNotes);
            this.panel1.Controls.Add(this.diaryCalendar);
            this.panel1.Location = new System.Drawing.Point(846, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 448);
            this.panel1.TabIndex = 13;
            // 
            // catPicture
            // 
            this.catPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.catPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catPicture.Image = ((System.Drawing.Image)(resources.GetObject("catPicture.Image")));
            this.catPicture.Location = new System.Drawing.Point(12, 58);
            this.catPicture.Name = "catPicture";
            this.catPicture.Size = new System.Drawing.Size(300, 449);
            this.catPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catPicture.TabIndex = 14;
            this.catPicture.TabStop = false;
            // 
            // formTitle
            // 
            this.formTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblTitle,
            this.toolStripSeparator2});
            this.formTitle.Location = new System.Drawing.Point(0, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(1100, 25);
            this.formTitle.TabIndex = 17;
            this.formTitle.Text = "Günlüğüm";
            // 
            // tsLblTitle
            // 
            this.tsLblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsLblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.tsLblTitle.Name = "tsLblTitle";
            this.tsLblTitle.Size = new System.Drawing.Size(79, 22);
            this.tsLblTitle.Text = "Notlarım";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStripDiaryNotes
            // 
            this.menuStripDiaryNotes.BackColor = System.Drawing.Color.Red;
            this.menuStripDiaryNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxtCatName,
            this.txtTarih,
            this.kategorilerToolStripMenuItem});
            this.menuStripDiaryNotes.Location = new System.Drawing.Point(0, 25);
            this.menuStripDiaryNotes.Name = "menuStripDiaryNotes";
            this.menuStripDiaryNotes.Size = new System.Drawing.Size(1100, 28);
            this.menuStripDiaryNotes.TabIndex = 18;
            this.menuStripDiaryNotes.Text = "menuStrip1";
            // 
            // tsTxtCatName
            // 
            this.tsTxtCatName.BackColor = System.Drawing.Color.Red;
            this.tsTxtCatName.ForeColor = System.Drawing.Color.White;
            this.tsTxtCatName.Name = "tsTxtCatName";
            this.tsTxtCatName.ReadOnly = true;
            this.tsTxtCatName.Size = new System.Drawing.Size(100, 24);
            // 
            // txtTarih
            // 
            this.txtTarih.BackColor = System.Drawing.Color.Red;
            this.txtTarih.ForeColor = System.Drawing.Color.White;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(100, 24);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kategorilerToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteBookMenuItem,
            this.travelMenuItem,
            this.workingMenuItem,
            this.lessonMenuItem,
            this.forLaterMenuItem,
            this.diaryMenuItem,
            this.privateMenuItem});
            this.kategorilerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kategorilerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.kategorilerToolStripMenuItem.Text = "Başka bir kategori seçin";
            // 
            // noteBookMenuItem
            // 
            this.noteBookMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.noteBookMenuItem.Name = "noteBookMenuItem";
            this.noteBookMenuItem.Size = new System.Drawing.Size(183, 24);
            this.noteBookMenuItem.Text = "Not Defterim";
            this.noteBookMenuItem.Click += new System.EventHandler(this.noteBookMenuItem_Click);
            // 
            // travelMenuItem
            // 
            this.travelMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.travelMenuItem.Name = "travelMenuItem";
            this.travelMenuItem.Size = new System.Drawing.Size(183, 24);
            this.travelMenuItem.Text = "Seyahat Notlarım";
            this.travelMenuItem.Click += new System.EventHandler(this.travelMenuItem_Click);
            // 
            // workingMenuItem
            // 
            this.workingMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.workingMenuItem.Name = "workingMenuItem";
            this.workingMenuItem.Size = new System.Drawing.Size(183, 24);
            this.workingMenuItem.Text = "İş Notlarım";
            this.workingMenuItem.Click += new System.EventHandler(this.workMenuItem_Click);
            // 
            // lessonMenuItem
            // 
            this.lessonMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.lessonMenuItem.Name = "lessonMenuItem";
            this.lessonMenuItem.Size = new System.Drawing.Size(183, 24);
            this.lessonMenuItem.Text = "Ders Notlarım";
            this.lessonMenuItem.Click += new System.EventHandler(this.lessonMenuItem_Click);
            // 
            // forLaterMenuItem
            // 
            this.forLaterMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.forLaterMenuItem.Name = "forLaterMenuItem";
            this.forLaterMenuItem.Size = new System.Drawing.Size(183, 24);
            this.forLaterMenuItem.Text = "Sonra Bakarım";
            this.forLaterMenuItem.Click += new System.EventHandler(this.forLaterMenuItem_Click);
            // 
            // diaryMenuItem
            // 
            this.diaryMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.diaryMenuItem.Name = "diaryMenuItem";
            this.diaryMenuItem.Size = new System.Drawing.Size(183, 24);
            this.diaryMenuItem.Text = "Günlüğüm";
            this.diaryMenuItem.Click += new System.EventHandler(this.diaryMenuItem_Click);
            // 
            // privateMenuItem
            // 
            this.privateMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.privateMenuItem.Name = "privateMenuItem";
            this.privateMenuItem.Size = new System.Drawing.Size(183, 24);
            this.privateMenuItem.Text = "Gizli Notlar";
            this.privateMenuItem.Click += new System.EventHandler(this.privateMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(739, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 57);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(632, 452);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 57);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1100, 510);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStripDiaryNotes);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.catPicture);
            this.Controls.Add(this.txtcatID);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiaryForm";
            this.Text = "Diary  Form";
            this.Load += new System.EventHandler(this.DiaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).EndInit();
            this.formTitle.ResumeLayout(false);
            this.formTitle.PerformLayout();
            this.menuStripDiaryNotes.ResumeLayout(false);
            this.menuStripDiaryNotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.MonthCalendar diaryCalendar;
        private System.Windows.Forms.TextBox txtcatID;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox catPicture;
        private System.Windows.Forms.ToolStrip formTitle;
        private System.Windows.Forms.MenuStrip menuStripDiaryNotes;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteBookMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forLaterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaryMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripLabel tsLblTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtTarih;
        private System.Windows.Forms.ToolStripTextBox tsTxtCatName;
        private System.Windows.Forms.Button btnDelete;
    }
}