namespace ConsultorioDigital.UI.Formularios
{
  partial class FamiliaForm
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
      this.cboFamilias = new System.Windows.Forms.ComboBox();
      this.treFamilia = new System.Windows.Forms.TreeView();
      this.btnCrear = new System.Windows.Forms.Button();
      this.trePermisos = new System.Windows.Forms.TreeView();
      this.btnRemover = new System.Windows.Forms.Button();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Familia";
      // 
      // cboFamilias
      // 
      this.cboFamilias.FormattingEnabled = true;
      this.cboFamilias.Location = new System.Drawing.Point(15, 26);
      this.cboFamilias.Name = "cboFamilias";
      this.cboFamilias.Size = new System.Drawing.Size(216, 21);
      this.cboFamilias.TabIndex = 1;
      this.cboFamilias.SelectedIndexChanged += new System.EventHandler(this.cboFamilias_SelectedIndexChanged);
      // 
      // treFamilia
      // 
      this.treFamilia.Location = new System.Drawing.Point(15, 53);
      this.treFamilia.Name = "treFamilia";
      this.treFamilia.Size = new System.Drawing.Size(216, 225);
      this.treFamilia.TabIndex = 2;
      // 
      // btnCrear
      // 
      this.btnCrear.Location = new System.Drawing.Point(237, 53);
      this.btnCrear.Name = "btnCrear";
      this.btnCrear.Size = new System.Drawing.Size(75, 23);
      this.btnCrear.TabIndex = 3;
      this.btnCrear.Text = "+";
      this.btnCrear.UseVisualStyleBackColor = true;
      // 
      // trePermisos
      // 
      this.trePermisos.Location = new System.Drawing.Point(318, 26);
      this.trePermisos.Name = "trePermisos";
      this.trePermisos.Size = new System.Drawing.Size(216, 252);
      this.trePermisos.TabIndex = 4;
      // 
      // btnRemover
      // 
      this.btnRemover.Location = new System.Drawing.Point(237, 111);
      this.btnRemover.Name = "btnRemover";
      this.btnRemover.Size = new System.Drawing.Size(75, 23);
      this.btnRemover.TabIndex = 5;
      this.btnRemover.Text = ">>";
      this.btnRemover.UseVisualStyleBackColor = true;
      this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(237, 82);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(75, 23);
      this.btnAgregar.TabIndex = 6;
      this.btnAgregar.Text = "<<";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(315, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Permisos";
      // 
      // FamiliaForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.btnRemover);
      this.Controls.Add(this.trePermisos);
      this.Controls.Add(this.btnCrear);
      this.Controls.Add(this.treFamilia);
      this.Controls.Add(this.cboFamilias);
      this.Controls.Add(this.label1);
      this.Name = "FamiliaForm";
      this.Text = "FamiliaForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboFamilias;
    private System.Windows.Forms.TreeView treFamilia;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.TreeView trePermisos;
    private System.Windows.Forms.Button btnRemover;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Label label2;
  }
}