using Npgsql;
using NUnit.Framework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Черновик
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Регистрация_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            bool nextStep = false;
            NpgsqlCommand sqlCommand = new NpgsqlCommand("SELECT * FROM users WHERE Login = @login", db.GetConnection());
            sqlCommand.Parameters.AddWithValue("login", Login.Text);
            NpgsqlDataReader reader = sqlCommand.ExecuteReader();

            if (!passwordsMatch)
            {
                RepeatPas.BackColor = Color.LightCoral;
                MessageBox.Show("Пароли не совпадают. Пожалуйста, проверьте ввод.");
                return; // Stop the registration process if passwords don't match
            }

            if (reader.HasRows)
            {
                Login.BackColor = Color.LightCoral;
                MessageBox.Show("Этот логин уже занят. Попробуйте придумать другой логин");
                reader.Close();
            }
            if (string.IsNullOrWhiteSpace(Login.Text))
            {
                Login.BackColor = Color.LightCoral;
                MessageBox.Show("Введите логин.");
                return; // Прекращаем выполнение метода, если логин не введен
            }
            else
            {
                reader.Close();

                if (Email.Text.Length >= 8 && Email.Text.Contains("@") && Email.Text.Contains(".") && Password.Text.Length >= 8 && Login.Text.Length >= 4)
                {
                    nextStep = true;
                }
                else
                {
                    Email.BackColor = Color.LightCoral;
                    Login.BackColor = Color.LightCoral;
                    Password.BackColor = Color.LightCoral;
                    MessageBox.Show("Что-то введено неверно, проверьте ввод. Пароль должен содержать не менее 8 символов.");
                }
            }

            if (nextStep == true)
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO users (email, login, password) VALUES (@email, @login, @password)", db.GetConnection());
                command.Parameters.AddWithValue("email", Email.Text);
                command.Parameters.AddWithValue("login", Login.Text);
                command.Parameters.AddWithValue("password", Password.Text);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Поздравляем!!! У вас есть аккаунт");
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных");
                }

                db.closeConnection();

                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.ShowDialog();
            }
        }


        private void Отмена_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.ShowDialog();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private bool passwordsMatch = false;

        private void RepeatPas_TextChanged(object sender, EventArgs e)
        {
            // Check if the password and repeated password match
            if (Password.Text == RepeatPas.Text)
            {
                RepeatPas.BackColor = Color.White; // Reset background color if they match

                passwordsMatch = true;
            }
            else
            {
                RepeatPas.BackColor = Color.LightCoral;
                passwordsMatch = false;
            }
        }
    }
}
