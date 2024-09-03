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
public partial class Deletar : Form
{
    public Deletar()
    {
        InitializeComponent();
    }

    private void btDeletar_Click(object sender, EventArgs e)
    {
        try
        {
            Dispositivo device = new Dispositivo();
            if (!int.TryParse(txtDelete.Text, out int num))
            {
                MessageBox.Show("Número Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método se a entrada for inválida
            }
            device.ID = num;
            DispositivoDAO sDAO = new DispositivoDAO();
            sDAO.Delete(device);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro:"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            MessageBox.Show("Dispositivo deletado", "IFRO; Ji-Paraná", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDelete.Clear();

        }

    }
}
