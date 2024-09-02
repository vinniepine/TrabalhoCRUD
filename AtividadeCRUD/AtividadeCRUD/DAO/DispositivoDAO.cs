using AtividadeCRUD.Models;
using MySql.Data.MySqlClient;
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
            var sql = "SELECT id, aliquota, descricao, status_dispositivo FROM dispositivos";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.Start());
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dispositivo d = new Dispositivo();
                    d.ID = reader.GetInt32("Id");
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
        finally
        {
            Connection.End(); 
        }
        return deviceList;
    }


    // feito em sala, referência arquivo baixado do que enviei pra a Sunamita
    public bool Update(Dispositivo d)
    {
        List<string> updates = new List<string>();
        try
        {
            if (d.Aliquota.HasValue)
                updates.Add("aliquota = @aliquota");
            if (!string.IsNullOrEmpty(d.Descricao))
                updates.Add("descricao = @descricao");
            if (d.Status.HasValue)
                updates.Add("status_dispositivo = @status");

            if (updates.Count == 0)
            {
                throw new Exception("Nenhum campo para atualizar.");
            }

            string sql = $"UPDATE dispositivos SET {string.Join(", ", updates)} WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.Start());

            if (d.Aliquota.HasValue)
                cmd.Parameters.AddWithValue("@aliquota", d.Aliquota);
            if (!string.IsNullOrEmpty(d.Descricao))
                cmd.Parameters.AddWithValue("@descricao", d.Descricao);
            if (d.Status.HasValue)
                cmd.Parameters.AddWithValue("@status", d.Status);

            cmd.Parameters.AddWithValue("@id", d.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao atualizar dispositivo! {ex.Message}");
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
            string sql = "SELECT COUNT(1) FROM dispositivos WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connection.Start()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao verificar a existência do dispositivo! {ex.Message}");
        }
        finally
        {
            Connection.End();
        }
    }
}
