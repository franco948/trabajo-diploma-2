using ConsultorioDigital.Seguridad;
using System.Windows.Forms;

namespace ConsultorioDigital.UI.Formularios
{
  public abstract partial class ObservadorBase : Form, IObservador
  {
    public ObservadorBase()
    {
      //InitializeComponent();
      IdiomaManager.Attach(this);
    }

    public void Actualizar()
    {
      foreach (Control c in Controls)
      {
        string tag = (string)c.Tag;
        Leyenda leyenda = IdiomaManager.GetLeyenda(tag);
        c.Text = leyenda.Texto;
      }
    }

    private void ObservadorBase_FormClosed(object sender, FormClosedEventArgs e)
    {
      IdiomaManager.Detach(this);
    }
  }
}
