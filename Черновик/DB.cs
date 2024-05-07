using Npgsql;

namespace Черновик
{
    class DB
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=89.23.106.97;Port=5432;Username=postgres;Password=supersecretpassword;Database=monik_db");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }
    }
}
