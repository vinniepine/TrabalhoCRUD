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
public partial class Atividade : Form
{
    public Atividade()
    {
        InitializeComponent();
        MaximizeBox = false;
    }
    private void Atividade_Load(object sender, EventArgs e)
    {

    }

    private void btCreate_Click(object sender, EventArgs e)
    {
        // this.Hide();
        Inserir form = new Inserir();
        form.Show();
        // form.FormClosed += (s, args) => this.Show();
    }

    private void Atividade_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void btList_Click(object sender, EventArgs e)
    {
        Listar form = new Listar();
        form.Show();

    }

    private void btDelete_Click(object sender, EventArgs e)
    {
        Deletar form = new Deletar();
        form.Show();
    }

    private void btUpdate_Click(object sender, EventArgs e)
    {
        Atualizar form = new Atualizar();
        form.Show();
    }
}
