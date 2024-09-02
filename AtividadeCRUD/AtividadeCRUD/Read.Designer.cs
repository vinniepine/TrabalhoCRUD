namespace AtividadeCRUD;

partial class Read
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        lbl2 = new Label();
        pn1 = new Panel();
        lbl4 = new Label();
        label1 = new Label();
        btVerificar = new Button();
        btVoltar = new Button();
        dataGridView1 = new DataGridView();
        panel1.SuspendLayout();
        pn1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(91, 159, 89);
        panel1.Controls.Add(lbl2);
        panel1.Location = new Point(-3, 573);
        panel1.Name = "panel1";
        panel1.Size = new Size(824, 40);
        panel1.TabIndex = 13;
        // 
        // lbl2
        // 
        lbl2.Font = new Font("OCR A Extended", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl2.ForeColor = SystemColors.ButtonFace;
        lbl2.Location = new Point(14, 0);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(793, 40);
        lbl2.TabIndex = 3;
        lbl2.Text = "Acadêmico: Vinicius de Oliveira Pinheiro";
        lbl2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pn1
        // 
        pn1.BackColor = Color.FromArgb(91, 159, 89);
        pn1.Controls.Add(lbl4);
        pn1.Location = new Point(-3, -1);
        pn1.Name = "pn1";
        pn1.Size = new Size(827, 117);
        pn1.TabIndex = 12;
        // 
        // lbl4
        // 
        lbl4.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl4.ForeColor = SystemColors.ButtonFace;
        lbl4.Location = new Point(12, 0);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(796, 117);
        lbl4.TabIndex = 0;
        lbl4.Text = "Cadastro de Dispositivo";
        lbl4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new Font("Agency FB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.ImageAlign = ContentAlignment.MiddleRight;
        label1.Location = new Point(51, 150);
        label1.Name = "label1";
        label1.Size = new Size(382, 48);
        label1.TabIndex = 14;
        label1.Text = "Dispositivos atualmente cadastrados :";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btVerificar
        // 
        btVerificar.BackColor = Color.FromArgb(91, 159, 89);
        btVerificar.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btVerificar.ForeColor = SystemColors.ButtonFace;
        btVerificar.Location = new Point(403, 454);
        btVerificar.Name = "btVerificar";
        btVerificar.Size = new Size(218, 46);
        btVerificar.TabIndex = 16;
        btVerificar.Text = "verificar";
        btVerificar.UseVisualStyleBackColor = false;
        btVerificar.Click += btVerificar_Click;
        // 
        // btVoltar
        // 
        btVoltar.BackColor = Color.IndianRed;
        btVoltar.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btVoltar.ForeColor = SystemColors.ButtonFace;
        btVoltar.Location = new Point(178, 454);
        btVoltar.Name = "btVoltar";
        btVoltar.Size = new Size(218, 46);
        btVoltar.TabIndex = 17;
        btVoltar.Text = "voltar";
        btVoltar.UseVisualStyleBackColor = false;
        btVoltar.Click += btVoltar_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToOrderColumns = true;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(178, 224);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(443, 224);
        dataGridView1.TabIndex = 18;
        // 
        // Read
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(820, 612);
        Controls.Add(dataGridView1);
        Controls.Add(btVoltar);
        Controls.Add(btVerificar);
        Controls.Add(label1);
        Controls.Add(panel1);
        Controls.Add(pn1);
        Name = "Read";
        Text = "Read";
        panel1.ResumeLayout(false);
        pn1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lbl2;
    private Panel pn1;
    private Label lbl4;
    private Label label1;
    private Button btVerificar;
    private Button btVoltar;
    private DataGridView dataGridView1;
}