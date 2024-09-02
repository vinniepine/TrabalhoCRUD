using AtividadeCRUD.DAO;
using AtividadeCRUD.Models;
using MySql.Data.MySqlClient;
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
public partial class Read : Form
{
    private DispositivoDAO deviceDAO;
    public Read()
    {
        InitializeComponent();
        deviceDAO = new DispositivoDAO();
        Read_Load();
        this.MaximizeBox = false;

    }


    private void Read_Load()
    {
    }

    private void btVoltar_Click(object sender, EventArgs e)
    {
    }

    private void btVerificar_Click(object sender, EventArgs e)
    {
        try
        {
            List<Dispositivo> d = deviceDAO.List();
            dataGridView1.DataSource = d;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro: {ex.Message}", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
