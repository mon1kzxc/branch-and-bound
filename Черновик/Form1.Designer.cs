
namespace Черновик
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginAut = new System.Windows.Forms.TextBox();
            this.Авторизация = new System.Windows.Forms.Button();
            this.Passwordaut = new System.Windows.Forms.TextBox();
            this.Отмена = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginAut
            // 
            this.LoginAut.Location = new System.Drawing.Point(75, 24);
            this.LoginAut.Margin = new System.Windows.Forms.Padding(2);
            this.LoginAut.Name = "LoginAut";
            this.LoginAut.Size = new System.Drawing.Size(254, 20);
            this.LoginAut.TabIndex = 0;
            this.LoginAut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Авторизация
            // 
            this.Авторизация.Location = new System.Drawing.Point(75, 86);
            this.Авторизация.Margin = new System.Windows.Forms.Padding(2);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(151, 39);
            this.Авторизация.TabIndex = 1;
            this.Авторизация.Text = "Авторизация";
            this.Авторизация.UseVisualStyleBackColor = true;
            this.Авторизация.Click += new System.EventHandler(this.Авторизация_Click);
            // 
            // Passwordaut
            // 
            this.Passwordaut.Location = new System.Drawing.Point(75, 54);
            this.Passwordaut.Margin = new System.Windows.Forms.Padding(2);
            this.Passwordaut.Name = "Passwordaut";
            this.Passwordaut.PasswordChar = '*';
            this.Passwordaut.Size = new System.Drawing.Size(254, 20);
            this.Passwordaut.TabIndex = 2;
            // 
            // Отмена
            // 
            this.Отмена.Location = new System.Drawing.Point(266, 86);
            this.Отмена.Margin = new System.Windows.Forms.Padding(2);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(62, 39);
            this.Отмена.TabIndex = 3;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.Отмена_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Passwordaut);
            this.Controls.Add(this.Авторизация);
            this.Controls.Add(this.LoginAut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginAut;
        private System.Windows.Forms.Button Авторизация;
        private System.Windows.Forms.TextBox Passwordaut;
        private System.Windows.Forms.Button Отмена;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

