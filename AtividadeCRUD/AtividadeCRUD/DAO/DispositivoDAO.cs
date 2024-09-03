using AtividadeCRUD.Models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCRUD.DAO;
internal class DispositivoDAO
{
    public void Insert(Dispositivo dd)
    {
        try
        {
            string sqlQuery = "INSERT INTO dispositivos (aliquota, descricao, status_dispositivo) VALUES (@fee, @descr, @status)";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, Connection.Start());
            cmd.Parameters.AddWithValue("@fee", dd.Aliquota);
            cmd.Parameters.AddWithValue("@descr", dd.Descricao);
            cmd.Parameters.AddWithValue("@status", dd.Status);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Dispositivo cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao cadastrar dispositivo! {ex.Message}");
        }
        finally
        {
            Connection.End();
        }
    }
    public void Delete(Dispositivo dd)
    {
        try
        {
            string sql = "DELETE FROM dispositivos WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connection.Start()))
            {
                cmd.Parameters.AddWithValue("@id", dd.ID);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao excluir o dispositivo! {ex.Message}");
        }
        finally
        {
            Connection.End();
        }
    }
    public List<Dispositivo> List()
    {
        List<Dispositivo> deviceList = new List<Dispositivo>();

        try
        {
            var sql = "SELECT * FROM dispositivos";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.Start());
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dispositivo d = new Dispositivo();
                    d.ID = reader.GetInt32("id");
                    d.Aliquota = reader.GetDouble("aliquota");
                    d.Descricao = reader.GetString("descricao");
                    d.Status = reader.GetBoolean("status_dispositivo");
                    deviceList.Add(d);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao excluir o dispositivo! {ex.Message}");
        }
        finally { Connection.End(); }
        return deviceList;
    }


    // feito em sala, referência arquivo baixado do que enviei pra a Sunamita
    public void Update(Dispositivo d)
    {
        if (d == null || d.ID <= 0)
        {
            throw new ArgumentException("Dispositivo inválido ou ID não fornecido.");
        }
        List<string> updates = new List<string>();
        string sql = "UPDATE Dispositivos SET ";
        var parameters = new List<MySqlParameter>();

        try
        {
           
            if (d.Aliquota != null)
            {
                updates.Add("Aliquota = @Aliquota");
                parameters.Add(new MySqlParameter("@Aliquota", d.Aliquota));
            }

            if (!string.IsNullOrWhiteSpace(d.Descricao))
            {
                updates.Add("Descricao = @Descricao");
                parameters.Add(new MySqlParameter("@Descricao", d.Descricao));
            }

            if (d.Status != null)
            {
                updates.Add("status_dispositivo = @Status");
                parameters.Add(new MySqlParameter("@Status", d.Status));
            }
            if (updates.Count == 0)
            {
                throw new InvalidOperationException("Nenhum campo para atualizar.");
            }
            // Remover a última vírgula e espaço
            sql += string.Join(", ", updates) + " WHERE Id = @Id";
            parameters.Add(new MySqlParameter("@Id", d.ID));

            using (var conn = Connection.Start())
            {
                using (var command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Atualização concluída com sucesso. ", "IFRO; Ji-Paraná", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar dispositivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            conn.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao atualizar dispositivo " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Connection.End();
        }
    }
    public bool Exists(int id)
    {
        try
        {
            string sql = "SELECT COUNT(*) FROM dispositivos WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connection.Start()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("ID inexistente! " +ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            Connection.End();
        }
    }
}
