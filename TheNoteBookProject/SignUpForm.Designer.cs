namespace TheNoteBookProject
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.lblPwdControl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnForgotPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(225, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(225, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(436, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E mail :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(298, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(298, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(505, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(298, 143);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Size = new System.Drawing.Size(100, 20);
            this.txtpassword2.TabIndex = 3;
            this.txtpassword2.UseSystemPasswordChar = true;
            this.txtpassword2.TextChanged += new System.EventHandler(this.txtpassword2_TextChanged);
            // 
            // lblPwdControl
            // 
            this.lblPwdControl.AutoSize = true;
            this.lblPwdControl.BackColor = System.Drawing.Color.Transparent;
            this.lblPwdControl.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPwdControl.Location = new System.Drawing.Point(295, 166);
            this.lblPwdControl.Name = "lblPwdControl";
            this.lblPwdControl.Size = new System.Drawing.Size(109, 13);
            this.lblPwdControl.TabIndex = 7;
            this.lblPwdControl.Text = "*Şifrenizi tekrar giriniz.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(505, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(436, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adınız:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(505, 117);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(436, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Soyadınız:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSignUp.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignUp.Location = new System.Drawing.Point(512, 184);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(93, 31);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Hesap Aç";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnForgotPwd
            // 
            this.btnForgotPwd.BackColor = System.Drawing.Color.LightSalmon;
            this.btnForgotPwd.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForgotPwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForgotPwd.Location = new System.Drawing.Point(512, 237);
            this.btnForgotPwd.Name = "btnForgotPwd";
            this.btnForgotPwd.Size = new System.Drawing.Size(93, 44);
            this.btnForgotPwd.TabIndex = 16;
            this.btnForgotPwd.Text = "Şifremi Unuttum";
            this.btnForgotPwd.UseVisualStyleBackColor = false;
            this.btnForgotPwd.Click += new System.EventHandler(this.btnForgotPwd_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnForgotPwd);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.lblPwdControl);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Oluştur";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Label lblPwdControl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnForgotPwd;
    }
}