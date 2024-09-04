using AtividadeCRUD.DAO;
using AtividadeCRUD.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Modes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtividadeCRUD;
public partial class Atualizar : Form
{
    private bool _isNavigatingBack = false; // Variável de controle
    public Atualizar()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        FecharTextBoxes();

    }

    void FecharTextBoxes()
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
            MessageBox.Show("Atualização concluída com sucesso. ", "IFRO; Ji-Paraná", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAliq.Clear(); txtDescricao.Clear(); txtID.Clear(); cbStatus.SelectedIndex = -1;

        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao atualizar: "+ ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void txtID_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                if (DispositivoDAO.Exists(id))
                {
                    txtAliq.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtAliq.BackColor = Color.White;
                    txtDescricao.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtDescricao.BackColor = Color.White;
                    cbStatus.Enabled = !string.IsNullOrWhiteSpace(txtID.Text);
                    btUpdate.Enabled = true;
                }
                else
                {
                    FecharTextBoxes();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }

    private void btVoltar_Click(object sender, EventArgs e)
    {
        _isNavigatingBack = true;
        try
        {
            Atividade atv = Application.OpenForms["Atividade"] as Atividade;  
            if (atv != null)
            {
                atv.Show();   // Mostra Form1
                this.Close();   // Fecha Form2
            }
        }
        finally
        {
            _isNavigatingBack = false; // Restaura a variável após a ação do botão
        }
    }

    private void txtAliq_KeyUp(object sender, KeyEventArgs e)
    {
        try
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
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }
    }

    private void txtID_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void txtID_Leave(object sender, EventArgs e)
    {
        if (_isNavigatingBack) 
        
        {
            return; 
        }
        /* a verificação de txtID_Leave na hierarquia de chamadas parece 
         * vir antes da verificação do _isNavigatingBack no btVoltar_Click,
         * e por isso, por padrão is _isNavigatingBack está falso. Para ele
         * ficar verdadeiro e assim bloquear a chamada do txtID_Leave, foi
         * preciso pedir por (!_isNavigatingBack), que retorna True, e assim
         * permite o funcionamento de btVoltar_Click.
        */
        else
        {
            try
            {
                Debug.WriteLine($"ID do texto: {txtID.Text}");

                if (int.TryParse(txtID.Text, out int id))
                {
                    Debug.WriteLine($"Verificando ID: {id}");

                    if (DispositivoDAO.Exists(id))
                    {
                        txtAliq.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtAliq.BackColor = Color.White;
                        txtDescricao.Enabled = !string.IsNullOrWhiteSpace(txtID.Text); txtDescricao.BackColor = Color.White;
                        cbStatus.Enabled = !string.IsNullOrWhiteSpace(txtID.Text);
                        btUpdate.Enabled = true;
                    }
                    else
                    {
                        FecharTextBoxes();
                        MessageBox.Show("ID não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtID.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Saindo do método txtID_Leave");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
    }
}
