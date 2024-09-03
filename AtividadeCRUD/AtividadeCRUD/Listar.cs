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
public partial class Listar : Form
{
    private DispositivoDAO dispositivoDAO;
    public Listar()
    {
        InitializeComponent();
        dispositivoDAO = new DispositivoDAO();
        LoadList();
    }

    private void LoadList()
    {
        List<Dispositivo> listaDispo = dispositivoDAO.List();
        dgvDispo.Rows.Clear();
        foreach (var dispositivo in listaDispo)
        {
            int rowIndex = dgvDispo.Rows.Add(); // Adiciona uma nova linha e obtém o índice
            DataGridViewRow row = dgvDispo.Rows[rowIndex];

            // Especifica cada célula
            row.Cells["ID"].Value = dispositivo.ID;
            row.Cells["Aliquota"].Value = dispositivo.Aliquota;
            row.Cells["Descricao"].Value = dispositivo.Descricao;

            row.Cells["Status"].Value = ((bool)dispositivo.Status ? "Ativo" : "Inativo");
        }
    }
    private void btVerificar_Click(object sender, EventArgs e)
    {



    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

    private void dgvDispo_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
