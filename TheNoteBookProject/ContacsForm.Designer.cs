namespace TheNoteBookProject
{
    partial class ContacsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContacsForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvKisiler = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.formTitle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblDescription = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFirst = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.lblLocation = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.formTitle.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 55);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lvKisiler
            // 
            this.lvKisiler.BackColor = System.Drawing.Color.SeaShell;
            this.lvKisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvKisiler.FullRowSelect = true;
            this.lvKisiler.Location = new System.Drawing.Point(20, 86);
            this.lvKisiler.Margin = new System.Windows.Forms.Padding(4);
            this.lvKisiler.Name = "lvKisiler";
            this.lvKisiler.Size = new System.Drawing.Size(712, 426);
            this.lvKisiler.TabIndex = 9;
            this.lvKisiler.UseCompatibleStateImageBehavior = false;
            this.lvKisiler.View = System.Windows.Forms.View.Details;
            this.lvKisiler.DoubleClick += new System.EventHandler(this.lvKisiler_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-mail";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(756, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Kişi";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(131, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 57);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.SeaShell;
            this.txtID.Location = new System.Drawing.Point(100, 19);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(1, 21);
            this.txtID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = " Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = " E-mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = " Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "  Adı :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(100, 236);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 74);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 189);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(100, 143);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 23);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(100, 103);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 23);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 21);
            this.txtName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ada Göre Arama";
            // 
            // formTitle
            // 
            this.formTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.formTitle.Location = new System.Drawing.Point(0, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(1048, 25);
            this.formTitle.TabIndex = 13;
            this.formTitle.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel1.Text = "Rehber";
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(346, 23);
            this.lblDescription.Text = "Kişilerinizi görebilir, ekleme ve güncelleme yapabilirsiniz.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // tsNew
            // 
            this.tsNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(91, 23);
            this.tsNew.Text = "&Yeni Kişi Ekle";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 26);
            // 
            // tsUpdate
            // 
            this.tsUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(99, 23);
            this.tsUpdate.Text = "Kişiyi &Güncelle";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 26);
            // 
            // tsDelete
            // 
            this.tsDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(60, 23);
            this.tsDelete.Text = "Kişiyi &Sil";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 26);
            // 
            // tsFirst
            // 
            this.tsFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsFirst.Image")));
            this.tsFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFirst.Name = "tsFirst";
            this.tsFirst.Size = new System.Drawing.Size(33, 23);
            this.tsFirst.Text = "<<";
            this.tsFirst.Click += new System.EventHandler(this.tsFirst_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 26);
            // 
            // tsPrev
            // 
            this.tsPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsPrev.Image")));
            this.tsPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrev.Name = "tsPrev";
            this.tsPrev.Size = new System.Drawing.Size(23, 23);
            this.tsPrev.Text = "<";
            this.tsPrev.Click += new System.EventHandler(this.tsPrev_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 26);
            // 
            // lblLocation
            // 
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 23);
            this.lblLocation.Text = "1 / 100";
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(6, 26);
            // 
            // tsNext
            // 
            this.tsNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsNext.Image = ((System.Drawing.Image)(resources.GetObject("tsNext.Image")));
            this.tsNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNext.Name = "tsNext";
            this.tsNext.Size = new System.Drawing.Size(23, 23);
            this.tsNext.Text = ">";
            this.tsNext.Click += new System.EventHandler(this.tsNext_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 26);
            // 
            // tsLast
            // 
            this.tsLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsLast.Image = ((System.Drawing.Image)(resources.GetObject("tsLast.Image")));
            this.tsLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLast.Name = "tsLast";
            this.tsLast.Size = new System.Drawing.Size(33, 23);
            this.tsLast.Text = ">>";
            this.tsLast.Click += new System.EventHandler(this.tsLast_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Red;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDescription,
            this.toolStripSeparator3,
            this.tsNew,
            this.toolStripSeparator10,
            this.tsUpdate,
            this.toolStripSeparator13,
            this.tsDelete,
            this.toolStripSeparator15,
            this.tsFirst,
            this.toolStripSeparator20,
            this.tsPrev,
            this.toolStripSeparator21,
            this.lblLocation,
            this.toolStripSeparator22,
            this.tsNext,
            this.toolStripSeparator23,
            this.tsLast,
            this.toolStripSeparator17});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 26);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ara";
            // 
            // ContacsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1048, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvKisiler);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContacsForm";
            this.Text = "w";
            this.Load += new System.EventHandler(this.ContacsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.formTitle.ResumeLayout(false);
            this.formTitle.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvKisiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip formTitle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblDescription;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton tsFirst;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton tsPrev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripLabel lblLocation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripButton tsNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripButton tsLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label6;
    }
}