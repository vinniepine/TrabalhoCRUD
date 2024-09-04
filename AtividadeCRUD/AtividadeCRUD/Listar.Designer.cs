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
        DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
        panel1 = new Panel();
        lbl2 = new Label();
        dgvDispo = new DataGridView();
        ID = new DataGridViewTextBoxColumn();
        Aliquota = new DataGridViewTextBoxColumn();
        Descricao = new DataGridViewTextBoxColumn();
        Status = new DataGridViewTextBoxColumn();
        pn1 = new Panel();
        lbl4 = new Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDispo).BeginInit();
        pn1.SuspendLayout();
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
        // dgvDispo
        // 
        dgvDispo.AllowUserToOrderColumns = true;
        dataGridViewCellStyle9.BackColor = Color.FromArgb(207, 228, 208);
        dataGridViewCellStyle9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle9.ForeColor = Color.Black;
        dataGridViewCellStyle9.SelectionBackColor = SystemColors.MenuHighlight;
        dgvDispo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
        dgvDispo.BackgroundColor = Color.DarkSeaGreen;
        dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle10.BackColor = SystemColors.Control;
        dataGridViewCellStyle10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
        dgvDispo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
        dgvDispo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDispo.Columns.AddRange(new DataGridViewColumn[] { ID, Aliquota, Descricao, Status });
        dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle15.BackColor = SystemColors.Window;
        dataGridViewCellStyle15.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
        dgvDispo.DefaultCellStyle = dataGridViewCellStyle15;
        dgvDispo.Location = new Point(0, 85);
        dgvDispo.Name = "dgvDispo";
        dgvDispo.ReadOnly = true;
        dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle16.BackColor = SystemColors.Control;
        dataGridViewCellStyle16.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
        dgvDispo.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
        dgvDispo.Size = new Size(524, 288);
        dgvDispo.TabIndex = 19;
        dgvDispo.CellContentClick += dgvDispo_CellContentClick;
        // 
        // ID
        // 
        dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
        ID.DefaultCellStyle = dataGridViewCellStyle11;
        ID.HeaderText = "ID";
        ID.Name = "ID";
        ID.ReadOnly = true;
        // 
        // Aliquota
        // 
        dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
        Aliquota.DefaultCellStyle = dataGridViewCellStyle12;
        Aliquota.HeaderText = "Alíquota";
        Aliquota.Name = "Aliquota";
        Aliquota.ReadOnly = true;
        // 
        // Descricao
        // 
        dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
        Descricao.DefaultCellStyle = dataGridViewCellStyle13;
        Descricao.HeaderText = "Descricao";
        Descricao.Name = "Descricao";
        Descricao.ReadOnly = true;
        Descricao.Width = 180;
        // 
        // Status
        // 
        dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
        Status.DefaultCellStyle = dataGridViewCellStyle14;
        Status.HeaderText = "Status";
        Status.Name = "Status";
        Status.ReadOnly = true;
        // 
        // pn1
        // 
        pn1.BackColor = Color.FromArgb(91, 159, 89);
        pn1.Controls.Add(lbl4);
        pn1.Location = new Point(0, -1);
        pn1.Name = "pn1";
        pn1.Size = new Size(524, 91);
        pn1.TabIndex = 20;
        // 
        // lbl4
        // 
        lbl4.Font = new Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl4.ForeColor = SystemColors.ButtonFace;
        lbl4.Location = new Point(3, 0);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(518, 83);
        lbl4.TabIndex = 0;
        lbl4.Text = "Lista de Dispositivos Cadastrados";
        lbl4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Listar
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(524, 371);
        Controls.Add(pn1);
        Controls.Add(dgvDispo);
        Controls.Add(panel1);
        Name = "Listar";
        Text = "Listar";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvDispo).EndInit();
        pn1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lbl2;
    private DataGridView dgvDispo;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Aliquota;
    private DataGridViewTextBoxColumn Descricao;
    private DataGridViewTextBoxColumn Status;
    private Panel pn1;
    private Label lbl4;
}