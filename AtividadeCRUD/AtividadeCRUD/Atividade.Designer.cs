namespace AtividadeCRUD;

partial class Atividade
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
        pn2 = new Panel();
        lblHeadger = new Label();
        btCreate = new Button();
        btList = new Button();
        btUpdate = new Button();
        btDelete = new Button();
        lblEnunciate = new Label();
        panel1 = new Panel();
        lbl2 = new Label();
        pn2.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // pn2
        // 
        pn2.BackColor = Color.FromArgb(91, 159, 89);
        pn2.Controls.Add(lblHeadger);
        pn2.Location = new Point(0, -1);
        pn2.Name = "pn2";
        pn2.Size = new Size(827, 117);
        pn2.TabIndex = 2;
        // 
        // lblHeadger
        // 
        lblHeadger.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblHeadger.ForeColor = SystemColors.ButtonFace;
        lblHeadger.Location = new Point(0, 0);
        lblHeadger.Name = "lblHeadger";
        lblHeadger.Size = new Size(824, 117);
        lblHeadger.TabIndex = 0;
        lblHeadger.Text = "Dispositivos (máquinas de cartão)";
        lblHeadger.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btCreate
        // 
        btCreate.BackColor = Color.FromArgb(91, 159, 89);
        btCreate.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btCreate.ForeColor = SystemColors.ButtonFace;
        btCreate.Location = new Point(323, 303);
        btCreate.Name = "btCreate";
        btCreate.Size = new Size(161, 46);
        btCreate.TabIndex = 4;
        btCreate.Text = "cadastrar";
        btCreate.UseVisualStyleBackColor = false;
        btCreate.Click += btCreate_Click;
        // 
        // btList
        // 
        btList.BackColor = Color.FromArgb(91, 159, 89);
        btList.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btList.ForeColor = SystemColors.ButtonFace;
        btList.Location = new Point(323, 355);
        btList.Name = "btList";
        btList.Size = new Size(161, 46);
        btList.TabIndex = 5;
        btList.Text = "verificar";
        btList.UseVisualStyleBackColor = false;
        btList.Click += btList_Click;
        // 
        // btUpdate
        // 
        btUpdate.BackColor = Color.FromArgb(91, 159, 89);
        btUpdate.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btUpdate.ForeColor = SystemColors.ButtonFace;
        btUpdate.Location = new Point(323, 459);
        btUpdate.Name = "btUpdate";
        btUpdate.Size = new Size(161, 46);
        btUpdate.TabIndex = 6;
        btUpdate.Text = "atualizar";
        btUpdate.UseVisualStyleBackColor = false;
        btUpdate.Click += btUpdate_Click;
        // 
        // btDelete
        // 
        btDelete.BackColor = Color.FromArgb(91, 159, 89);
        btDelete.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btDelete.ForeColor = SystemColors.ButtonFace;
        btDelete.Location = new Point(323, 407);
        btDelete.Name = "btDelete";
        btDelete.Size = new Size(161, 46);
        btDelete.TabIndex = 7;
        btDelete.Text = "deletar";
        btDelete.UseVisualStyleBackColor = false;
        btDelete.Click += btDelete_Click;
        // 
        // lblEnunciate
        // 
        lblEnunciate.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEnunciate.ForeColor = SystemColors.ButtonFace;
        lblEnunciate.Location = new Point(152, 162);
        lblEnunciate.Name = "lblEnunciate";
        lblEnunciate.Size = new Size(506, 127);
        lblEnunciate.TabIndex = 8;
        lblEnunciate.Text = "Selecione se deseja cadastrar um novo dispositivo, verificar os dispositivos já cadastrados, deletar dispositivos cadastrados ou atualizar dados cadastrados.";
        lblEnunciate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(91, 159, 89);
        panel1.Controls.Add(lbl2);
        panel1.Location = new Point(0, 572);
        panel1.Name = "panel1";
        panel1.Size = new Size(824, 40);
        panel1.TabIndex = 12;
        // 
        // lbl2
        // 
        lbl2.Font = new Font("OCR A Extended", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl2.ForeColor = SystemColors.ButtonFace;
        lbl2.Location = new Point(0, 0);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(821, 40);
        lbl2.TabIndex = 13;
        lbl2.Text = "Acadêmico: Vinicius de Oliveira Pinheiro";
        lbl2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Atividade
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(820, 612);
        Controls.Add(panel1);
        Controls.Add(lblEnunciate);
        Controls.Add(btDelete);
        Controls.Add(btUpdate);
        Controls.Add(btList);
        Controls.Add(btCreate);
        Controls.Add(pn2);
        Name = "Atividade";
        Text = "Atividade";
        FormClosing += Atividade_FormClosing;
        Load += Atividade_Load;
        pn2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel pn2;
    private Label lblHeadger;
    private Button btCreate;
    private Button btList;
    private Button btUpdate;
    private Button btDelete;
    private Label lblEnunciate;
    private Panel panel1;
    private Label lbl2;
}