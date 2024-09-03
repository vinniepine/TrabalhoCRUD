using AtividadeCRUD.DAO;
using AtividadeCRUD.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Modes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtividadeCRUD;
public partial class Atualizar : Form
{
    public Atualizar()
    {
        InitializeComponent();
        Fechar();
    }

    void Fechar()
    {
        txtAliq.Enabled = false; txtAliq.BackColor = Color.FromArgb(197, 222, 198);
        txtDescricao.Enabled = false; txtDescricao.BackColor = Color.FromArgb(197, 222, 198);
        cbStatus.Enabled = false; cbStatus.BackColor = Color.FromArgb(197, 222, 198);
        btUpdate.Enabled = false;
    }

    private void btUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            Dispositivo d = new Dispositivo();
            string id = txtID.Text;
            d.ID = int.Parse(id);

            if (!string.IsNullOrWhiteSpace(txtAliq.Text))
            {
                d.Aliquota = double.Parse(txtAliq.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                d.Descricao = txtDescricao.Text;
            }
            if (!string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                d.Status = cbStatus.Text == "Ativo";
            }
            DispositivoDAO dDAO = new DispositivoDAO();
            dDAO.Update(d);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao atualizar: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
    private bool CheckIfExists(int id)
    {

        bool existe = false;
        string query = "SELECT COUNT(*) FROM dispositivos WHERE id = @id";

        using (MySqlCommand cmd = new MySqlCommand(query, Connection.Start()))
        {
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                existe = (count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar ID: " + ex.Message);
            }

            Connection.End();
            return existe;
        }
    }

    private void txtID_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (CheckIfExists(id))
                {
                    txtAliq.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtAliq.BackColor = Color.White;
                    txtDescricao.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtDescricao.BackColor = Color.White;
                    cbStatus.Enabled = !string.IsNullOrWhiteSpace(txtID.Text);
                    btUpdate.Enabled = true;
                }
            }
        } catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }

    private void btVoltar_Click(object sender, EventArgs e)
    {
        Atividade atv = Application.OpenForms["Atividade"] as Atividade;  // Obtém a instância de Form1
        if (atv != null)
        {
            atv.Show();   // Mostra Form1
            this.Close();   // Fecha Form2
        }
    }

    private void txtAliq_KeyUp(object sender, KeyEventArgs e)
    {
        bool numberVerification = false;
        int qtdeVirgulas = txtAliq.Text.Count(v => v == ',');
        if (e.KeyCode == Keys.Enter)
        {
            // Move o foco para o próximo controle no ciclo de tabulação (respeitando o TabIndex)
            this.SelectNextControl((Control)sender, true, true, false, true);
            e.Handled = true; // Marca o evento como tratado
            return;
        }

        if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
        {
            numberVerification = true;
        }
        else
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) numberVerification = true;
            if (e.KeyCode == Keys.Back) numberVerification = true;
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) numberVerification = true;
            if (e.KeyCode == Keys.Tab) numberVerification = true;
            int qtdeVirgula = txtAliq.Text.Count(v => v == ',');
            if (qtdeVirgula > 1) numberVerification = false;

            if (!numberVerification)
            {
                MessageBox.Show("Por favor, use somente números", "IFRO; Ji-Paraná", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAliq.KeyUp -= txtAliq_KeyUp;
                if (txtAliq.Text.Length > 0)
                {
                    txtAliq.Text = txtAliq.Text.Remove(txtAliq.Text.Length - 1);
                }
                txtAliq.SelectionStart = txtAliq.Text.Length;
                txtAliq.KeyUp += txtAliq_KeyUp;
            }
        }
    }

    private void txtID_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void txtID_Leave(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (CheckIfExists(id))
                {
                    txtAliq.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtAliq.BackColor = Color.White;
                    txtDescricao.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtDescricao.BackColor = Color.White;
                    cbStatus.Enabled = !string.IsNullOrWhiteSpace(txtID.Text);
                    btUpdate.Enabled = true;
                }
                else
                {
                    Fechar();
                    MessageBox.Show("ID não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
