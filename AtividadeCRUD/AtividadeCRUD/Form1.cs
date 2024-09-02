namespace AtividadeCRUD;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        MaximizeBox = false;
    }

    private void btAtividade_Click(object sender, EventArgs e)
    {
        OpenNewForm();

    }
    private void OpenNewForm()
    {
        // Fecha o formul�rio atual (Form1)
        this.Hide();
        // Cria uma inst�ncia do novo formul�rio (Form2)
        Atividade newForm = new Atividade();

        // Abre o novo formul�rio
        newForm.Show();


        newForm.FormClosed += (s, args) => this.Show();

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}
