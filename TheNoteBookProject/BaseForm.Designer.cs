namespace TheNoteBookProject
{
    partial class BaseForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnDiary = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDateToday = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelMenu.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.btnOptions);
            this.panelMenu.Controls.Add(this.btnGuide);
            this.panelMenu.Controls.Add(this.btnDiary);
            this.panelMenu.Controls.Add(this.btnAgenda);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(89, 661);
            this.panelMenu.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(-1, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Oturumu Kapat";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(1, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Arama Yap";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.LightSalmon;
            this.btnOptions.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOptions.Location = new System.Drawing.Point(-1, 265);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(90, 55);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Ayarlar";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGuide.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuide.Location = new System.Drawing.Point(-1, 202);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(90, 55);
            this.btnGuide.TabIndex = 2;
            this.btnGuide.Text = "Rehber";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnDiary
            // 
            this.btnDiary.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDiary.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiary.Location = new System.Drawing.Point(-1, 139);
            this.btnDiary.Name = "btnDiary";
            this.btnDiary.Size = new System.Drawing.Size(90, 55);
            this.btnDiary.TabIndex = 1;
            this.btnDiary.Text = "Günlük Notlarım";
            this.btnDiary.UseVisualStyleBackColor = false;
            this.btnDiary.Click += new System.EventHandler(this.btnDiary_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAgenda.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAgenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgenda.Location = new System.Drawing.Point(-1, 76);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(90, 55);
            this.btnAgenda.TabIndex = 0;
            this.btnAgenda.Text = "Ajanda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusDateToday});
            this.statusMain.Location = new System.Drawing.Point(89, 639);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1095, 22);
            this.statusMain.TabIndex = 7;
            this.statusMain.Text = "Status";
            // 
            // statusInfo
            // 
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(1019, 17);
            this.statusInfo.Spring = true;
            this.statusInfo.Text = "Kişisel not defterinize hoşgeldiniz! Ajanda\'da planlar yapabilir, Günlük Notlar e" +
    "klemeye başlayabilirsiniz!";
            // 
            // statusDateToday
            // 
            this.statusDateToday.Name = "statusDateToday";
            this.statusDateToday.Size = new System.Drawing.Size(61, 17);
            this.statusDateToday.Text = "00.00.0000";
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(89, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1095, 3);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnDiary;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusDateToday;

    }
}



