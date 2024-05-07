
namespace Черновик
{
    partial class Form3
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
            this.Отмена = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Регистрация = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.LoginReg = new System.Windows.Forms.Label();
            this.PasswordReg = new System.Windows.Forms.Label();
            this.Reppas = new System.Windows.Forms.Label();
            this.RepeatPas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Отмена
            // 
            this.Отмена.Location = new System.Drawing.Point(304, 171);
            this.Отмена.Margin = new System.Windows.Forms.Padding(2);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(62, 39);
            this.Отмена.TabIndex = 8;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.Отмена_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(112, 103);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(254, 20);
            this.Password.TabIndex = 7;
            // 
            // Регистрация
            // 
            this.Регистрация.Location = new System.Drawing.Point(112, 171);
            this.Регистрация.Margin = new System.Windows.Forms.Padding(2);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(151, 39);
            this.Регистрация.TabIndex = 6;
            this.Регистрация.Text = "Регистрация";
            this.Регистрация.UseVisualStyleBackColor = true;
            this.Регистрация.Click += new System.EventHandler(this.Регистрация_Click_1);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(112, 37);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(254, 20);
            this.Email.TabIndex = 5;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(112, 68);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(254, 20);
            this.Login.TabIndex = 10;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(29, 41);
            this.mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(32, 13);
            this.mail.TabIndex = 12;
            this.mail.Text = "Email";
            // 
            // LoginReg
            // 
            this.LoginReg.AutoSize = true;
            this.LoginReg.Location = new System.Drawing.Point(29, 72);
            this.LoginReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginReg.Name = "LoginReg";
            this.LoginReg.Size = new System.Drawing.Size(33, 13);
            this.LoginReg.TabIndex = 13;
            this.LoginReg.Text = "Login";
            // 
            // PasswordReg
            // 
            this.PasswordReg.AutoSize = true;
            this.PasswordReg.Location = new System.Drawing.Point(22, 107);
            this.PasswordReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordReg.Name = "PasswordReg";
            this.PasswordReg.Size = new System.Drawing.Size(53, 13);
            this.PasswordReg.TabIndex = 14;
            this.PasswordReg.Text = "Password";
            // 
            // Reppas
            // 
            this.Reppas.AutoSize = true;
            this.Reppas.Location = new System.Drawing.Point(0, 139);
            this.Reppas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Reppas.Name = "Reppas";
            this.Reppas.Size = new System.Drawing.Size(108, 13);
            this.Reppas.TabIndex = 15;
            this.Reppas.Text = "Repeat the password";
            this.Reppas.Click += new System.EventHandler(this.label5_Click);
            // 
            // RepeatPas
            // 
            this.RepeatPas.Location = new System.Drawing.Point(112, 136);
            this.RepeatPas.Margin = new System.Windows.Forms.Padding(2);
            this.RepeatPas.Name = "RepeatPas";
            this.RepeatPas.PasswordChar = '*';
            this.RepeatPas.Size = new System.Drawing.Size(254, 20);
            this.RepeatPas.TabIndex = 16;
            this.RepeatPas.TextChanged += new System.EventHandler(this.RepeatPas_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 250);
            this.Controls.Add(this.RepeatPas);
            this.Controls.Add(this.Reppas);
            this.Controls.Add(this.PasswordReg);
            this.Controls.Add(this.LoginReg);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Регистрация);
            this.Controls.Add(this.Email);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Отмена;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Регистрация;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label LoginReg;
        private System.Windows.Forms.Label PasswordReg;
        private System.Windows.Forms.Label Reppas;
        private System.Windows.Forms.TextBox RepeatPas;
    }
}