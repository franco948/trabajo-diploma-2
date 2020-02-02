namespace ConsultorioDigital.UI.Formularios
{
  partial class PermisosForm
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
      this.trePermisos = new System.Windows.Forms.TreeView();
      this.trePermisosUsuario = new System.Windows.Forms.TreeView();
      this.label1 = new System.Windows.Forms.Label();
      this.cboUsuarios = new System.Windows.Forms.ComboBox();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // trePermisos
      // 
      this.trePermisos.Location = new System.Drawing.Point(15, 25);
      this.trePermisos.Name = "trePermisos";
      this.trePermisos.Size = new System.Drawing.Size(264, 272);
      this.trePermisos.TabIndex = 0;
      // 
      // trePermisosUsuario
      // 
      this.trePermisosUsuario.Location = new System.Drawing.Point(366, 52);
      this.trePermisosUsuario.Name = "trePermisosUsuario";
      this.trePermisosUsuario.Size = new System.Drawing.Size(264, 245);
      this.trePermisosUsuario.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Permisos";
      // 
      // cboUsuarios
      // 
      this.cboUsuarios.FormattingEnabled = true;
      this.cboUsuarios.Location = new System.Drawing.Point(366, 25);
      this.cboUsuarios.Name = "cboUsuarios";
      this.cboUsuarios.Size = new System.Drawing.Size(264, 21);
      this.cboUsuarios.TabIndex = 3;
      this.cboUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboUsuarios_SelectedIndexChanged);
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(285, 25);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(75, 23);
      this.btnAgregar.TabIndex = 4;
      this.btnAgregar.Text = ">>";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(285, 54);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 5;
      this.btnEliminar.Text = "<<";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(363, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Usuarios";
      // 
      // PermisosForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.cboUsuarios);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.trePermisosUsuario);
      this.Controls.Add(this.trePermisos);
      this.Name = "PermisosForm";
      this.Text = "PermisosForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView trePermisos;
    private System.Windows.Forms.TreeView trePermisosUsuario;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboUsuarios;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Label label2;
  }
}