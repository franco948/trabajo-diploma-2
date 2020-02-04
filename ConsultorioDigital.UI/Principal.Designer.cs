namespace ConsultorioDigital.UI
{
  partial class Principal
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
      this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuPermisos = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFamilias = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
      this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuCambiarIdioma = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.seguridadToolStripMenuItem,
            this.opcionesToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuLogin
      // 
      this.mnuLogin.Name = "mnuLogin";
      this.mnuLogin.Size = new System.Drawing.Size(49, 20);
      this.mnuLogin.Text = "Login";
      this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
      // 
      // seguridadToolStripMenuItem
      // 
      this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPermisos,
            this.mnuFamilias,
            this.mnuUsuarios});
      this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
      this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
      this.seguridadToolStripMenuItem.Text = "Seguridad";
      // 
      // mnuPermisos
      // 
      this.mnuPermisos.Name = "mnuPermisos";
      this.mnuPermisos.Size = new System.Drawing.Size(122, 22);
      this.mnuPermisos.Text = "Permisos";
      this.mnuPermisos.Click += new System.EventHandler(this.mnuPermisos_Click);
      // 
      // mnuFamilias
      // 
      this.mnuFamilias.Name = "mnuFamilias";
      this.mnuFamilias.Size = new System.Drawing.Size(122, 22);
      this.mnuFamilias.Text = "Familias";
      this.mnuFamilias.Click += new System.EventHandler(this.mnuFamilias_Click);
      // 
      // mnuUsuarios
      // 
      this.mnuUsuarios.Name = "mnuUsuarios";
      this.mnuUsuarios.Size = new System.Drawing.Size(122, 22);
      this.mnuUsuarios.Text = "Usuarios";
      this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
      // 
      // opcionesToolStripMenuItem
      // 
      this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaToolStripMenuItem});
      this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
      this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
      this.opcionesToolStripMenuItem.Text = "Configuracion";
      // 
      // idiomaToolStripMenuItem
      // 
      this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCambiarIdioma});
      this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
      this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.idiomaToolStripMenuItem.Text = "Idioma";
      // 
      // mnuCambiarIdioma
      // 
      this.mnuCambiarIdioma.Name = "mnuCambiarIdioma";
      this.mnuCambiarIdioma.Size = new System.Drawing.Size(180, 22);
      this.mnuCambiarIdioma.Text = "Cambiar idioma";
      this.mnuCambiarIdioma.Click += new System.EventHandler(this.mnuCambiarIdioma_Click);
      // 
      // Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Principal";
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Principal_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuLogin;
    private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuPermisos;
    private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
    private System.Windows.Forms.ToolStripMenuItem mnuFamilias;
    private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuCambiarIdioma;
  }
}

