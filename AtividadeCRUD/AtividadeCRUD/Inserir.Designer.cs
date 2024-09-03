namespace AtividadeCRUD;

partial class Inserir
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
        pn1 = new Panel();
        lbl4 = new Label();
        lblFee = new Label();
        lblStatus = new Label();
        cbStatus = new ComboBox();
        lblDescricao = new Label();
        label1 = new Label();
        panel1 = new Panel();
        lbl2 = new Label();
        txtAliq = new TextBox();
        btCreate = new Button();
        txtDescricao = new TextBox();
        btVoltar = new Button();
        pn1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // pn1
        // 
        pn1.BackColor = Color.FromArgb(91, 159, 89);
        pn1.Controls.Add(lbl4);
        pn1.Location = new Point(0, 0);
        pn1.Name = "pn1";
        pn1.Size = new Size(827, 117);
        pn1.TabIndex = 3;
        // 
        // lbl4
        // 
        lbl4.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl4.ForeColor = SystemColors.ButtonFace;
        lbl4.Location = new Point(3, 0);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(821, 117);
        lbl4.TabIndex = 0;
        lbl4.Text = "Cadastro de Dispositivo";
        lbl4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblFee
        // 
        lblFee.AutoSize = true;
        lblFee.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblFee.ForeColor = SystemColors.ButtonHighlight;
        lblFee.ImageAlign = ContentAlignment.MiddleRight;
        lblFee.Location = new Point(240, 268);
        lblFee.Name = "lblFee";
        lblFee.Size = new Size(85, 34);
        lblFee.TabIndex = 4;
        lblFee.Text = "Alíquota ";
        lblFee.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblStatus.ForeColor = SystemColors.ButtonHighlight;
        lblStatus.ImageAlign = ContentAlignment.MiddleRight;
        lblStatus.Location = new Point(240, 373);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(68, 34);
        lblStatus.TabIndex = 6;
        lblStatus.Text = "Status";
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cbStatus
        // 
        cbStatus.BackColor = Color.FromArgb(197, 222, 198);
        cbStatus.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cbStatus.ForeColor = Color.DarkGreen;
        cbStatus.FormattingEnabled = true;
        cbStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
        cbStatus.Location = new Point(381, 373);
        cbStatus.Name = "cbStatus";
        cbStatus.Size = new Size(179, 37);
        cbStatus.TabIndex = 3;
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblDescricao.ForeColor = SystemColors.ButtonHighlight;
        lblDescricao.ImageAlign = ContentAlignment.MiddleRight;
        lblDescricao.Location = new Point(240, 320);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(100, 34);
        lblDescricao.TabIndex = 8;
        lblDescricao.Text = "Descrição";
        lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.Font = new Font("Agency FB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.ImageAlign = ContentAlignment.MiddleRight;
        label1.Location = new Point(0, 153);
        label1.Name = "label1";
        label1.Size = new Size(827, 95);
        label1.TabIndex = 10;
        label1.Text = "Por favor, preencha os seguintes espaços para cadastrar novo dispositivo.";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(91, 159, 89);
        panel1.Controls.Add(lbl2);
        panel1.Location = new Point(0, 574);
        panel1.Name = "panel1";
        panel1.Size = new Size(824, 40);
        panel1.TabIndex = 11;
        // 
        // lbl2
        // 
        lbl2.Font = new Font("OCR A Extended", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl2.ForeColor = SystemColors.ButtonFace;
        lbl2.Location = new Point(0, 0);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(821, 40);
        lbl2.TabIndex = 3;
        lbl2.Text = "Acadêmico: Vinicius de Oliveira Pinheiro";
        lbl2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtAliq
        // 
        txtAliq.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtAliq.Location = new Point(381, 270);
        txtAliq.Name = "txtAliq";
        txtAliq.Size = new Size(179, 36);
        txtAliq.TabIndex = 1;
        txtAliq.TextAlign = HorizontalAlignment.Right;
        txtAliq.KeyUp += txtAliq_KeyUp;
        // 
        // btCreate
        // 
        btCreate.BackColor = Color.FromArgb(91, 159, 89);
        btCreate.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btCreate.ForeColor = SystemColors.ButtonFace;
        btCreate.Location = new Point(381, 438);
        btCreate.Name = "btCreate";
        btCreate.Size = new Size(179, 46);
        btCreate.TabIndex = 12;
        btCreate.Text = "cadastrar";
        btCreate.UseVisualStyleBackColor = false;
        btCreate.Click += btCreate_Click;
        // 
        // txtDescricao
        // 
        txtDescricao.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDescricao.Location = new Point(381, 322);
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(179, 36);
        txtDescricao.TabIndex = 2;
        // 
        // btVoltar
        // 
        btVoltar.BackColor = Color.IndianRed;
        btVoltar.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btVoltar.ForeColor = SystemColors.ButtonFace;
        btVoltar.Location = new Point(240, 438);
        btVoltar.Name = "btVoltar";
        btVoltar.Size = new Size(127, 46);
        btVoltar.TabIndex = 13;
        btVoltar.Text = "voltar";
        btVoltar.UseVisualStyleBackColor = false;
        btVoltar.Click += btVoltar_Click;
        // 
        // Inserir
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(820, 612);
        Controls.Add(btVoltar);
        Controls.Add(txtDescricao);
        Controls.Add(btCreate);
        Controls.Add(txtAliq);
        Controls.Add(panel1);
        Controls.Add(label1);
        Controls.Add(lblDescricao);
        Controls.Add(cbStatus);
        Controls.Add(lblStatus);
        Controls.Add(lblFee);
        Controls.Add(pn1);
        Name = "Inserir";
        Text = "Cadastrar";
        pn1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel pn1;
    private Label lbl4;
    private Label lblFee;
    private Label lblStatus;
    private ComboBox cbStatus;
    private Label lblDescricao;
    private Label label1;
    private Panel panel1;
    private TextBox txtAliq;
    private Button btCreate;
    private Label lbl2;
    private TextBox txtDescricao;
    private Button btVoltar;
}