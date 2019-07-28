namespace TheNoteBookProject
{
    partial class SearchForm
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
            this.dgvAgendaNotes = new System.Windows.Forms.DataGridView();
            this.dgvDiaryNotes = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.ToolStrip();
            this.tsLblFormTitle = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaryNotes)).BeginInit();
            this.formTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgendaNotes
            // 
            this.dgvAgendaNotes.AllowUserToAddRows = false;
            this.dgvAgendaNotes.AllowUserToDeleteRows = false;
            this.dgvAgendaNotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgendaNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaNotes.Location = new System.Drawing.Point(12, 105);
            this.dgvAgendaNotes.Name = "dgvAgendaNotes";
            this.dgvAgendaNotes.ReadOnly = true;
            this.dgvAgendaNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendaNotes.Size = new System.Drawing.Size(430, 289);
            this.dgvAgendaNotes.TabIndex = 0;
            this.dgvAgendaNotes.DoubleClick += new System.EventHandler(this.dgvAgendaNotes_DoubleClick);
            // 
            // dgvDiaryNotes
            // 
            this.dgvDiaryNotes.AllowUserToAddRows = false;
            this.dgvDiaryNotes.AllowUserToDeleteRows = false;
            this.dgvDiaryNotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDiaryNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaryNotes.Location = new System.Drawing.Point(458, 105);
            this.dgvDiaryNotes.Name = "dgvDiaryNotes";
            this.dgvDiaryNotes.ReadOnly = true;
            this.dgvDiaryNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiaryNotes.Size = new System.Drawing.Size(427, 289);
            this.dgvDiaryNotes.TabIndex = 1;
            this.dgvDiaryNotes.DoubleClick += new System.EventHandler(this.dgvDiaryNotes_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(331, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(349, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 31);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // formTitle
            // 
            this.formTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblFormTitle});
            this.formTitle.Location = new System.Drawing.Point(0, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(897, 25);
            this.formTitle.TabIndex = 10;
            this.formTitle.Text = "toolStrip1";
            // 
            // tsLblFormTitle
            // 
            this.tsLblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsLblFormTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.tsLblFormTitle.Name = "tsLblFormTitle";
            this.tsLblFormTitle.Size = new System.Drawing.Size(118, 22);
            this.tsLblFormTitle.Text = "Arama Sayfası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ajanda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(455, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Günlük Notlar";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvDiaryNotes);
            this.Controls.Add(this.dgvAgendaNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "Notlar için Arama Yap";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaryNotes)).EndInit();
            this.formTitle.ResumeLayout(false);
            this.formTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendaNotes;
        private System.Windows.Forms.DataGridView dgvDiaryNotes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStrip formTitle;
        private System.Windows.Forms.ToolStripLabel tsLblFormTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}