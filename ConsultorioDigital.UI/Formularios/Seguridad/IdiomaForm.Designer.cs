namespace ConsultorioDigital.UI.Formularios
{
  partial class IdiomaForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnCambiar = new System.Windows.Forms.Button();
      this.cboIdiomas = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Idiomas";
      // 
      // btnCambiar
      // 
      this.btnCambiar.Location = new System.Drawing.Point(15, 52);
      this.btnCambiar.Name = "btnCambiar";
      this.btnCambiar.Size = new System.Drawing.Size(75, 23);
      this.btnCambiar.TabIndex = 2;
      this.btnCambiar.Text = "Cambiar";
      this.btnCambiar.UseVisualStyleBackColor = true;
      // 
      // cboIdiomas
      // 
      this.cboIdiomas.FormattingEnabled = true;
      this.cboIdiomas.Location = new System.Drawing.Point(15, 25);
      this.cboIdiomas.Name = "cboIdiomas";
      this.cboIdiomas.Size = new System.Drawing.Size(121, 21);
      this.cboIdiomas.TabIndex = 3;
      // 
      // IdiomaForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(257, 116);
      this.Controls.Add(this.cboIdiomas);
      this.Controls.Add(this.btnCambiar);
      this.Controls.Add(this.label1);
      this.Name = "IdiomaForm";
      this.Text = "IdiomaForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCambiar;
    private System.Windows.Forms.ComboBox cboIdiomas;
  }
}