namespace AtividadeCRUD;

partial class FrontPage
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
        lbl1 = new Label();
        pn1 = new Panel();
        lbl2 = new Label();
        btAtividade = new Button();
        lbl3 = new Label();
        panel1 = new Panel();
        pn1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // lbl1
        // 
        lbl1.Font = new Font("Agency FB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl1.ForeColor = SystemColors.ButtonFace;
        lbl1.Location = new Point(40, 23);
        lbl1.Name = "lbl1";
        lbl1.Size = new Size(739, 168);
        lbl1.TabIndex = 0;
        lbl1.Text = resources.GetString("lbl1.Text");
        lbl1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pn1
        // 
        pn1.BackColor = Color.FromArgb(91, 159, 89);
        pn1.Controls.Add(lbl1);
        pn1.Location = new Point(0, 0);
        pn1.Name = "pn1";
        pn1.Size = new Size(827, 207);
        pn1.TabIndex = 1;
        // 
        // lbl2
        // 
        lbl2.Font = new Font("OCR A Extended", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl2.ForeColor = SystemColors.ButtonFace;
        lbl2.Location = new Point(0, 0);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(821, 40);
        lbl2.TabIndex = 2;
        lbl2.Text = "Acadêmico: Vinicius de Oliveira Pinheiro";
        lbl2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btAtividade
        // 
        btAtividade.BackColor = Color.FromArgb(91, 159, 89);
        btAtividade.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btAtividade.ForeColor = SystemColors.ButtonFace;
        btAtividade.Location = new Point(294, 350);
        btAtividade.Name = "btAtividade";
        btAtividade.Size = new Size(227, 103);
        btAtividade.TabIndex = 3;
        btAtividade.Text = "acessar atividade";
        btAtividade.UseVisualStyleBackColor = false;
        btAtividade.Click += btAtividade_Click;
        // 
        // lbl3
        // 
        lbl3.AutoSize = true;
        lbl3.Font = new Font("Agency FB", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl3.ForeColor = SystemColors.ButtonFace;
        lbl3.Location = new Point(40, 261);
        lbl3.Name = "lbl3";
        lbl3.Size = new Size(307, 34);
        lbl3.TabIndex = 4;
        lbl3.Text = ">> Atividade - CRUD de Dispositivos";
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(91, 159, 89);
        panel1.Controls.Add(lbl2);
        panel1.Location = new Point(0, 574);
        panel1.Name = "panel1";
        panel1.Size = new Size(824, 40);
        panel1.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(820, 612);
        Controls.Add(panel1);
        Controls.Add(lbl3);
        Controls.Add(btAtividade);
        Controls.Add(pn1);
        Name = "Form1";
        Text = "Form1";
        FormClosing += Form1_FormClosing;
        pn1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl1;
    private Panel pn1;
    private Label lbl2;
    private Button btAtividade;
    private Label lbl3;
    private Panel panel1;
}
