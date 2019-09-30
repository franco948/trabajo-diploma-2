using ConsultorioDigital.Seguridad;
using ConsultorioDigital.UI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      LoginToolStripMenuItem_Click(this, null);
    }

    private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
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

      loginToolStripMenuItem.Text = Sesion.Instancia.Logueado ? "Logout" : "Login";
    }    
  }
}
