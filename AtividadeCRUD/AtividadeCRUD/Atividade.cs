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
        this.Hide();
        Create form = new Create();
        form.Show();
        form.FormClosed += (s, args) => this.Show();
    }

    private void Atividade_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void btList_Click(object sender, EventArgs e)
    {
        this.Hide();
        Read  form = new Read();
        form.Show();
        form.FormClosed += (s, args) => this.Show();
    }
}
