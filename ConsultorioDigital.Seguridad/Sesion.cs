using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDigital.Seguridad
{
  public class Sesion
  {
    private static Sesion _instancia = null;
    private static readonly object _lock = new object();

    private Usuario _usuario;

    public static Sesion Instancia
    {
      get
      {
        if (_instancia == null)
        {
          lock (_lock)
          {
            if (_instancia == null)
            {
              _instancia = new Sesion();
            }
          }
        }

        return _instancia;
      }
    }

    public Usuario Usuario => _usuario;

    public void Login(Usuario usuario)
    {
      // TODO traducir mensaje de error
      if (_usuario != null) throw new InvalidOperationException("Ya hay una sesión abierta");

      _usuario = usuario;
    }

    public void Logout()
    {
      _usuario = null;
    }

    public bool Logueado => Usuario != null;
  }
}
