namespace TheNoteBookProject
{
    partial class ReminderForm
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
            this.dgvReminder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReminder
            // 
            this.dgvReminder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReminder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminder.Location = new System.Drawing.Point(3, 50);
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.Size = new System.Drawing.Size(622, 160);
            this.dgvReminder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bugün unutmamanız gereken şeyler var gibi görünüyor!";
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReminder);
            this.MaximizeBox = false;
            this.Name = "ReminderForm";
            this.Text = "Hatırlatıcı";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReminderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReminder;
        private System.Windows.Forms.Label label1;
    }
}