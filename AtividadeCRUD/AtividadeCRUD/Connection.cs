using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AtividadeCRUD;
internal class Connection
{
    static MySqlConnection _connection; // Declaração de objeto da classe 'MySqlConnection' responsável por controlar a conexão com a base;
    public static MySqlConnection Open()
    {
        try
        {
            string newConnection = "server=localhost;port=3306;uid=root;pwd=root;database=bd_isoul_sales";
            _connection = new MySqlConnection(newConnection); // instanciando o objeto da classe 'MySqlConnection';
            _connection.Open();
        }
        catch (Exception ex)
        {
            // Console.WriteLine("Erro ao realizar a conexão com a base de dados!");
            throw new Exception("Erro ao realizar a conexão com a base de dados! " + ex.Message);
        }
        return _connection;
    }
    public static void Close()
    {
        _connection.Close();
    }
}
