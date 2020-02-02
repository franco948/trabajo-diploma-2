using ConsultorioDigital.Seguridad;
using ConsultorioDigital.UI.Formularios;
using System;
using System.Windows.Forms;

namespace ConsultorioDigital.UI
{
  public partial class Principal : Form
  {
    public Principal()
    {
      InitializeComponent();
    }

    private void Principal_Load(object sender, EventArgs e)
    {
      mnuLogin_Click(this, null);
    }

    private void mnuLogin_Click(object sender, EventArgs e)
    {
      if (Sesion.Instancia.Logueado)
      {
        // TODO aca deberia ir el servicio haciendo el logout para trazar bitacora ?
        Sesion.Instancia.Logout();
      }
      else
      {
        LoginForm loginForm = new LoginForm();

        loginForm.ShowDialog(this);
      }

      mnuLogin.Text = Sesion.Instancia.Logueado ? "Logout" : "Login";
    }

    private void mnuPermisos_Click(object sender, EventArgs e)
    {
      PermisosForm form = new PermisosForm();

      form.MdiParent = this;
      form.Show();
    }

    private void mnuUsuarios_Click(object sender, EventArgs e)
    {
      UsuarioForm form = new UsuarioForm();

      form.MdiParent = this;
      form.Show();
    }

    private void mnuFamilias_Click(object sender, EventArgs e)
    {
      FamiliaForm form = new FamiliaForm();

      form.MdiParent = this;
      form.Show();
    }
  }
}
