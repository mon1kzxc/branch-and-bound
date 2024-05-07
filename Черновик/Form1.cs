using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Черновик
{
    public partial class Form1 : Form
    {
        private DB _db;

        public Form1()
        {
            InitializeComponent();
            _db = new DB();
        }

        private void Отмена_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Авторизация_Click(object sender, EventArgs e)
        {
            string LoginUser = LoginAut.Text;
            string PasswordUser = Passwordaut.Text;

            bool isAuthenticated = Authenticate(LoginUser, PasswordUser);

            if (isAuthenticated)
            {
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Логин или пароль не совпадают. Попробуйте ввести данные еще раз");
            }
        }

        private bool Authenticate(string login, string password)
        {
            _db.openConnection();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE Login = @uL AND Password = @uP", _db.GetConnection());
            command.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Varchar).Value = login;
            command.Parameters.Add("@uP", NpgsqlTypes.NpgsqlDbType.Varchar).Value = password;

            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    _db.closeConnection();
                    return true;
                }
            }

            _db.closeConnection();
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
