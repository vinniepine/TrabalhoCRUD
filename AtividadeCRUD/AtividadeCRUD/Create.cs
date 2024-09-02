using AtividadeCRUD.DAO;
using AtividadeCRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeCRUD;
public partial class Create : Form
{
    public Create()
    {
        InitializeComponent();
        MaximizeBox = false;
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
        catch (Exception es)
        {
            MessageBox.Show(es.Message, "IFRO; Ji-Paraná", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
    public bool FulfilledBoxes()
    {
        if (string.IsNullOrEmpty(txtAliq.Text) || txtAliq.Text == ",")
        {
            MessageBox.Show("Por favor, preencha o campo da alíquota.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrEmpty(cbStatus.Text))
        {
            MessageBox.Show("Por favor, selecione o status do dispositivo.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrEmpty(txtDescricao.Text))
        {
            MessageBox.Show("Por favor, preencha a descrição.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }
    private void btCreate_Click(object sender, EventArgs e)
    {
        FulfilledBoxes();
        try
        {
            Dispositivo d = new Dispositivo();
            d.Aliquota = double.Parse(txtAliq.Text);
            d.Descricao = txtDescricao.Text;
            d.Status = cbStatus.Text == "Ativo" ? true : false;
            DispositivoDAO dDAO = new DispositivoDAO();
            dDAO.Insert(d);
        }
        catch (FormatException ex)
        {
            throw new Exception(" Formato inválido. Verifique os valores de entrada.", ex);
        }
        catch (Exception es)
        {
            Console.WriteLine(es.Message);
        }
        finally
        {
            MessageBox.Show("Dispositivo Cadastrado", "IFRO; Ji-Paraná", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAliq.Clear(); txtDescricao.Clear(); cbStatus.SelectedIndex = -1;

        }
    }

    private void btVoltar_KeyUp(object sender, KeyEventArgs e)
    {

    }

    private void txtDescricao_TextChanged(object sender, EventArgs e)
    {

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



}
