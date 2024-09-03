namespace AtividadeCRUD;

partial class Listar
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        panel1 = new Panel();
        lbl2 = new Label();
        pn1 = new Panel();
        lbl4 = new Label();
        btVoltar = new Button();
        dgvDispo = new DataGridView();
        ID = new DataGridViewTextBoxColumn();
        Aliquota = new DataGridViewTextBoxColumn();
        Descricao = new DataGridViewTextBoxColumn();
        Status = new DataGridViewTextBoxColumn();
        panel1.SuspendLayout();
        pn1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDispo).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(91, 159, 89);
        panel1.Controls.Add(lbl2);
        panel1.Location = new Point(-3, 573);
        panel1.Name = "panel1";
        panel1.Size = new Size(824, 40);
        panel1.TabIndex = 15;
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
        pn1.TabIndex = 14;
        // 
        // lbl4
        // 
        lbl4.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl4.ForeColor = SystemColors.ButtonFace;
        lbl4.Location = new Point(12, 0);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(796, 117);
        lbl4.TabIndex = 0;
        lbl4.Text = "Lista de Dispositivos Cadastrados";
        lbl4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btVoltar
        // 
        btVoltar.BackColor = Color.IndianRed;
        btVoltar.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btVoltar.ForeColor = SystemColors.ButtonFace;
        btVoltar.Location = new Point(162, 462);
        btVoltar.Name = "btVoltar";
        btVoltar.Size = new Size(127, 46);
        btVoltar.TabIndex = 18;
        btVoltar.Text = "voltar";
        btVoltar.UseVisualStyleBackColor = false;
        btVoltar.Click += btVoltar_Click;
        // 
        // dgvDispo
        // 
        dgvDispo.AllowUserToOrderColumns = true;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(207, 228, 208);
        dataGridViewCellStyle1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = Color.Black;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
        dgvDispo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvDispo.BackgroundColor = Color.DarkSeaGreen;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dgvDispo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvDispo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDispo.Columns.AddRange(new DataGridViewColumn[] { ID, Aliquota, Descricao, Status });
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = SystemColors.Window;
        dataGridViewCellStyle5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
        dgvDispo.DefaultCellStyle = dataGridViewCellStyle5;
        dgvDispo.Location = new Point(162, 188);
        dgvDispo.Name = "dgvDispo";
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = SystemColors.Control;
        dataGridViewCellStyle6.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
        dgvDispo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
        dgvDispo.Size = new Size(529, 268);
        dgvDispo.TabIndex = 19;
        dgvDispo.CellContentClick += dgvDispo_CellContentClick;
        // 
        // ID
        // 
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        ID.DefaultCellStyle = dataGridViewCellStyle3;
        ID.HeaderText = "ID";
        ID.Name = "ID";
        // 
        // Aliquota
        // 
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
        Aliquota.DefaultCellStyle = dataGridViewCellStyle4;
        Aliquota.HeaderText = "Alíquota";
        Aliquota.Name = "Aliquota";
        // 
        // Descricao
        // 
        Descricao.HeaderText = "Descricao";
        Descricao.Name = "Descricao";
        Descricao.Width = 180;
        // 
        // Status
        // 
        Status.HeaderText = "Status";
        Status.Name = "Status";
        // 
        // Listar
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(820, 612);
        Controls.Add(dgvDispo);
        Controls.Add(btVoltar);
        Controls.Add(panel1);
        Controls.Add(pn1);
        Name = "Listar";
        Text = "Listar";
        panel1.ResumeLayout(false);
        pn1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvDispo).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lbl2;
    private Panel pn1;
    private Label lbl4;
    private Button btVoltar;
    private DataGridView dgvDispo;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Aliquota;
    private DataGridViewTextBoxColumn Descricao;
    private DataGridViewTextBoxColumn Status;
}