namespace AtividadeCRUD;

partial class Deletar
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
        components = new System.ComponentModel.Container();
        pn1 = new Panel();
        lbl4 = new Label();
        label1 = new Label();
        contextMenuStrip1 = new ContextMenuStrip(components);
        txtDelete = new TextBox();
        btDeletar = new Button();
        pn1.SuspendLayout();
        SuspendLayout();
        // 
        // pn1
        // 
        pn1.BackColor = Color.FromArgb(91, 159, 89);
        pn1.Controls.Add(lbl4);
        pn1.Location = new Point(-3, -1);
        pn1.Name = "pn1";
        pn1.Size = new Size(473, 117);
        pn1.TabIndex = 16;
        // 
        // lbl4
        // 
        lbl4.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl4.ForeColor = SystemColors.ButtonFace;
        lbl4.Location = new Point(12, 0);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(329, 117);
        lbl4.TabIndex = 0;
        lbl4.Text = "Exclusão de Dispositivo";
        lbl4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new Font("Agency FB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.ImageAlign = ContentAlignment.MiddleRight;
        label1.Location = new Point(22, 119);
        label1.Name = "label1";
        label1.Size = new Size(296, 107);
        label1.TabIndex = 18;
        label1.Text = "Digite o número de ID do dispositivo que deseja deletar:";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // txtDelete
        // 
        txtDelete.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDelete.Location = new Point(102, 229);
        txtDelete.Name = "txtDelete";
        txtDelete.Size = new Size(126, 36);
        txtDelete.TabIndex = 20;
        txtDelete.TextAlign = HorizontalAlignment.Center;
        // 
        // btDeletar
        // 
        btDeletar.BackColor = Color.IndianRed;
        btDeletar.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btDeletar.ForeColor = SystemColors.ButtonFace;
        btDeletar.Location = new Point(102, 271);
        btDeletar.Name = "btDeletar";
        btDeletar.Size = new Size(127, 46);
        btDeletar.TabIndex = 21;
        btDeletar.Text = "deletar";
        btDeletar.UseVisualStyleBackColor = false;
        btDeletar.Click += btDeletar_Click;
        // 
        // Deletar
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(24, 118, 50);
        ClientSize = new Size(342, 346);
        Controls.Add(btDeletar);
        Controls.Add(txtDelete);
        Controls.Add(label1);
        Controls.Add(pn1);
        Name = "Deletar";
        Text = "Deletar";
        pn1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Panel pn1;
    private Label lbl4;
    private Label label1;
    private ContextMenuStrip contextMenuStrip1;
    private TextBox txtDelete;
    private Button btDeletar;
}