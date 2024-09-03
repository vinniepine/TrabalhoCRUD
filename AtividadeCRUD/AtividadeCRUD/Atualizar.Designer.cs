namespace AtividadeCRUD;

partial class Atualizar
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
        btVoltar = new Button();
        txtDescricao = new TextBox();
        btUpdate = new Button();
        txtAliq = new TextBox();
        lblDescricao = new Label();
        cbStatus = new ComboBox();
        lblStatus = new Label();
        lblFee = new Label();
        label1 = new Label();
        txtID = new TextBox();
        panel1.SuspendLayout();
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
        panel1.TabIndex = 17;
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
        pn1.TabIndex = 16;
        // 
        // lbl4
        // 
        lbl4.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl4.ForeColor = SystemColors.ButtonFace;
        lbl4.Location = new Point(12, 0);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(796, 117);
        lbl4.TabIndex = 0;
        lbl4.Text = "Atualização de cadastros";
        lbl4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btVoltar
        // 
        btVoltar.BackColor = Color.IndianRed;
        btVoltar.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btVoltar.ForeColor = SystemColors.ButtonFace;
        btVoltar.Location = new Point(246, 436);
        btVoltar.Name = "btVoltar";
        btVoltar.Size = new Size(127, 46);
        btVoltar.TabIndex = 25;
        btVoltar.Text = "voltar";
        btVoltar.UseVisualStyleBackColor = false;
        btVoltar.Click += btVoltar_Click;
        // 
        // txtDescricao
        // 
        txtDescricao.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDescricao.Location = new Point(387, 320);
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(179, 36);
        txtDescricao.TabIndex = 3;
        txtDescricao.TextAlign = HorizontalAlignment.Right;
        // 
        // btUpdate
        // 
        btUpdate.BackColor = Color.FromArgb(91, 159, 89);
        btUpdate.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btUpdate.ForeColor = SystemColors.ButtonFace;
        btUpdate.Location = new Point(387, 436);
        btUpdate.Name = "btUpdate";
        btUpdate.Size = new Size(179, 46);
        btUpdate.TabIndex = 24;
        btUpdate.Text = "atualizar";
        btUpdate.UseVisualStyleBackColor = false;
        btUpdate.Click += btUpdate_Click;
        // 
        // txtAliq
        // 
        txtAliq.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtAliq.Location = new Point(387, 268);
        txtAliq.Name = "txtAliq";
        txtAliq.Size = new Size(179, 36);
        txtAliq.TabIndex = 2;
        txtAliq.TextAlign = HorizontalAlignment.Right;
        txtAliq.KeyUp += txtAliq_KeyUp;
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblDescricao.ForeColor = SystemColors.ButtonHighlight;
        lblDescricao.ImageAlign = ContentAlignment.MiddleRight;
        lblDescricao.Location = new Point(246, 318);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(100, 34);
        lblDescricao.TabIndex = 23;
        lblDescricao.Text = "Descrição";
        lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cbStatus
        // 
        cbStatus.BackColor = Color.FromArgb(197, 222, 198);
        cbStatus.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cbStatus.ForeColor = Color.DarkGreen;
        cbStatus.FormattingEnabled = true;
        cbStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
        cbStatus.Location = new Point(387, 371);
        cbStatus.Name = "cbStatus";
        cbStatus.Size = new Size(179, 37);
        cbStatus.TabIndex = 4;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblStatus.ForeColor = SystemColors.ButtonHighlight;
        lblStatus.ImageAlign = ContentAlignment.MiddleRight;
        lblStatus.Location = new Point(246, 371);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(68, 34);
        lblStatus.TabIndex = 22;
        lblStatus.Text = "Status";
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblFee
        // 
        lblFee.AutoSize = true;
        lblFee.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblFee.ForeColor = SystemColors.ButtonHighlight;
        lblFee.ImageAlign = ContentAlignment.MiddleRight;
        lblFee.Location = new Point(246, 266);
        lblFee.Name = "lblFee";
        lblFee.Size = new Size(85, 34);
        lblFee.TabIndex = 21;
        lblFee.Text = "Alíquota ";
        lblFee.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.ImageAlign = ContentAlignment.MiddleRight;
        label1.Location = new Point(246, 215);
        label1.Name = "label1";
        label1.Size = new Size(30, 34);
        label1.TabIndex = 26;
        label1.Text = "ID";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtID
        // 
        txtID.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtID.Location = new Point(387, 213);
        txtID.Name = "txtID";
        txtID.Size = new Size(179, 36);
        txtID.TabIndex = 1;
        txtID.TextAlign = HorizontalAlignment.Right;
        txtID.TextChanged += txtID_TextChanged;
        txtID.KeyPress += txtID_KeyPress;
        txtID.Leave += txtID_Leave;
        // 
        // Atualizar
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(820, 612);
        Controls.Add(txtID);
        Controls.Add(label1);
        Controls.Add(btVoltar);
        Controls.Add(txtDescricao);
        Controls.Add(btUpdate);
        Controls.Add(txtAliq);
        Controls.Add(lblDescricao);
        Controls.Add(cbStatus);
        Controls.Add(lblStatus);
        Controls.Add(lblFee);
        Controls.Add(panel1);
        Controls.Add(pn1);
        Name = "Atualizar";
        Text = "Atualizar";
        panel1.ResumeLayout(false);
        pn1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label lbl2;
    private Panel pn1;
    private Label lbl4;
    private Button btVoltar;
    private TextBox txtDescricao;
    private Button btUpdate;
    private TextBox txtAliq;
    private Label lblDescricao;
    private ComboBox cbStatus;
    private Label lblStatus;
    private Label lblFee;
    private Label label1;
    private TextBox txtID;
}