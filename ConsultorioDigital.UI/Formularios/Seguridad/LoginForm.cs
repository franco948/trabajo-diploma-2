using ConsultorioDigital.BLL;
using ConsultorioDigital.Seguridad;
using ConsultorioDigital.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDigital.UI.Formularios
{
  public partial class LoginForm : Form
  {
    private readonly SesionBLL _sesionBLL;

    public LoginForm()
    {
      InitializeComponent();

      _sesionBLL = new SesionBLL();
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
      Usuario usuario = new Usuario(txtEmail.Text, txtContraseña.Text);

      bool autenticado = _sesionBLL.Login(usuario);

      if (autenticado)
      {
        // TODO usar traductor
        MessageBox.Show("Inicio de sesion exitoso");
        Close();
      }
      else
      {
        MessageBoxHelper.ShowError("Email o contraseña incorrectos");
      }
    }
  }
}
