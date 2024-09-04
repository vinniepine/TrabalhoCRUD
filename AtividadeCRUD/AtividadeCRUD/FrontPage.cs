namespace AtividadeCRUD;

public partial class FrontPage : Form
{
    public FrontPage()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
    }

    private void btAtividade_Click(object sender, EventArgs e)
    {
        OpenNewForm();

    }
    private void OpenNewForm()
    {
        // Fecha o formulário atual (Form1)
        this.Hide();
        // Cria uma instância do novo formulário (Form2)
        Atividade newForm = new Atividade();

        // Abre o novo formulário
        newForm.Show();


        newForm.FormClosed += (s, args) => this.Show();

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}
