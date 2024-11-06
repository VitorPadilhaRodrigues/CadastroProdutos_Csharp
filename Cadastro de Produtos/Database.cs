using MySql.Data.MySqlClient;
using System.Data;

public class Database
{
    private MySqlConnection connection;

    public Database()
    {
        string connectionString = "server=localhost;database=CadastroProduto;user=root;password=familia1;";
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}

